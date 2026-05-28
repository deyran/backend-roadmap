using System.Collections.Generic;

namespace SendEmail.Services.Email
{
    public class Destinatario
    {
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public List<string> Anexos { get; set; }
    }
}
