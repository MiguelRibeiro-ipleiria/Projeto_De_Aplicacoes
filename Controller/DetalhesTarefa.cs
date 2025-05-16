using iTasks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Controller
{
    class DetalhesTarefa
    {
        public void AdicionarTarefa(string descricao,TipoTarefa tipotarefa,Gestor gestor,Programador programador, DateTime dataPrevistoInicio, DateTime dataPrevistoFim, int storyPoints,string ordem,DateTime DataRealInicio, DateTime DataRealFim, string Estadoatual)
        {
            using (var db = new OrganizacaoContext())
            {
                var tarefa = new Tarefa
                {
                    Descricao = descricao,
                    TipoTarefa = tipotarefa,
                    Gestor = gestor,
                    Programador = programador,
                    DataPrevistoInicio = dataPrevistoInicio,
                    DataPrevistoFim = dataPrevistoFim,
                    StoryPoints = storyPoints,
                    OrdemExecucao = ordem,
                    DataCriacao = DateTime.Now,
                    DataRealInicio = DataRealInicio,
                    DataRealFim = DataRealFim,
                    EstadoAtual = Estadoatual
                }; 
                db.Tarefas.Add(tarefa);

                db.SaveChanges();
            }
        }
    }
}
