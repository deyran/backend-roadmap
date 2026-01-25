using System;
using Humanizer;
using System.IO;
using System.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System.Diagnostics;
using QuestPDFSLN.Entities;
using System.Globalization;
using QuestPDF.Infrastructure;
using System.Collections.Generic;

namespace QuestPDFSLN.ClassesPDF
{
    public class HeaderFooterImg
    {
        decimal ValorContrato = 200.00m;

        private int _FontSize = 12;
        private string _FontFamily = "Courier New";
        private string Assinaturas = @"
        ───────────────────────────────────────
        CONTRATANTE





        ───────────────────────────────────────
        CONTRATADO";

        //private string DataContrato = ;

        public void gerarDocumento()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var documento = MontarLayout();

            string filePath = SalvarEObterCaminho(documento);
            AbrirDocumento(filePath);
        }

        // --- DADOS ---
        private List<Pessoa> ObterPessoas() => new List<Pessoa>
        {
            new Pessoa
            {
                Nome = "Deyvid Rannyere de Moraes Costa",
                CPF = "AAA.AAA.AAA-AA",
                Disciplinas = new List<string>
                { 
                    "Ciências, Físicas e Biológicas (C.F.B)", 
                    "Físicas", 
                    "História" 
                }
            },

            new Pessoa
            {
                Nome = "Lara Hellena Costa de Moraes",
                CPF = "BBB.BBB.BBB-BB",
                Disciplinas = new List<string>
                { 
                    "Língua Portuguesa", 
                    "Matemática" 
                }
            },

            new Pessoa
            {
                Nome = "Márcia Costa Silva de Moraes",
                CPF = "CCC.CCC.CCC-CC",
                Disciplinas = new List<string>
                { 
                    "Língua Portuguesa", 
                    "Inglês",
                    "História",
                    "Sociologia",
                    "Matemática" 
                }
            }
        };


        // --- ESTRUTURA DO LAYOUT ---
        private IDocument MontarLayout()
        {
            string caminhoLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Img", "IntellectusVitaLogo.png");

            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(4, Unit.Millimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    criarHeader(page, caminhoLogo);
                    criarContent(page);
                    CriarFooter(page);
                });
            });
        }

        // --- HEADER ---
        private void criarHeader(PageDescriptor page, string caminhoLogo)
        {
            page.Header().Column(column =>
            {
                if (File.Exists(caminhoLogo))
                    column.Item().AlignCenter().Width(80).Image(caminhoLogo);


                column.Item().PaddingTop(20).Text(text =>
                {
                    text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(_FontSize));

                    text.Span("CONTRATO ESTUDO DIRIGIDO")
                        .Bold()
                        .FontSize(15);

                    text.AlignCenter();
                });

            });
        }

        // --- CONTENT ---
        private void criarContent(PageDescriptor page)
        {
            page.Content().PaddingVertical(5).PaddingLeft(20).PaddingRight(20).Column(column =>
            {

                int contarPessoa = 0;

                foreach (var pessoa in ObterPessoas())
                {

                    column.Item().PaddingTop(15).Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(_FontSize));

                        text.Span("CONTRATANTE: ").Bold();
                        text.Span($"{pessoa.Nome}, {pessoa.CPF} ");

                        text.Span("CONTRATADO: ").Bold();
                        text.Span("Espaço Cultural Intellectus Vita LTDA, CNPJ Nº 27.219.858/0001-06. ");

                        text.Span("OBJETO DO CONTRATO: ").Bold();
                        text.Span("Prestação de serviços educacionais sob o título \"Estudo Dirigido\".");


                        text.Span("\n\nCLÁUSULAS: ").Bold();
                        text.Span("Objeto do Contrato: O CONTRATANTE contrata o CONTRATADO para a ");
                        text.Span(" prestação de serviços educacionais denominados \"Estudo Dirigido\", conforme especificado no presente contrato.");


                        text.Justify();
                    });


                    column.Item().PaddingTop(15).PaddingLeft(20).Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(_FontSize));

                        text.Span("1. ");
                        text.Span("Valor: ").Bold();
                        text.Span("O valor total deste contrato é de ");
                        text.Span("R$ " + ValorContrato.ToString("F2")).Bold();
                        text.Span(" (" + FormatarValorPorExtenso(ValorContrato) + ") ");
                        text.Span(" por disciplina, devidamente pago pelo CONTRATANTE ao CONTRATADO.");
                                                
                        text.Span("\n\n2. ");
                        text.Span("Duração: ").Bold();
                        text.Span("O contrato tem duração de 2 meses, a partir da data estipulada pelo CONTRATADO.");

                        text.Span("\n\n3. ");
                        text.Span("Obrigações do CONTRATADO: ").Bold();
                        text.Span("O CONTRATADO se compromete a ministrar as aulas conforme o cronograma "); 
                        text.Span(" estipulado pelo CONTRATADO, com a qualidade esperada e dentro dos termos deste contrato.");

                        text.Span("\n\n4. ");
                        text.Span("Obrigações do CONTRATANTE: ").Bold();
                        text.Span("O CONTRATANTE se compromete a pagar o valor acordado e a cumprir com ");
                        text.Span(" todas as obrigações estabelecidas neste contrato.");

                        text.Span("\n\n5. ");
                        text.Span("Disciplina(s): ").Bold();
                        text.Span("A(s) disciplina(s) a ser ministrada pelo CONTRATADO: ");
                        text.Span(string.Join(", ", pessoa.Disciplinas)).Bold();

                        decimal valorTotal = ValorContrato * pessoa.Disciplinas.Count();
                        text.Span(", totalizando ");
                        text.Span("R$ " + valorTotal.ToString("F2")).Bold();
                        text.Span(" (" + FormatarValorPorExtenso(valorTotal)  + ")");
                        text.Span(".");

                        text.Justify();
                    });


                    column.Item().PaddingTop(45).Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(_FontSize));

                        text.Span($"Belém, {DateTime.Now:dd} de {DateTime.Now.ToString("MMMM", new CultureInfo("pt-BR"))} de {DateTime.Now:yyyy}");

                        text.AlignRight();
                    });


                    column.Item().PaddingTop(55).Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(_FontSize));

                        text.Span(Assinaturas);

                        text.AlignCenter();
                    });


                    contarPessoa += 1;
                    if (contarPessoa < ObterPessoas().ToList().Count)
                    {
                        column.Item().PageBreak();
                    }
                }
            });

        }

        // --- FOOTER ---
        private void CriarFooter(PageDescriptor page)
        {
            page.Footer().AlignCenter().Text(footer =>
            {
                footer
                    .Span("Espaço Cultural Intellectus Vita LTDA Rua Anchieta, 335, Marambaia Belém – Pará – Brasil.")
                    .FontFamily(_FontFamily)
                    .FontSize(10);
            });
        }


        // --- INFRAESTRUTURA E LIMPEZA ---
        private string FormatarValorPorExtenso(decimal valor)
        {
            var cultura = new CultureInfo("pt-BR");

            // 1. Separa reais e centavos
            long reais = (long)Math.Truncate(valor);
            int centavos = (int)Math.Round((valor - reais) * 100);

            // 2. Converte para extenso usando cast para long/int (para evitar o erro de 'decimal')
            string textoReais = reais.ToWords(cultura);
            string resultado = $"{textoReais} {(reais == 1 ? "real" : "reais")}";

            if (centavos > 0)
            {
                string textoCentavos = centavos.ToWords(cultura);
                resultado += $" e {textoCentavos} {(centavos == 1 ? "centavo" : "centavos")}";
            }

            // 3. Torna a primeira letra maiúscula
            // Usando Humanizer:
            return resultado.Transform(To.SentenceCase);

            // OU usando C# Puro (caso não queira usar o .Transform):
            // return char.ToUpper(resultado[0]) + resultado.Substring(1);
        }

        private void LimparArquivosTemp()
        {
            string tempDir = Path.GetTempPath();
            string[] arquivosAntigos = Directory.GetFiles(tempDir, "Relatorio_*.pdf");

            foreach (string arquivo in arquivosAntigos)
            {
                try
                {
                    File.Delete(arquivo);
                }
                catch (IOException) { /* Arquivo em uso, ignora */ }
            }
        }

        private string SalvarEObterCaminho(IDocument documento)
        {
            LimparArquivosTemp();

            string fileName = $"Relatorio_{Guid.NewGuid()}.pdf";
            string filePath = Path.Combine(Path.GetTempPath(), fileName);
            documento.GeneratePdf(filePath);
            return filePath;
        }

        private void AbrirDocumento(string filePath)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }

    }
}