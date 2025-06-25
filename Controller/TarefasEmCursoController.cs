using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace iTasks.Controller
{
    class TarefasEmCursoController
    {
        public class AtributosSelecionadosDasTarefas
        {
            public string Nome_Do_Programador { get; set; }
            public EstadoAtual Estado { get; set; }
            public string Tempo_Que_Falta_Para_Concluir { get; set; }
            public string Tempo_De_Atraso { get; set; }
        }
        public List<Tarefa> TarefasTODOeDOINGdoGestor(Utilizador utilizador)
        {
            var tarefasSelecionadas = new List<Tarefa>();

            using (var db = new OrganizacaoContext())
            {
                var queryTarefasTodoEDoing = from tarefa in db.Tarefas
                                              where tarefa.Gestor.Id == utilizador.Id &&
                                                    (tarefa.EstadoAtual == EstadoAtual.ToDo || tarefa.EstadoAtual == EstadoAtual.Doing)
                                              select tarefa;
                queryTarefasTodoEDoing = queryTarefasTodoEDoing.Include(x => x.Programador);
                queryTarefasTodoEDoing = queryTarefasTodoEDoing.Include(x => x.Gestor);
                queryTarefasTodoEDoing = queryTarefasTodoEDoing.Include(x => x.TipoTarefa);

                foreach (var tarefa in queryTarefasTodoEDoing)
                {
                    tarefasSelecionadas.Add(tarefa);
                }

                return tarefasSelecionadas;
            }
        }
    }
}
