using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Diagnostics;
using System.IO;

namespace QuestPDFSLN.ClassesPDF
{
    public class GeraTabelaPDF
    {
        public void criarDocumento()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(4, Unit.Millimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));
                });
            });

            string filePath = SalvarEObterCaminho(document);
            AbrirDocumento(filePath);
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
