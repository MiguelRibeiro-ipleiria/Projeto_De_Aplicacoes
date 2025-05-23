using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iTasks.Controller
{
    class KanbanController
    {
        public bool RestricoesUtilizador(Utilizador utilizador)
        {
            if(utilizador is Gestor gestor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tarefa> VerificarEstadoTodo()
        {
            List<Tarefa> listaestadotarefatodo = new List<Tarefa>();
            using (var db = new OrganizacaoContext())
            {
                var queryEstadoAtual = from tarefas in db.Tarefas
                                       where tarefas.EstadoAtual == EstadoAtual.ToDo
                                       select tarefas;
                queryEstadoAtual = queryEstadoAtual.Include(x => x.Programador);
                queryEstadoAtual = queryEstadoAtual.Include(x => x.Gestor);
                queryEstadoAtual = queryEstadoAtual.Include(x => x.TipoTarefa);

                foreach (var tarefaestadoautal in queryEstadoAtual)
                {
                    listaestadotarefatodo.Add(tarefaestadoautal);
                }

                return listaestadotarefatodo;
            }
        }

        public List<Tarefa> VerificarEstadoDoing()
        {
            List<Tarefa> listaestadotarefadoing = new List<Tarefa>();
            using (var db = new OrganizacaoContext())
            {
                var queryEstadoAtual = from tarefas in db.Tarefas
                                       where tarefas.EstadoAtual == EstadoAtual.Doing
                                       select tarefas;
                queryEstadoAtual = queryEstadoAtual.Include(x => x.Programador);
                queryEstadoAtual = queryEstadoAtual.Include(x => x.Gestor);
                queryEstadoAtual = queryEstadoAtual.Include(x => x.TipoTarefa);

                foreach (var tarefaestadoautal in queryEstadoAtual)
                {
                    listaestadotarefadoing.Add(tarefaestadoautal);
                }

                return listaestadotarefadoing;
            }

        }

        public List<Tarefa> VerificarEstadoDone()
        {
            List<Tarefa> listaestadotarefadone = new List<Tarefa>();
            using (var db = new OrganizacaoContext())
            {
                var queryEstadoAtual = from tarefas in db.Tarefas
                                       where tarefas.EstadoAtual == EstadoAtual.Done
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

        public void AlterarEstadoTarefaDoing(Tarefa tarefa, Utilizador utilizador)
        {
            using (var db = new OrganizacaoContext())
            {
                if(utilizador.Id == tarefa.Programador.Id)
                {
                    var queryEstadoParaAlterar = (from tarefas in db.Tarefas
                                                  where tarefas.Id == tarefa.Id
                                                  select tarefas).FirstOrDefault();

                    if (queryEstadoParaAlterar != null)
                    {
                        queryEstadoParaAlterar.EstadoAtual = EstadoAtual.Doing;
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Esta tarefa não lhe pertence!");
                }
            }
        }

        public void AlterarEstadoTarefaToDo(Tarefa tarefa, Utilizador utilizador)
        {
            using (var db = new OrganizacaoContext())
            {
                if (utilizador.Id == tarefa.Programador.Id)
                {
                    var queryEstadoParaAlterar = (from tarefas in db.Tarefas
                                                  where tarefas.Id == tarefa.Id
                                                  select tarefas).FirstOrDefault();

                    if (queryEstadoParaAlterar != null)
                    {
                        queryEstadoParaAlterar.EstadoAtual = EstadoAtual.ToDo;
                        db.SaveChanges();
                    }

                }
                else
                {
                    MessageBox.Show("Esta tarefa não lhe pertence!");
                }


            }
        }
    }
}
