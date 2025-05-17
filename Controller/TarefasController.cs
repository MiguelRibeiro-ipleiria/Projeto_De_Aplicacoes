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
        public void AdicionarTarefa(string descricao,string ordem ,int storypoints,TipoTarefa tipotarefa, Programador programador, DateTime dataPrevistoInicio, DateTime dataPrevistoFim)
        {
            using (var db = new OrganizacaoContext())
            {
                var tarefa = new Tarefa { Descricao = descricao, OrdemExecucao = ordem, StoryPoints = storypoints, TipoTarefa = tipotarefa, Programador = programador, DataPrevistoInicio = dataPrevistoInicio, DataPrevistoFim = dataPrevistoInicio};

                db.Tarefas.Add(tarefa);
                db.SaveChanges();
            }
        }
    }
}
