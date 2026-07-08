using SendEmail.Services;
using SendEmail.Services.Email;
using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var processador = new SendingEmail();

        // Criando o contexto assíncrono seguro a partir de um método síncrono
        Task.Run(async () =>
        {
            await processador.ExecutarDisparoEmLoteAsync();
        }).Wait();


        /*Console.WriteLine("==================================================");
        Console.WriteLine("   PFLOW GESTÃO ESCOLAR - TESTE DE PLANILHA       ");
        Console.WriteLine("==================================================");
        Console.WriteLine();

        try
        {
            // 1. Instancia o serviço que criamos anteriormente
            ServiceExcel service = new ServiceExcel();

            Console.WriteLine("Processando dados e criando as abas...");
            Console.WriteLine("Tentando gravar em: C:\\PFlow\\Services\\tmp\\MapaDeNotas.xlsx");

            // 2. Executa a geração do arquivo
            service.GerarMapaDeNotas();

            Console.WriteLine();
            Console.WriteLine("[SUCESSO] Planilha 'MapaDeNotas.xlsx' gerada perfeitamente!");
            Console.WriteLine("Abra a pasta para conferir as abas 'TesteAba1' e 'TesteAba2'.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine();
            Console.WriteLine("[ERRO DE PERMISSÃO] O Windows impediu a criação da pasta ou do arquivo no C:\\.");
            Console.WriteLine("Execute o Visual Studio 2026 como Administrador ou mude o caminho no ServiceExcel.");
        }
        catch (Exception ex)
        {
            Console.WriteLine();
            Console.WriteLine($"[ERRO INESPERADO] Falha ao gerar a planilha: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("==================================================");
        Console.WriteLine("Pressione qualquer tecla para encerrar o teste...");
        Console.ReadKey();*/


    }
}