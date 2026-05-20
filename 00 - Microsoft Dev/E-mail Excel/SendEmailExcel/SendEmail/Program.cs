using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== PFlow - Sistema de Disparo de E-mails ===");

        // Agora basta dar 'new' sem passar nada no construtor!
        var servicoEmail = new ServicoEmail();

        // Coleta dos dados dinamicamente via Console
        Console.Write("\nDigite o e-mail do destinatário: ");
        string destinatario = Console.ReadLine();

        Console.Write("Digite o assunto do e-mail: ");
        string assunto = Console.ReadLine();

        Console.Write("Digite o conteúdo da mensagem: ");
        string conteudo = Console.ReadLine();

        Console.WriteLine("\nProcessando envio, aguarde...");

        // Chama o método enviando os parâmetros da tela
        bool sucesso = await servicoEmail.EnviarEmailAsync(destinatario, assunto, conteudo);

        if (sucesso)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[SUCESSO] O e-mail foi enviado dinamicamente!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[FALHA] Não foi possível enviar o e-mail.");
            Console.ResetColor();
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}