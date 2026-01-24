using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace QuestPDFSLN.ClassesPDF
{
    public class HeaderFooterImg
    {
        public void gerarDocumento()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var nomes = ObterDados();
            var documento = MontarLayout(nomes);
            
            string filePath = SalvarEObterCaminho(documento);
            AbrirDocumento(filePath);
        }


        // --- DADOS ---
        private string[] ObterDados()
        {
            return new[]
            {
                "Deyvid Rannyere de Moraes Costa",
                "Márcia Costa da Silva de Moraes",
                "Lara Hellena Costa de Moraes",
                "XXX XXX XXX XXX",
                "YYY YYY YYY YYY",
                "ZZZ ZZZ ZZZ ZZZ",
                "AAA AAA AAA AAA",
                "BBB BBB BBB BBB",
                "CCC CCC CCC CCC",
                "DDD DDD DDD DDD"
            };
        }


        // --- ESTRUTURA DO LAYOUT ---
        private IDocument MontarLayout(string[] nomes)
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
                    criarContent(page, nomes);
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
        private void criarContent(PageDescriptor page, string[] nomes)
        {
            page.Content().PaddingVertical(20).PaddingLeft(20).PaddingRight(20).Column(column =>
            {
                string TextBasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documentos", "contrato-estudo-dirigido.txt");
                string TextoBase = File.ReadAllText(TextBasePath, Encoding.UTF8);

                foreach (var nome in nomes)
                {
                    // Substitui o marcador pelo nome da iteração atual
                    string TextoContrato = TextoBase.Replace("_NOME_", nome);

                    column.Item().Column(itemColumn =>
                    {
                        itemColumn.Item()
                            .Text(TextoContrato)
                            .FontFamily("Courier New")
                            .FontSize(12)                            
                            .Justify();
                    });

                    if (nome != nomes.Last())
                    {
                        column.Item().PageBreak();
                    }
                }
                
            });

        }


        // --- FOOTER ---
        private void CriarFooter(PageDescriptor page)
        {
            page.Footer().AlignCenter().Text(x =>
            {
                x.Span("Página ");
                x.CurrentPageNumber();
                x.Span(" - ");
                x.TotalPages();
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