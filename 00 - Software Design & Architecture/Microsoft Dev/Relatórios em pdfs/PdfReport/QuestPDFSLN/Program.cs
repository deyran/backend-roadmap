
using System;

namespace QuestPDFSLN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClassesPDF.HelloWorld helloWorld = new ClassesPDF.HelloWorld();
            //helloWorld.CreateDocument();
            
            //ClassesPDF.EstudoDirigido estudoDirigide = new ClassesPDF.EstudoDirigido();
            //estudoDirigide.gerarDocumento();

            ClassesPDF.GeraTabelaPDF geraTabelaPDF = new ClassesPDF.GeraTabelaPDF();
            geraTabelaPDF.GerarDocumento();

        }
    }
}