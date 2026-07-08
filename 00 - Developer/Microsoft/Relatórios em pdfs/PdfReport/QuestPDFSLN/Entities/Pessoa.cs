using System.Collections.Generic;

namespace QuestPDFSLN.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
                
        public List<string> Disciplinas = new List<string>();
       
    }
}
