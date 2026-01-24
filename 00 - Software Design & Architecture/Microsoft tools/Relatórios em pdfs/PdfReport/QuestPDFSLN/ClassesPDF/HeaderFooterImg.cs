using System;
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

        private string TextoConteudo01 = @"CONTRATANTE: _NOME_, _CPF_ CONTRATADO: Espaço Cultural Intellectus Vita LTDA, CNPJ Nº 27.219.858/0001-06. OBJETO DO CONTRATO: Prestação de serviços educacionais sob o título ""Estudo Dirigido"".";

        private string TextoConteudo02 = @"CLÁUSULAS: Objeto do Contrato: O CONTRATANTE contrata o CONTRATADO para a prestação de serviços educacionais denominados ""Estudo Dirigido"", conforme especificado no presente contrato.";

        private string TextoConteudo03 = @"1. Valor: O valor total deste contrato é de R$ 100.00 por disciplina, devidamente pago pelo CONTRATANTE ao CONTRATADO.";

        private string TextoConteudo04 = @"2. Duração: O contrato tem duração de 2 meses, a partir da data estipulada pelo CONTRATADO.";

        private string TextoConteudo05 = @"3. Obrigações do CONTRATADO: O CONTRATADO se compromete a ministrar as aulas conforme o cronograma estipulado pelo CONTRATADO, com a qualidade esperada e dentro dos termos deste contrato.";

        private string TextoConteudo06 = @"4. Obrigações do CONTRATANTE: O CONTRATANTE se compromete a pagar o valor acordado e a cumprir com todas as obrigações estabelecidas neste contrato.";

        private string TextoConteudo07 = @"5. A disciplina(s) a ser ministrada pelo CONTRATADO: Ciências, Físicas e Biológicas (C.F.B), totalizando R$ 100.00.";

        private string Assinaturas = @"
        ───────────────────────────────────────
        CONTRATANTE





        ───────────────────────────────────────
        CONTRATADO";

        private string DataContrato = $"Belém, {DateTime.Now:dd} de {DateTime.Now.ToString("MMMM", new CultureInfo("pt-BR"))} de {DateTime.Now:yyyy}";

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
                Disciplinas = new List<string>{ "Ciências", "Físicas", "Biológicas" }
            },

            new Pessoa
            {
                Nome = "Lara Hellena Costa de Moraes",
                CPF = "BBB.BBB.BBB-BB",
                Disciplinas = new List<string>{ "Português", "Inglês", "Matemática" }
            },

            new Pessoa
            {
                Nome = "Márcia Costa Silva de Moraes",
                CPF = "CCC.CCC.CCC-CC",
                Disciplinas = new List<string>{ "Português", "Inglês", "Matemática" }
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
            page.Header().Column(col =>
            {
                if (File.Exists(caminhoLogo))
                    col.Item().AlignCenter().Width(80).Image(caminhoLogo);

                col.Item().PaddingTop(5);

                col.Item().AlignCenter().Text("CONTRATO ESTUDO DIRIGIDO")
                    .FontFamily("Courier New")
                    .FontSize(18)
                    .SemiBold();
            });
        }

        // --- CONTENT ---
        private void criarContent(PageDescriptor page)
        {
            page.Content().PaddingVertical(20).PaddingLeft(20).PaddingRight(20).Column(column =>
            {

                int contarPessoa = 0;

                foreach (var pessoa in ObterPessoas())
                {
                    var TextoContrato = TextoConteudo01
                                        .Replace("_NOME_", pessoa.Nome)
                                        .Replace("_CPF_", pessoa.CPF);

                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(15)
                            .Text(TextoContrato)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .Justify();
                    });

                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(15)
                            .Text(TextoConteudo02)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .Justify();
                    });

                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(10)
                            .PaddingLeft(20)
                            .Text(TextoConteudo03)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .Justify();
                    });


                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(10)
                            .PaddingLeft(20)
                            .Text(TextoConteudo04)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .Justify();
                    });

                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(10)
                            .PaddingLeft(20)
                            .Text(TextoConteudo05)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .Justify();
                    });

                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(10)
                            .PaddingLeft(20)
                            .Text(TextoConteudo06)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .Justify();
                    });


                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(10)
                            .PaddingLeft(20)
                            .Text(TextoConteudo07)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .Justify();
                    });


                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(35)
                            .Text(DataContrato)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .AlignRight();
                    });


                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .PaddingTop(45)
                            .Text(Assinaturas)
                            .FontFamily("Courier New")
                            .FontSize(12)
                            .AlignCenter();

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
                    .FontFamily("Courier New")
                    .FontSize(10);
            });
        }


        // --- INFRAESTRUTURA E LIMPEZA ---
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