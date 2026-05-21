using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Utils;
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
        // Lê as configurações de segurança do appsettings.json (Longe do GitHub!)
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        _clientId = config["GoogleOAuth:ClientId"];
        _clientSecret = config["GoogleOAuth:ClientSecret"];
        _emailAutenticado = config["GoogleOAuth:EmailAutenticado"];
    }

    // O parâmetro 'caminhoAnexo' foi adicionado como opcional (null por padrão) para o Item 2
    public async Task<bool> EnviarEmailAsync(string destinatario, string assunto, string conteudoTexto, string caminhoAnexo = null)
    {
        UserCredential credential;

        try
        {
            // Gerencia o Token de acesso silencioso na pasta local do usuário
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

        // --- MONTAGEM DA MENSAGEM ---
        var mensagem = new MimeMessage();
        mensagem.From.Add(new MailboxAddress("PFlow Sistema", _emailAutenticado));
        mensagem.To.Add(new MailboxAddress("", destinatario));
        mensagem.Subject = assunto;

        var builder = new BodyBuilder();

        // 1. Vincula a Logomarca local do PFlow de forma inline (embutida)
        string caminhoLogo = Path.Combine(AppContext.BaseDirectory, "appicon.png");
        string imageCid = "";

        if (File.Exists(caminhoLogo))
        {
            var imagem = builder.LinkedResources.Add(caminhoLogo);
            imagem.ContentId = MimeUtils.GenerateMessageId();
            imageCid = imagem.ContentId;
        }

        // 2. Carrega a moldura HTML do arquivo externo limpo que você solicitou
        // Altere para este formato indicando a pasta "Email"
        string caminhoTemplate = Path.Combine(AppContext.BaseDirectory, "Email", "template-padrao.html");
        string htmlTemplate = "";

        if (File.Exists(caminhoTemplate))
        {
            htmlTemplate = File.ReadAllText(caminhoTemplate);
        }
        else
        {
            // Fallback caso o arquivo não seja copiado para a pasta bin
            htmlTemplate = "<div style=\"text-align: justify;\">{CONTEUDO}</div>";
        }

        // Converte as quebras de linha digitadas no console (\n) em quebras de linha HTML (<br/>)
        string conteudoHtmlFormatado = conteudoTexto.Replace("\n", "<br/>");

        // 3. Aplica o conteúdo dinâmico e a tag da imagem dentro do HTML lido
        htmlTemplate = htmlTemplate.Replace("{CONTEUDO}", conteudoHtmlFormatado);

        string tagImagem = !string.IsNullOrEmpty(imageCid)
            ? $"<img src='cid:{imageCid}' alt='PFlow Logo' width='55' style='display: block; margin-left: auto; border-radius: 4px;' />"
            : "";

        htmlTemplate = htmlTemplate.Replace("{IMAGEM_LOGO}", tagImagem);

        // Define os corpos da mensagem (HTML e Texto Puro para compatibilidade)
        builder.HtmlBody = htmlTemplate;
        builder.TextBody = conteudoTexto;

        // --- ITEM 2: CRIAÇÃO DA LÓGICA DE ANEXOS ---
        // Se o usuário informar um caminho de arquivo válido, nós o anexamos à mensagem
        if (!string.IsNullOrEmpty(caminhoAnexo))
        {
            if (File.Exists(caminhoAnexo))
            {
                builder.Attachments.Add(caminhoAnexo);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n[AVISO] Arquivo de anexo não encontrado em: {caminhoAnexo}. O e-mail será enviado sem anexo.");
                Console.ResetColor();
            }
        }

        mensagem.Body = builder.ToMessageBody();

        // --- ENVIO VIA SMTP PROTOCOLO GMAIL OAUTH2 ---
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