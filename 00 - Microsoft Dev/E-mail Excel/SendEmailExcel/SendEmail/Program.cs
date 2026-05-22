using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Title = "PFlow - Motor de Envios em Lote";
        Console.WriteLine("=== PFLOW GESTÃO ESCOLAR - DISPARO EM LOTE ===");

        // --- INSTANCIAÇÃO DO SERVIÇO ---
        var servicoEmail = new ServicoEmail();


        // --- SIMULAÇÃO DA BASE DE DADOS (LOTE DE ENVIO) ---
        // Criamos uma estrutura onde cada destinatário tem seus próprios dados e anexos
        var loteEnvio = new List<MockDestinatario>
        {
            new MockDestinatario
            {
                Email = "raniecosta80@gmail.com",
                Assunto = "PFlow - Boletim Escolar e Boleto de Mensalidade",
                Mensagem = "Olá,\n\nSeguem em anexo o boletim do primeiro bimestre e o boleto para pagamento da próxima mensalidade.\n\nQualquer dúvida, estamos à disposição.",
                Anexos = new List<string>
                {
                    @"C:\Users\PROGRAMACAO\Desktop\Secretaria teste\MOSTRA CULTURAL 2026.jpg",
                    @"C:\Users\PROGRAMACAO\Desktop\Secretaria teste\MARCOS HENRIQUE DE OLIVEIRA ZANOTTI ROSI.pdf"
                }
            },
            new MockDestinatario
            {
                Email = "deyran@gmail.com",
                Assunto = "PFlow - Comunicado Importante e Cronograma",
                Mensagem = "Prezados Responsáveis,\n\nFiquem atentos ao cronograma de eventos do mês de junho e à lista de materiais extras em anexo.",
                Anexos = new List<string>
                {
                    @"C:\Users\PROGRAMACAO\Desktop\Secretaria teste\MOSTRA CULTURAL 2026.jpg",
                    @"C:\Users\PROGRAMACAO\Desktop\Secretaria teste\MARCOS HENRIQUE DE OLIVEIRA ZANOTTI ROSI.pdf"
                }
            },
            new MockDestinatario
            {
                Email = "secretaria.intellectusvita@gmail.com",
                Assunto = "PFlow - Comunicado Importante e Cronograma",
                Mensagem = "Prezados Responsáveis,\n\nFiquem atentos ao cronograma de eventos do mês de junho e à lista de materiais extras em anexo.",
                Anexos = new List<string>
                {
                    @"C:\Users\PROGRAMACAO\Desktop\Secretaria teste\MOSTRA CULTURAL 2026.jpg",
                    @"C:\Users\PROGRAMACAO\Desktop\Secretaria teste\MARCOS HENRIQUE DE OLIVEIRA ZANOTTI ROSI.pdf"
                }
            }
        };


        // --- PROCESSAMENTO DA FILA / DISPARO ---
        Console.WriteLine($"\nIniciando o processamento de {loteEnvio.Count} e-mails...");
        int sucessos = 0;
        int falhas = 0;

        foreach (var item in loteEnvio)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n[ENVIANDO] Processando destino: {item.Email}...");
            Console.ResetColor();

            // Chamada ao método refatorado que aceita a lista de anexos
            bool enviadoComSucesso = await servicoEmail.EnviarEmailAsync(
                item.Email,
                item.Assunto,
                item.Mensagem,
                item.Anexos
            );

            if (enviadoComSucesso)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[SUCESSO] E-mail enviado para {item.Email}!");
                sucessos++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[FALHA] Não foi possível enviar para {item.Email}.");
                falhas++;
            }
            Console.ResetColor();
        }


        // --- RELATÓRIO FINAL DO LOTE ---
        Console.WriteLine("\n=============================================");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("RESUMO DO PROCESSAMENTO:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" - Enviados com sucesso: {sucessos}");
        Console.ForegroundColor = falhas > 0 ? ConsoleColor.Red : ConsoleColor.Gray;
        Console.WriteLine($" - Falhas detectadas: {falhas}");
        Console.ResetColor();
        Console.WriteLine("=============================================");

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}


// --- CLASSE AUXILIAR PARA O MOCK DE DADOS ---
// Estrutura simples para organizar os dados de teste do lote
public class MockDestinatario
{
    public string Email { get; set; }
    public string Assunto { get; set; }
    public string Mensagem { get; set; }
    public List<string> Anexos { get; set; }
}