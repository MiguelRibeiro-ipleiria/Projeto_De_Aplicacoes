using iTasks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
