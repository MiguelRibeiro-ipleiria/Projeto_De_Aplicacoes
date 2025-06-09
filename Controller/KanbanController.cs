using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void AlterarEstadoTarefaDoing(Tarefa tarefa, Utilizador utilizador, DateTime Datarealinicio)
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
                        queryEstadoParaAlterar.DataRealInicio = Datarealinicio;
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
                        queryEstadoParaAlterar.DataRealInicio = null;
                        db.SaveChanges();
                    }

                }
                else
                {
                    MessageBox.Show("Esta tarefa não lhe pertence!");
                }


            }
        }

        public void AlterarEstadoTarefaDone(Tarefa tarefa, Utilizador utilizador, DateTime DataDeRealFim)
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
                        queryEstadoParaAlterar.EstadoAtual = EstadoAtual.Done;
                        queryEstadoParaAlterar.DataRealFim = DataDeRealFim;

                        db.SaveChanges();
                    }

                }
                else
                {
                    MessageBox.Show("Esta tarefa não lhe pertence!");
                }


            }
        }

        public bool VerificarSeGereUtilizador(Utilizador utiizador)
        {
            using (var db = new OrganizacaoContext())
            {
                if(utiizador is Gestor gestor)
                {
                    if(gestor.GereUtilizadores == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("O utilizador não é um gestor.");
                    return false;
                }
            }
        }

        public void QuantasListas(Tarefa tarefa, Utilizador utilizador, DateTime DataDeRealFim)
        {
            try
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
                            queryEstadoParaAlterar.EstadoAtual = EstadoAtual.Done;
                            queryEstadoParaAlterar.DataRealFim = DataDeRealFim;

                            db.SaveChanges();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Esta tarefa não lhe pertence!");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }
        }

        public Tarefa TarefaMenorOrdemDoUtilizadorNoTODO(Utilizador utilizador, Tarefa tarefaselecionada)
        {
            try
            {
                using (var db = new OrganizacaoContext())
                {
                    if (utilizador.Id == tarefaselecionada.Programador.Id)
                    {
                        var tarefaComMenorOrdem = (from tarefas in db.Tarefas
                                                   where tarefas.Programador.Id == utilizador.Id
                                                         && tarefas.EstadoAtual == EstadoAtual.ToDo
                                                   orderby tarefas.OrdemExecucao
                                                   select tarefas).FirstOrDefault();

                        return tarefaComMenorOrdem;
                    }
                    else
                    {
                        MessageBox.Show("Não é o responsável pela Tarefa");
                        return null;
                    }


                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione uma tarefa");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
                return null;
            }
        }

        public Tarefa TarefaMenorOrdemDoUtilizadorNODOING(Utilizador utilizador, Tarefa tarefaselecionada)
        {
            try
            {
                using (var db = new OrganizacaoContext())
                {
                    if (utilizador.Id == tarefaselecionada.Programador.Id)
                    {
                        var tarefaComMenorOrdem = (from tarefas in db.Tarefas
                                                   where tarefas.Programador.Id == utilizador.Id
                                                         && tarefas.EstadoAtual == EstadoAtual.Doing
                                                   orderby tarefas.OrdemExecucao
                                                   select tarefas).FirstOrDefault();

                        return tarefaComMenorOrdem;
                    }
                    else
                    {
                        MessageBox.Show("Não é o responsável pela Tarefa");
                        return null;
                    }


                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione uma tarefa");
                return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma tarefa");
                return null;
            }

        }

        public Tarefa TarefaMaiorOrdemDoUtilizadorNoDOING(Utilizador utilizador, Tarefa tarefaselecionada)
        {
            try
            {
                using (var db = new OrganizacaoContext())
                {
                    if (utilizador.Id == tarefaselecionada.Programador.Id)
                    {
                        var tarefaComMaiorOrdem = (from tarefas in db.Tarefas
                                                   where tarefas.Programador.Id == utilizador.Id
                                                         && tarefas.EstadoAtual == EstadoAtual.Doing
                                                   orderby tarefas.OrdemExecucao descending
                                                   select tarefas).FirstOrDefault();

                        return tarefaComMaiorOrdem;
                    }
                    else
                    {
                        MessageBox.Show("Não é o responsável pela Tarefa");
                        return null;
                    }


                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Selecione uma tarefa");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
                return null;
            }
        }

        public Dictionary<string, double> TarefasCalculo(List<Tarefa> tarefasDone, List<Tarefa> tarefasTODO, string opcao)
        {
            using (var db = new OrganizacaoContext())
            {
                double MediaTempo = 0.0;
                Dictionary<string, double> SP_Horas = new Dictionary<string, double>();

                var TarefasTODOAgrupadas = (from t in tarefasTODO
                                       select t.StoryPoints).Distinct();

                var TarefasAgrupadas = from tarefa in tarefasDone
                                       where TarefasTODOAgrupadas.Contains(tarefa.StoryPoints)
                                       group tarefa by tarefa.StoryPoints into grupo
                                       select grupo;


                foreach (var TarefasGrupo in TarefasAgrupadas)
                {
                    double totalHoras = 0;

                    foreach (var tarefa in TarefasGrupo)
                    {
                        TimeSpan tempo = tarefa.DataRealFim.Value - tarefa.DataRealInicio.Value;
                        if(opcao == "horas")
                        {
                            totalHoras += tempo.TotalHours;
                        }
                        else if (opcao == "minutos")
                        {
                            totalHoras += tempo.TotalMinutes;
                        }
                        else if (opcao == "segundos")
                        {
                            totalHoras += tempo.TotalSeconds;
                        }
                    }

                    MediaTempo = totalHoras / TarefasGrupo.Count();
                    SP_Horas[TarefasGrupo.Key.ToString()] = MediaTempo;
                }

                return SP_Horas;

            }
        }

    }
}
