using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int IdGestor { get; set; }
        public int IdProgramador { get; set; }
        public string OrdemExecucao { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPrevistoInicio { get; set; }
        public DateTime DataPrevistoFim { get; set; }
        public int IdTipoTarefa { get; set; }
        public int StoryPoints { get; set; }
        public DateTime DataRealInicio { get; set; }
        public DateTime DataRealFim { get; set; }
        public DateTime DataCriacao { get; set; }
        public string EstadoAtual { get; set; }


    }
    public class TipoTarefa : Tarefa
    {
        public int IdTarefa { get; set; }
        public string Nome { get; set; }



    }
    
}
