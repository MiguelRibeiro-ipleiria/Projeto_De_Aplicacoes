using iTasks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks
{

    public enum EstadoAtual
    {
        ToDo,
        Doing,
        Done
    }
    public class Tarefa
    {
        public int Id { get; set; }
        public Gestor Gestor { get; set; }
        public Programador Programador { get; set; }
        public int OrdemExecucao { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataPrevistoInicio { get; set; }
        public DateTime? DataPrevistoFim { get; set; }
        public TipoTarefa TipoTarefa { get; set; }
        public int StoryPoints { get; set; }
        public DateTime? DataRealInicio { get; set; }
        public DateTime? DataRealFim { get; set; }
        public DateTime? DataCriacao { get; set; }
        public EstadoAtual EstadoAtual { get; set; }


        public override string ToString()
        {
            return $"{Descricao} - {Programador.Nome} - Ordem: {OrdemExecucao}";
        }
    }
    
}
