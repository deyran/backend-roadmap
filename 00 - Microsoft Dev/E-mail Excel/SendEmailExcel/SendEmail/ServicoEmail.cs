using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Microsoft.Extensions.Configuration;

public class ServicoEmail
{
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _emailAutenticado;
    private readonly string[] _scopes = new[] { "https://mail.google.com/" };

    // O construtor agora lê o arquivo JSON automaticamente, tirando o hardcode daqui!
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

    public async Task<bool> EnviarEmailAsync(string destinatario, string assunto, string conteudo)
    {
        UserCredential credential;

        try
        {
            // Criamos um caminho local seguro para armazenar o Token após o primeiro login
            string caminhoToken = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PFlowTokens");

            // O GoogleWebAuthorizationBroker agora usa o 'FileDataStore'. 
            // Ele vai checar essa pasta antes. Se o token existir, ele NÃO abre o navegador!
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

        // Montagem do E-mail (permanece igual)
        var mensagem = new MimeMessage();
        mensagem.From.Add(new MailboxAddress("PFlow Sistema", _emailAutenticado));
        mensagem.To.Add(new MailboxAddress("", destinatario));
        mensagem.Subject = assunto;
        mensagem.Body = new TextPart("plain") { Text = conteudo };

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