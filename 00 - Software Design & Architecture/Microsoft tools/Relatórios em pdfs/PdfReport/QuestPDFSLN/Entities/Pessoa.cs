using System.Collections.Generic;

namespace QuestPDFSLN.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
                
        private List<string> Disciplinas = new List<string>();


        public List<string> Disciplina(string disciplina)
        {
            if (!string.IsNullOrWhiteSpace(disciplina))
            {
                Disciplinas.Add(disciplina);
            }

            return Disciplinas;
        }
    }
}
