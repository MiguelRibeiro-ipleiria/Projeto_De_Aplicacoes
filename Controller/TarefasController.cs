using iTasks.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
                db.Utilizadores.Attach(programador.Gestor);
                db.Utilizadores.Attach(programador);

                db.Tarefas.Add(tarefa);
                db.SaveChanges();
            }
        }

        public void AlterarTarefa(Tarefa tarefa, string descricao, int ordem, int storypoints,
            TipoTarefa tipotarefa, Programador programador,
            DateTime dataPrevistoInicio, DateTime dataPrevistoFim,
            EstadoAtual estadoatual, DateTime DatadeCriacao)
        {
            using (var db = new OrganizacaoContext())
            {
                // Carrega a tarefa existente do banco, incluindo Programador e TipoTarefa
                var tarefaDb = db.Tarefas
                    .Include(t => t.Programador)
                    .Include(t => t.TipoTarefa)
                    .Include(t => t.Programador.Gestor)
                    .FirstOrDefault(t => t.Id == tarefa.Id);

                if (tarefaDb == null)
                    throw new Exception("Tarefa não encontrada.");

                // Atualiza apenas os campos da tarefa
                tarefaDb.Descricao = descricao;
                tarefaDb.OrdemExecucao = ordem;
                tarefaDb.StoryPoints = storypoints;
                tarefaDb.DataPrevistoInicio = dataPrevistoInicio;
                tarefaDb.DataPrevistoFim = dataPrevistoFim;

                // Carrega o Programador e TipoTarefa corretos do banco
                var programadorDb = db.Progamadores.Find(programador.Id);
                var tipoTarefaDb = db.TipoTarefa.Find(tipotarefa.Id);
                var gestor = db.Gestores.Find(programador.Gestor.Id);

                if (programadorDb == null || tipoTarefaDb == null || gestor == null)
                    throw new Exception("Programador ou Tipo de Tarefa não encontrados.");

                tarefaDb.Programador = programadorDb;
                tarefaDb.TipoTarefa = tipoTarefaDb;
                tarefaDb.Programador.Gestor = gestor;

                db.SaveChanges();
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
        public bool VerificarNumeroFibonacci(int numero)
        {
            bool EhQuadradoPerfeito(int x)
            {
                int s = (int)Math.Sqrt(x);
                return s * s == x;
            }

            return EhQuadradoPerfeito(5 * numero * numero + 4) ||
                   EhQuadradoPerfeito(5 * numero * numero - 4);
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
