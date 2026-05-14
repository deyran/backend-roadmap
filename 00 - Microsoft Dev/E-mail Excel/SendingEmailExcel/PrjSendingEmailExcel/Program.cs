
namespace PrjSendingEmailExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmailService emailService = new EmailService();
            emailService.SendEmail("raniecosta80@gmail.com", "Teste", "TesteBody");

        }
    }
}
