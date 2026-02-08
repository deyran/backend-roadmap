using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDFSLN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using static QuestPDF.Helpers.Colors;

namespace QuestPDFSLN.ClassesPDF
{
    public class BoletimEscolar : DocumentoMatriz
    {        
        private string _FontFamily = "Times New Roman";
        private string _NomeAluno = "Deyvid Rannyere de Moraes Costa";
        private string _Turma = "9º Ano";
        private string _Turno = "Manhã";
        private string _Emissao = DateTime.Now.ToString("dd/MM/yyyy");
        private string _Assinatura = @"
        ─────────────────────────────────
        Rosemary Monte da Cunha Kersting
        Diretora Pedagógica";


        public List<Boletim> ObterListaBoletim()
        {
            var disciplinas = new List<string>
            {
                "Língua Portuguesa", "Redação", "Literatura", "Ciências",
                "Matemática", "Ed. Financeira", "História", "Est. Amazônico",
                "Geografia", "Arte", "Inglês", "Ed. Física",
                "Empreendedorismo", "Ens. Religioso"
            };

            // Mapeia cada string para um novo objeto Boletim
            return disciplinas.Select(nome => new Boletim
            {
                Disciplina = nome,
                Av1 = 10.0m,
                Av2 = 10.0m,
                Av3 = 10.0m,
                Av4 = 10.0m,
                Rec1 = 10.0m,
                Rec2 = 10.0m,
                Media = 10.0m
            }).ToList();
        }

        public void GerarDocumento()
        {
            var documento = CriarBoletim();
            GerarAbrirDocumento(documento, "BoletimEscolar");
        }

        private IDocument CriarBoletim()
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Millimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    SetHeader(page);
                    SetContent(page);
                    SetFooter(page);
                });
            });

        }

        private void SetHeader(PageDescriptor page)
        {
            page.Header().Column(column =>
            {
                column.Item().AlignCenter().Width(60).Image(GetIntellectusLogo);

                column.Item().PaddingTop(2).Text(text =>
                {
                    text.Span("Escola e Espaço Cultural Intellectus Vita")
                        .FontFamily(_FontFamily)
                        .FontSize(14);

                    text.AlignCenter();
                });

                column.Item().PaddingTop(2).Text(text =>
                {
                    text.Span("Boletim Escolar 2025")
                        .FontFamily(_FontFamily)
                        .Bold()
                        .FontSize(14);

                    text.AlignCenter();
                });

                column.Item().PaddingTop(2).Text(text =>
                {
                    text.Span(_Emissao)
                        .FontFamily(_FontFamily)
                        .FontSize(9);

                    text.AlignCenter();
                });
            });
        }

        private void SetContent(PageDescriptor page)
        {
            page.Content().PaddingTop(50).PaddingHorizontal(15).Column(column =>
            {
                // --- PRIMEIRA TABELA (DADOS DO ALUNO) ---
                column.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(350);
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                    });

                    table.Cell().Border(0).Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(12));
                        text.Span("Nome: ").Bold();
                        text.Span($"{_NomeAluno}");
                    });

                    table.Cell().Border(0).Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(12));
                        text.Span("Turma: ").Bold();
                        text.Span($"{_Turma}");
                    });

                    table.Cell().Border(0).AlignRight().Text(text =>
                    {
                        text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(12));
                        text.Span("Turno: ").Bold();
                        text.Span($"{_Turno}");
                    });
                });
                // --- FIM PRIMEIRA TABELA ---


                // --- ESPAÇAMENTO ENTRE AS TABELAS ---
                column.Item().PaddingTop(20);


                // --- SEGUNDA TABELA (9 COLUNAS E 2 LINHAS) ---
                column.Item().Table(table =>
                {
                    // Define 9 colunas iguais
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(200);

                        for (int i = 0; i < 8; i++)
                            columns.RelativeColumn(1);
                    });

                    // Linha 1: Cabeçalho ou Títulos
                    var titulos = new[] { "Disciplinas", "1º Av", "2º Av", "Rec", "3º Av", "4º Av", "Rec", "Freq", "Média" };
                    foreach (var titulo in titulos)
                    {
                        table.Cell()
                            .BorderColor(Colors.Black) // Define a cor preta
                            .PaddingVertical(2) // Espaçamento para o texto não colar na linha
                            .Text(titulo)
                            .FontSize(13)
                            .FontFamily(_FontFamily);
                    }

                    var listaBoletim = ObterListaBoletim();
                    int countAux = 0; // Contador para alternar as cores

                    foreach (var item in listaBoletim)
                    {
                        var corFundo = countAux % 2 == 0 ? Colors.Grey.Lighten2 : Colors.White;

                        table.Cell().Background(corFundo).Text("\t" + item.Disciplina);
                        table.Cell().Background(corFundo).Text(item.Av1.ToString("F1"));
                        table.Cell().Background(corFundo).Text(item.Av2.ToString("F1"));
                        table.Cell().Background(corFundo).Text(item.Rec1.ToString("F1"));
                        table.Cell().Background(corFundo).Text(item.Av3.ToString("F1"));
                        table.Cell().Background(corFundo).Text(item.Av4.ToString("F1"));
                        table.Cell().Background(corFundo).Text(item.Rec2.ToString("F1"));
                        table.Cell().Background(corFundo).Text("10,0"); // Freq
                        table.Cell().Background(corFundo).Text("10,0"); // MEd

                        countAux++;
                    }

                });
                // --- FIM SEGUNDA TABELA ---


                column.Item().PaddingTop(15).Text(text =>
                {
                    text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(12));
                    text.Span("Situação: ").Bold();
                    text.Span("Aprovado");
                });



                column.Item().PaddingTop(160).AlignCenter().Text(text =>
                {
                    text.DefaultTextStyle(x => x.FontFamily(_FontFamily).FontSize(12));
                    text.Span(_Assinatura);
                });

            });
        }

        private void SetFooter(PageDescriptor page)
        {
            page.Footer().AlignCenter().Text(footer =>
            {
                footer
                    .Span("Espaço Cultural Intellectus Vita LTDA Rua Anchieta, 335, Marambaia Belém – Pará – Brasil.")
                    .FontFamily(_FontFamily)
                    .FontSize(10);
            });
        }

    }
}
