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
    }
}