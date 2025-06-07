using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks.Controller
{
    class ConsultasDone
    {
        public List<Tarefa> ConsultaProgramadorTarefasDone(Utilizador utilizador)
        {
            List<Tarefa> listaestadotarefadone = new List<Tarefa>();
            using (var db = new OrganizacaoContext())
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
        }
    }
}
