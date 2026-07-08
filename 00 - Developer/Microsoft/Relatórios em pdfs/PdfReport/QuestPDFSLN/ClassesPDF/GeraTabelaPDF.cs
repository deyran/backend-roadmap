using System;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace QuestPDFSLN.ClassesPDF
{
    public class GeraTabelaPDF : DocumentoMatriz
    {
        public void GerarDocumento()
        {
            var documento = CritarTabela();
            GerarAbrirDocumento(documento, "GeraTabelaPdf");

        }

        private IDocument CritarTabela()
        {
            return Document.Create(container =>
            {

                container.Page(page =>
                {
                    page.Content().Table(table =>
                    {
                        // Definição das colunas
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(); // Coluna 1
                            columns.RelativeColumn(); // Coluna 2
                            columns.RelativeColumn(); // Coluna 3
                        });


                        /*table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(100);  // Coluna 1: Tamanho fixo de 50pt
                            columns.RelativeColumn(1);   // Coluna 2: Espaço proporcional
                            columns.RelativeColumn(2);   // Coluna 3: O dobro da largura da Coluna 2
                                                         // columns.AutoColumn();     // Opcional: Ajusta ao texto
                        });*/




                        // --- CÉLULA 1: IMAGEM REDUZIDA + ALINHAMENTO ESQUERDA ---
                        table.Cell().Border(1).Padding(5).AlignLeft().Column(col =>
                         {
                             // Imagem com largura fixa de 40 pontos
                             col.Item().Width(40).Image(GetIntellectusLogo);

                             col.Item().Text(t =>
                             {
                                 t.Span("ID: ").Bold();
                                 t.Span("001").FontColor(Colors.Blue.Medium);
                             });
                         });

                        // --- CÉLULA 2: TEXTO FORMATADO + CENTRALIZADO ---
                        /* table.Cell().Border(1).Padding(5).AlignCenter().AlignMiddle().Text(t =>
                         {
                             t.Span("STATUS: ").FontSize(10);
                             t.Span("PROCESSANDO").Bold().BackgroundColor(Colors.Yellow.Lighten4).FontColor(Colors.Orange.Medium);
                         });


                         // --- CÉLULA 3: TEXTO FORMATADO + ALINHAMENTO DIREITA ---
                         table.Cell().Border(1).Padding(5).AlignRight().AlignMiddle().Text(t =>
                         {
                             t.Span("Valor Total\n").FontSize(9).Italic();
                             t.Span("R$ 1.250,00").FontSize(14).Bold().FontColor(Colors.Green.Medium);
                         });*/



                       /* for (int i = 1; i <= 10; i++)
                        {
                            var backgroundColor = i % 2 == 0 ? Colors.White : Colors.Grey.Lighten2;

                            // A ordem importa: primeiro o Background, depois o Padding/Border
                            table.Cell().Background(backgroundColor).Text($"Texto {i},1");
                            table.Cell().Background(backgroundColor).Text($"Texto {i},2");
                            table.Cell().Background(backgroundColor).Text($"Texto {i},3");
                        }*/



                        
                        /*// --- PRIMEIRA CÉLULA (Texto ou qualquer conteúdo) ---
                        table.Cell().Border(1).Padding(10).AlignMiddle().Text("Primeira célula");

                        // --- SEGUNDA CÉLULA (A Imagem) ---                        
                        table.Cell().Border(1).Padding(10).Image(GetIntellectusLogo);

                        // --- TERCEIRA CÉLULA (Texto ou qualquer conteúdo) ---
                        table.Cell().Border(1).Padding(10).AlignMiddle().Text("Terceira");*/
                        
                    });
                });

            });
        }
    }
}
