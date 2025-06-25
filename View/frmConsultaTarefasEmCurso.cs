using iTasks.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTasks.Controller.TarefasEmCursoController;

namespace iTasks
{
    public partial class frmConsultaTarefasEmCurso : Form
    {
        private List<Tarefa> ListTarefaEmCursoePorcomeçar = new List<Tarefa>();
        private List<AtributosSelecionadosDasTarefas> ListComAtributosEscolhidos = new List<AtributosSelecionadosDasTarefas>();

        private Utilizador utilizadorLogado;

        public frmConsultaTarefasEmCurso(Utilizador utilizador)
        {
            InitializeComponent();
            utilizadorLogado = utilizador;
            TarefasEmCurso();
        }

        public void TarefasEmCurso()
        {
            var TarefasEmCursoController = new TarefasEmCursoController();

            ListTarefaEmCursoePorcomeçar = TarefasEmCursoController.TarefasTODOeDOINGdoGestor(utilizadorLogado);

            foreach (var Tarefa in ListTarefaEmCursoePorcomeçar)
            {
                double? TempoParaTerminar = null;
                double? TempoParaAtraso = null;

                var Tempo_Em_Falta = (Tarefa.DataPrevistoFim.Value - DateTime.Now).TotalHours;
                if(Tempo_Em_Falta > 0)
                {
                    TempoParaTerminar = Math.Round(Tempo_Em_Falta, 1);
                }
                else
                {
                    TempoParaTerminar = 0;
                }

                var Tempo_Caso_Atraso = (DateTime.Now - Tarefa.DataPrevistoFim.Value).TotalHours;
                if (Tempo_Caso_Atraso > 0)
                {
                    TempoParaAtraso = Math.Round(Tempo_Caso_Atraso, 1);
                }
                else
                {
                    TempoParaAtraso = 0;
                }

                ListComAtributosEscolhidos.Add(new AtributosSelecionadosDasTarefas
                {
                    Nome_Do_Programador = Tarefa.Programador.Nome,
                    Estado = Tarefa.EstadoAtual,
                    Tempo_Que_Falta_Para_Concluir = TempoParaTerminar + " Horas",
                    Tempo_De_Atraso = TempoParaAtraso + " Horas"
                });

            }




            gvTarefasEmCurso.DataSource = null;
            gvTarefasEmCurso.DataSource = ListComAtributosEscolhidos;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKanban frmKanban = new frmKanban(utilizadorLogado);
            frmKanban.Show();
        }
    }
}
        
