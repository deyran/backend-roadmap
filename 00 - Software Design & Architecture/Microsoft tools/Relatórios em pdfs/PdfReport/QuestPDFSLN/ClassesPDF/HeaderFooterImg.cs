using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace QuestPDFSLN.ClassesPDF
{
    public class HeaderFooterImg
    {
        public void gerarDocumento()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Dados
            var nomes = new[]
            {
                "Deyvid Rannyere de Moraes Costa",
                "Márcia Costa da Silva de Moraes",
                "Lara Hellena Costa de Moraes"
            };

            string caminhoLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Img", "IntellectusVitaLogo.png");

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(4, Unit.Millimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    /*page.MarginTop(5, Unit.Point);
                    page.MarginLeft(1, Unit.Centimetre);
                    page.MarginRight(1, Unit.Centimetre);
                    page.MarginBottom(1, Unit.Centimetre);*/

                    // HEADER (Cabeçalho)
                    page.Header().Column(col =>
                    {
                        // 1. Imagem Centralizada
                        // O método 'AlignCenter' centraliza o item na linha
                        // O método 'Width' ou 'Height' controla o tamanho da imagem
                        col.Item().AlignCenter().Width(80).Image(caminhoLogo);

                        // 2. Espaçamento entre a imagem e o texto (opcional)
                        col.Item().PaddingTop(5);

                        // 3. Título Centralizado na linha de baixo
                        col.Item().AlignCenter().Text("Contrato de Aluguel")
                            .FontFamily("Courier New")
                            .FontSize(18)
                            .SemiBold();
                    });


                    // 2. CONTENT (Conteúdo - Uma página por nome)
                    page.Content().PaddingVertical(20).Column(column =>
                    {
                        foreach (var nome in nomes)
                        {
                            column.Item().Column(itemColumn =>
                            {
                                itemColumn.Item().Text($"Contratante: {nome}")
                                    .FontFamily("Courier New")
                                    .FontSize(12);
                            });

                            // Adiciona quebra de página, exceto após o último nome
                            if (nome != nomes.Last())
                            {
                                column.Item().PageBreak();
                            }
                        }
                    });


                    // 3. FOOTER (Rodapé)
                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.Span("Página ");
                        x.CurrentPageNumber();
                        x.Span(" - ");
                        x.TotalPages();
                    });

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