using Humanizer;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace QuestPDFSLN.ClassesPDF
{
    public class DocumentoMatriz
    {
        protected void GerarAbrirDocumento(IDocument documento)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Exclui arquivos temporários antigos
            DeleteFileTemp();

            // Gerar PDF em um arquivo temporário
            string fileName = $"QuestPDF_{Guid.NewGuid()}.pdf";
            string filePath = Path.Combine(Path.GetTempPath(), fileName);
            documento.GeneratePdf(filePath);

            // Abrir o PDF gerado
            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }

        private void DeleteFileTemp()
        {
            string tempDir = Path.GetTempPath();
            string[] arquivosAntigos = Directory.GetFiles(tempDir, "QuestPDF_*.pdf");

            foreach (string arquivo in arquivosAntigos)
            {
                try
                {
                    File.Delete(arquivo);
                }
                catch (IOException) { /* Arquivo em uso, ignora */ }
            }
        }

        protected string ValorPorExtenso(decimal valor)
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

    }
}