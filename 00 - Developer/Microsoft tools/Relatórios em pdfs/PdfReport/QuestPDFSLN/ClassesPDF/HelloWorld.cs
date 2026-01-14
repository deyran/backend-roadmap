using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Diagnostics;
using System.IO;

namespace QuestPDFSLN.ClassesPDF
{
    public class HelloWorld
    {
        public void CreateDocument()
        {

            QuestPDF.Settings.License = LicenseType.Community;

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.DefaultTextStyle(x => x.FontSize(20));
                    page.Content()
                        .AlignCenter()
                        .AlignMiddle()
                        .Text("Hello, World!");
                });
            });

            // 1. Define um caminho temporário seguro
            string fileName = $"Relatorio_{Guid.NewGuid()}.pdf";
            string filePath = Path.Combine(Path.GetTempPath(), fileName);
            

            // 2. Gera o arquivo
            document.GeneratePdf(filePath);

            // 3. Comando para abrir o arquivo no leitor padrão (Windows)
            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true // Importante para abrir via shell do Windows
            });

        }
    }
}
