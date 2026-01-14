using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

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
            document.GeneratePdf("HelloWorld.pdf");
        }

    }
}
