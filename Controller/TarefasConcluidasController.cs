using iTasks.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Controller
{
    class TarefasConcluidasController
    {
        public class AtributosSelecionadosDasTarefasConcluidasProgramador
        {
            public string Nome_Do_Programador { get; set; }
            public string Responsavel { get; set; }
            public EstadoAtual Estado { get; set; }
            public string Descricao { get; set; }
            public TipoTarefa Tipo_Da_Tarefa { get; set; }
            public int Story_Points { get; set; }
            public string Tempo_Em_Dias { get; set; }
        }
        public class AtributosSelecionadosDasTarefasConcluidasGestor
        {
            public string Nome_Do_Programador { get; set; }
            public string Responsavel { get; set; }
            public EstadoAtual Estado { get; set; }
            public string Descricao { get; set; }
            public TipoTarefa Tipo_Da_Tarefa { get; set; }
            public int Story_Points { get; set; }
            public string Tempo_Em_Dias { get; set; }
            public string Tempo_Previsto_Em_Dias { get; set; }

        }


        public List<Tarefa> ConsularUtilizadorTarefasDone(bool isGestor, Utilizador utilizador)
        {
            List<Tarefa> listaestadotarefadone = new List<Tarefa>();
            using (var db = new OrganizacaoContext())
            {
                if(isGestor == false)
                {
                    var queryEstadoAtual = from tarefas in db.Tarefas
                                           where tarefas.EstadoAtual == EstadoAtual.Done && tarefas.Programador.Id == utilizador.Id
                                           select tarefas;
                    queryEstadoAtual = queryEstadoAtual.Include(x => x.Programador);
                    queryEstadoAtual = queryEstadoAtual.Include(x => x.Gestor);
                    queryEstadoAtual = queryEstadoAtual.Include(x => x.TipoTarefa);

                    foreach (var tarefaestadoautal in queryEstadoAtual)
                    {
                        listaestadotarefadone.Add(tarefaestadoautal);
                    }

                    return listaestadotarefadone;
                }
                else
                {
                    var queryEstadoAtual = from tarefas in db.Tarefas
                                           where tarefas.EstadoAtual == EstadoAtual.Done && tarefas.Gestor.Id == utilizador.Id
                                           select tarefas;
                    queryEstadoAtual = queryEstadoAtual.Include(x => x.Programador);
                    queryEstadoAtual = queryEstadoAtual.Include(x => x.Gestor);
                    queryEstadoAtual = queryEstadoAtual.Include(x => x.TipoTarefa);

                    foreach (var tarefaestadoautal in queryEstadoAtual)
                    {
                        listaestadotarefadone.Add(tarefaestadoautal);
                    }

                    return listaestadotarefadone;
                }

            }
        }
    }
}
