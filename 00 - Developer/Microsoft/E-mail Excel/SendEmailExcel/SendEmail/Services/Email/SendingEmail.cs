using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SendEmail.Services.Email
{
    public class SendingEmail
    {
        public async Task ExecutarDisparoEmLoteAsync()
        {
            Console.Title = "PFlow - Motor de Envios em Lote";
            Console.WriteLine("=== PFLOW GESTÃO ESCOLAR - DISPARO EM LOTE ===");

            // --- CORREÇÃO DA INSTÂNCIA: Tudo alinhado com a sua classe ServiceEmail ---
            var serviceEmail = new ServiceEmail();

            // --- BASE DE DADOS (LOTE DE ENVIO) ---
            var loteEnvio = new List<Destinatario>
        {
            new Destinatario
            {
                Email = "deyran@gmail.com",
                Assunto = "PFlow - Boletim Escolar e Boleto de Mensalidade",
                Mensagem = "Olá,\n\nSeguem em anexo o boletim do primeiro bimestre e o boleto para pagamento da próxima mensalidade.\n\nQualquer dúvida, estamos à disposição.",
                Anexos = new List<string>
                {
                    @"C:\PFlow\IV_logotipo.PNG",
                    @"C:\PFlow\Logo.JPG"
                }
            }
        };

            // --- PROCESSAMENTO DA FILA / DISPARO ---
            Console.WriteLine($"\nIniciando o processamento de {loteEnvio.Count} e-mails...");
            int successes = 0;
            int failures = 0;

            foreach (var item in loteEnvio)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n[ENVIANDO] Processando destino: {item.Email}...");
                Console.ResetColor();

                string caminhoTemplate = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Services", "Email", "template-padrao.html");
                string corpoHtml = "";

                if (File.Exists(caminhoTemplate))
                {
                    corpoHtml = File.ReadAllText(caminhoTemplate);

                    // Substituição exata usando a tag {CONTEUDO} que está no seu HTML
                    corpoHtml = corpoHtml.Replace("{CONTEUDO}", item.Mensagem.Replace("\n", "<br/>"));
                }
                else
                {
                    corpoHtml = item.Mensagem;
                }

                // --- CORREÇÃO DA CHAMADA: Utilizando a variável correta serviceEmail ---
                bool enviadoComSucesso = await serviceEmail.EnviarEmailAsync(
                    item.Email,
                    item.Assunto,
                    corpoHtml,
                    item.Anexos
                );

                if (enviadoComSucesso)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"[SUCESSO] E-mail enviado para {item.Email}!");
                    successes++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[FALHA] Não foi possível enviar para {item.Email}.");
                    failures++;
                }
                Console.ResetColor();
            }

            // --- RELATÓRIO FINAL DO LOTE ---
            Console.WriteLine("\n=============================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("RESUMO DO PROCESSAMENTO:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" - Enviados com sucesso: {successes}");
            Console.ForegroundColor = failures > 0 ? ConsoleColor.Red : ConsoleColor.Gray;
            Console.WriteLine($" - Falhas detectadas: {failures}");
            Console.ResetColor();
            Console.WriteLine("=============================================");

            //Console.WriteLine("\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}