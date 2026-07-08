using System;
using System.IO;
using ClosedXML.Excel;

namespace PFlow.Services
{
    public class ServiceExcel
    {
        public void GerarMapaDeNotas()
        {
            // 1. Definição dos caminhos de diretório e arquivo
            string pastaDestino = @"C:\PFlow\Services\tmp";
            string caminhoArquivo = Path.Combine(pastaDestino, "MapaDeNotas.xlsx");

            // Garantir a existência da pasta antes da criação do arquivo
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            // 2. Inicialização do Workbook do ClosedXML
            using (var workbook = new XLWorkbook())
            {
                // Array com os nomes das abas solicitadas para processamento em lote
                string[] abas = { "TesteAba1", "TesteAba2" };

                foreach (var nomeAba in abas)
                {
                    var worksheet = workbook.Worksheets.Add(nomeAba);

                    // --- ESTRUTURAÇÃO DOS DADOS ---

                    // Linha 1: Professor
                    worksheet.Cell(1, 1).Value = "Professor";
                    worksheet.Cell(1, 1).Style.Font.SetBold(true); // Negrito
                    worksheet.Cell(1, 2).Value = "Rannyere Costa";

                    // Linha 2: Disciplina
                    worksheet.Cell(2, 1).Value = "Disciplina";
                    worksheet.Cell(2, 1).Style.Font.SetBold(true); // Negrito
                    worksheet.Cell(2, 2).Value = "Matemática";

                    // Linha 3: Turma
                    worksheet.Cell(3, 1).Value = "Turma";
                    worksheet.Cell(3, 1).Style.Font.SetBold(true); // Negrito
                    worksheet.Cell(3, 2).Value = "9º ano";

                    // Linha 4: Ano
                    worksheet.Cell(4, 1).Value = "Ano";
                    worksheet.Cell(4, 1).Style.Font.SetBold(true); // Negrito
                    worksheet.Cell(4, 2).Value = 2026;

                    // Ajuste automático de largura das colunas para evitar textos cortados
                    worksheet.Columns().AdjustToContents();
                }

                // 3. Salvar o arquivo final no caminho determinado
                workbook.SaveAs(caminhoArquivo);
            }
        }
    }
}