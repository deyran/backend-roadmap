
using System;

namespace QuestPDFSLN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ClassesPDF.HelloWorld helloWorld = new ClassesPDF.HelloWorld();
            helloWorld.CreateDocument();*/
            
            ClassesPDF.HeaderFooterImg headerFooterImg = new ClassesPDF.HeaderFooterImg();
            headerFooterImg.gerarDocumento();

        }
    }
}