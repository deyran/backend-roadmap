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
        string destinatario = "deyran@gmail.com";
        string assunto = "Assunto teste";
        string conteudo = @"
The Beatles foi uma banda de rock britânica formada na cidade de Liverpool em 1960. A formação mais conhecida da banda contava com John Lennon, Paul McCartney, George Harrison e Ringo Starr. Amplamente reconhecida como a maior e mais influente banda da história da música popular, foi essencial para o desenvolvimento da contracultura da década de 1960 e para o reconhecimento da música popular como forma de arte. Enraizados no skiffle, beat e o rock and roll dos anos 1950, os Beatles mais tarde experimentaram com diversos gêneros, desde baladas pop e a música indiana até a música psicodélica e o hard rock, e incorporaram elementos clássicos de maneiras inovadoras. Em meados da década de 1960, a imensa popularidade da banda tornou-se conhecida como ""Beatlemania"", mas conforme a música do grupo crescia em sofisticação, liderada pelos principais compositores Lennon e McCartney, seus membros começaram a ser percebidos como uma incorporação dos ideais compartilhados pelas revoluções socioculturais da era.
        ";

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