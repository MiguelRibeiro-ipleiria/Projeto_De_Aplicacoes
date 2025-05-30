using iTasks.Model;
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
    class TarefasController
    {
        public void AdicionarTarefa(string descricao,int ordem ,int storypoints,TipoTarefa tipotarefa, Programador programador, DateTime dataPrevistoInicio, DateTime dataPrevistoFim, EstadoAtual estadoatual, DateTime DatadeCriacao)
        {
            using (var db = new OrganizacaoContext())
            {
                var tarefa = new Tarefa { Descricao = descricao, OrdemExecucao = ordem, StoryPoints = storypoints, TipoTarefa = tipotarefa, Programador = programador, DataPrevistoInicio = dataPrevistoInicio, DataPrevistoFim = dataPrevistoInicio, Gestor = programador.Gestor, EstadoAtual = estadoatual, DataCriacao = DatadeCriacao};

                db.Progamadores.Attach(programador);
                db.Gestores.Attach(programador.Gestor);
                db.TipoTarefa.Attach(tipotarefa);

                db.Tarefas.Add(tarefa);
                db.SaveChanges();
            }
        }

        public void AlterarTarefa(Tarefa tarefa, string descricao, int ordem, int storypoints, TipoTarefa tipotarefa, Programador programador, DateTime dataPrevistoInicio, DateTime dataPrevistoFim, EstadoAtual estadoatual, DateTime DatadeCriacao)
        {
            using (var db = new OrganizacaoContext())
            {
                var queryAltarTarefa = (from tarefas in db.Tarefas
                                              where tarefas.Id == tarefa.Id
                                              select tarefas).FirstOrDefault();

                if (queryAltarTarefa != null)
                {
                    queryAltarTarefa.Descricao = descricao;
                    queryAltarTarefa.OrdemExecucao = ordem;
                    queryAltarTarefa.StoryPoints = storypoints;
                    queryAltarTarefa.TipoTarefa = tipotarefa;
                    queryAltarTarefa.Programador = programador;
                    queryAltarTarefa.DataPrevistoInicio = dataPrevistoInicio;
                    queryAltarTarefa.DataPrevistoFim = dataPrevistoFim;

                    db.SaveChanges();
                }
            }
        }
        

        public bool IsTarefa(Tarefa tarefa)
        {
            using (var db = new OrganizacaoContext())
            {
                var queryExisteTarefa = (from tarefas in db.Tarefas
                                        where tarefas.Id == tarefa.Id
                                        select tarefas);

                if (queryExisteTarefa.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public List<Programador> EnumararProgramadoresdosUsers(Utilizador utilizador)
        {
            List<Programador> listaprogramadores = new List<Programador>();

            using (var db = new OrganizacaoContext())
            {
                var queryAllProgramadores = from programadores in db.Progamadores
                                            where programadores.Gestor.Id == utilizador.Id
                                            select programadores;
                queryAllProgramadores = queryAllProgramadores.Include(x => x.Gestor);
            

                foreach (var programador in queryAllProgramadores)
                {
                    listaprogramadores.Add(programador);
                }

                return listaprogramadores;
            }
        }


        public bool VerificarGestorOuProgramador(Utilizador utilizador)
        {
            if (utilizador is Gestor gestor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarStoryPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            int limite = (int)Math.Sqrt(numero);
            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        public int IncrementarOrdem(Programador programador)
        {
            using (var db = new OrganizacaoContext())
            {

                int ordemMaior = 0;
                var queryOrdem = (from tarefas in db.Tarefas
                                                where tarefas.Programador.Id == programador.Id
                                                select tarefas.OrdemExecucao);

                if (queryOrdem != null)
                {
                    foreach (var ordens in queryOrdem)
                    {
                        if (ordens > ordemMaior)
                        {
                            ordemMaior = ordens;
                        }

                    }
                    return ordemMaior + 1;

                }
                else
                {
                    return 1;
                }

            }

           
        }

        public bool OrdemRep(Programador programador,int ordem)
        {

            using (var db = new OrganizacaoContext())
            {

                var queryOrdem = (from tarefas in db.Tarefas
                                  where tarefas.Programador.Id == programador.Id
                                  select tarefas.OrdemExecucao);

                if (queryOrdem != null)
                {
                    foreach (var ordens in queryOrdem)
                    {
                        if (ordens == ordem)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return true;
                }

            }


        }
    }
}
