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



        public Tarefa(int id, int idgestor, int idprogramador, string ordemexecucao, string descricao, DateTime dataprevistoinicio, DateTime dataprevistofim, int idtipotarefa, int storypoints, DateTime datarealinicio, DateTime datarealfim, DateTime datacriacao, string estadoatual)
        {
            Id = id;
            IdGestor = idgestor;
            IdProgramador = idprogramador;
            OrdemExecucao = ordemexecucao;
            Descricao = descricao;
            DataPrevistoInicio = dataprevistoinicio;
            DataPrevistoFim = dataprevistofim;
            IdTipoTarefa = idtipotarefa;
            StoryPoints = storypoints;
            DataRealInicio = datarealinicio;
            DataRealFim = datarealfim;
            DataCriacao = datacriacao;
            EstadoAtual = estadoatual;
        }
    }
    public class TipoTarefa : Tarefa
    {
        public int IdTarefa { get; set; }
        public string Nome { get; set; }


        public TipoTarefa(int id, int idgestor, int idprogramador, string ordemexecucao, string descricao, DateTime dataprevistoinicio, DateTime dataprevistofim, int idtipotarefa, int storypoints, DateTime datarealinicio, DateTime datarealfim, DateTime datacriacao, string estadoatual, int idtipodatarefa, string nome) : base(id, idgestor, idprogramador, ordemexecucao, descricao, dataprevistoinicio, dataprevistofim, idtipotarefa, storypoints, datarealinicio, datarealfim, datacriacao, estadoatual)
        {
            IdTarefa = idtipodatarefa;
            Nome = nome;
        }
    }
    
}
