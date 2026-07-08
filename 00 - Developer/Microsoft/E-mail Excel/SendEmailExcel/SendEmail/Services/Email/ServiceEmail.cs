using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using MimeKit;
using MimeKit.Utils;
using MailKit.Net.Smtp;
using MailKit.Security;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;

using Microsoft.Extensions.Configuration;

public class ServiceEmail
{
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _emailAutenticado;
    private readonly string[] _scopes = new[] { "https://mail.google.com/" };

    public ServiceEmail()
    {
        // Lê as configurações de segurança do appsettings.json (Longe do GitHub!)
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        _clientId = config["GoogleOAuth:ClientId"];
        _clientSecret = config["GoogleOAuth:ClientSecret"];
        _emailAutenticado = config["GoogleOAuth:EmailAutenticado"];
    }

    public async Task<bool> EnviarEmailAsync(
        string destinatario, 
        string assunto, 
        string conteudoTexto, 
        List<string> caminhosAnexos = null)
    {
        // --- AUTENTICAÇÃO OAUTH2 GOOGLE ---
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

            await credential.RefreshTokenAsync(CancellationToken.None);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[ERRO OAUTH] Falha na autenticação: {ex.Message}");
            Console.ResetColor();
            return false;
        }


        // --- CRIAÇÃO DA MENSAGEM BASE ---
        var mensagem = new MimeMessage();
        mensagem.From.Add(new MailboxAddress("PFlow Sistema", _emailAutenticado));
        mensagem.To.Add(new MailboxAddress("", destinatario));
        mensagem.Subject = assunto;

        var builder = new BodyBuilder();


        // --- VINCULAÇÃO DA LOGO INLINE ---
        string caminhoLogo = Path.Combine(AppContext.BaseDirectory, "appicon.png");
        string imageCid = "";

        if (File.Exists(caminhoLogo))
        {
            var imagem = builder.LinkedResources.Add(caminhoLogo);
            imagem.ContentId = MimeUtils.GenerateMessageId();
            imageCid = imagem.ContentId;
        }


        // --- LEITURA DO TEMPLATE HTML EXTERNO ---
        string caminhoTemplate = Path.Combine(AppContext.BaseDirectory, "Email", "template-padrao.html");
        string htmlTemplate = "";

        if (File.Exists(caminhoTemplate))
        {
            htmlTemplate = File.ReadAllText(caminhoTemplate);
        }
        else
        {
            htmlTemplate = "<html><body>{CONTEUDO}</body></html>";
        }


        // --- SUBSTITUIÇÕES DINÂMICAS NO HTML ---
        string conteudoHtmlFormatado = conteudoTexto.Replace("\n", "<br/>");
        htmlTemplate = htmlTemplate.Replace("{CONTEUDO}", conteudoHtmlFormatado);

        string tagImagem = !string.IsNullOrEmpty(imageCid)
            ? $"<img src='cid:{imageCid}' alt='PFlow Logo' width='55' style='display: block; margin-left: auto; border-radius: 4px;' />"
            : "";

        htmlTemplate = htmlTemplate.Replace("{IMAGEM_LOGO}", tagImagem);


        // --- DEFINIÇÃO DOS CORPOS DO EMAIL ---
        builder.TextBody = conteudoTexto;
        builder.HtmlBody = htmlTemplate;


        // --- PROCESSAMENTO DE MÚLTIPLOS ANEXOS ---
        if (caminhosAnexos != null && caminhosAnexos.Count > 0)
        {
            foreach (var caminho in caminhosAnexos)
            {
                if (!string.IsNullOrEmpty(caminho) && File.Exists(caminho))
                {
                    builder.Attachments.Add(caminho);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n[AVISO] Arquivo ignorado (não encontrado): {caminho}");
                    Console.ResetColor();
                }
            }
        }


        // --- ASSOCIAÇÃO DO CORPO À MENSAGEM ---
        mensagem.Body = builder.ToMessageBody();


        // --- ENVIO DA MENSAGEM VIA SMTP ---
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
    } // Fim do método EnviarEmailAsync

}