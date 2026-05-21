using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Utils; // Necessário para gerar o ID da imagem
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Microsoft.Extensions.Configuration;

public class ServicoEmail
{
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _emailAutenticado;
    private readonly string[] _scopes = new[] { "https://mail.google.com/" };

    public ServicoEmail()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        _clientId = config["GoogleOAuth:ClientId"];
        _clientSecret = config["GoogleOAuth:ClientSecret"];
        _emailAutenticado = config["GoogleOAuth:EmailAutenticado"];
    }

    public async Task<bool> EnviarEmailAsync(string destinatario, string assunto, string conteudoTexto)
    {
        UserCredential credential;

        try
        {
            string caminhoToken = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PFlowTokens");

            credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets { ClientId = _clientId, ClientSecret = _clientSecret },
                _scopes,
                _emailAutenticado,
                CancellationToken.None,
                new FileDataStore(caminhoToken, true)
            );

            if (credential.Token.IsExpired(Google.Apis.Util.SystemClock.Default))
            {
                await credential.RefreshTokenAsync(CancellationToken.None);
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[ERRO OAUTH] Falha na autenticação: {ex.Message}");
            Console.ResetColor();
            return false;
        }

        // --- CONSTRUÇÃO DO EMAIL MULTIPART COM HTML ---
        var mensagem = new MimeMessage();
        mensagem.From.Add(new MailboxAddress("PFlow Sistema", _emailAutenticado));
        mensagem.To.Add(new MailboxAddress("", destinatario));
        mensagem.Subject = assunto;

        var builder = new BodyBuilder();

        // 1. Procuramos e anexamos a logo local de forma inline (embutida)
        string caminhoLogo = Path.Combine(AppContext.BaseDirectory, "appicon.png");
        string imageCid = "";

        if (File.Exists(caminhoLogo))
        {
            var imagem = builder.LinkedResources.Add(caminhoLogo);
            // Geramos uma ID única para referenciar a imagem dentro do HTML
            imagem.ContentId = MimeUtils.GenerateMessageId();
            imageCid = imagem.ContentId;
        }

        // Substitui quebras de linha normais (\n) por <br/> para o HTML renderizar corretamente o texto digitado
        string conteudoHtmlFormatado = conteudoTexto.Replace("\n", "<br/>");

        // 2. Montamos o Template HTML usando a paleta de cores do PFlow (Azul #0A51A1 e Grená #801020)
        builder.HtmlBody = $@"
        <div style='font-family: Arial, sans-serif; background-color: #f4f6f9; padding: 30px; margin: 0;'>
            <table align='center' border='0' cellpadding='0' cellspacing='0' width='600' style='background-color: #ffffff; border-radius: 8px; overflow: hidden; box-shadow: 0 4px 10px rgba(0,0,0,0.05); border-left: 6px solid #801020;'>
                
                <tr>
                    <td bgcolor='#0A51A1' style='padding: 25px 30px; text-align: left;'>
                        <h1 style='color: #ffffff; margin: 0; font-size: 22px; font-weight: bold; letter-spacing: 0.5px;'>PFlow Gestão Escolar</h1>
                        <p style='color: #d0e1fd; margin: 5px 0 0 0; font-size: 13px;'>Notificação do Sistema</p>
                    </td>
                </tr>

                <tr>
                    <td style='padding: 35px 30px; color: #333333; line-height: 1.6; font-size: 15px;'>
                        <p style='margin-top: 0;'>Prezado(a),</p>
                        <p style='margin-bottom: 25px;'>{conteudoHtmlFormatado}</p>
                        <p style='margin-bottom: 0; font-size: 14px; color: #666666;'>Atenciosamente,<br><strong>Equipe PFlow</strong></p>
                    </td>
                </tr>

                <tr>
                    <td bgcolor='#f8f9fa' style='padding: 20px 30px; border-top: 1px solid #eef0f3;'>
                        <table width='100%' border='0' cellpadding='0' cellspacing='0'>
                            <tr>
                                <td style='vertical-align: middle; color: #666666; font-size: 12px; line-height: 1.5;'>
                                    <strong style='color: #0A51A1; font-size: 13px;'>PFlow Gestão Escolar</strong><br>
                                    Desenvolvido por: {System.Net.WebUtility.HtmlEncode("Rannyere Costa")}<br>
                                    Contato: <a href='mailto:raniecosta80@gmail.com' style='color: #801020; text-decoration: none; font-weight: bold;'>raniecosta80@gmail.com</a>
                                </td>
                                
                                <td style='text-align: right; width: 65px; vertical-align: middle;'>
                                    {(string.IsNullOrEmpty(imageCid) ? "" : $"<img src='cid:{imageCid}' alt='PFlow Logo' width='55' style='display: block; margin-left: auto; border-radius: 4px;' />")}
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>

            </table>
            
            <p style='text-align: center; color: #999999; font-size: 11px; margin-top: 20px;'>
                Este é um e-mail automático gerado pelo ecossistema PFlow. Por favor, não responda diretamente.
            </p>
        </div>";

        // Caso o leitor de e-mail do destinatário seja muito antigo e não suporte HTML (raro hoje), enviamos o plano B em texto puro
        builder.TextBody = conteudoTexto + $"\n\n---\nPFlow Gestão Escolar\nRannyere Costa\nraniecosta80@gmail.com";

        mensagem.Body = builder.ToMessageBody();

        using (var client = new SmtpClient())
        {
            try
            {
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                var oauth2 = new SaslMechanismOAuth2(_emailAutenticado, credential.Token.AccessToken);
                await client.AuthenticateAsync(oauth2);

                await client.SendAsync(mensagem);
                return true;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n[ERRO SMTP] Falha ao enviar: {ex.Message}");
                Console.ResetColor();
                return false;
            }
            finally
            {
                await client.DisconnectAsync(true);
            }
        }
    }
}