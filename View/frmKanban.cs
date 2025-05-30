using iTasks.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iTasks
{
    public partial class frmKanban : Form
    {
        public bool isGestor;
        public List<Tarefa> ListaTarefasToDo = new List<Tarefa>();
        public List<Tarefa> ListaTarefasDoing = new List<Tarefa>();
        public List<Tarefa> ListaTarefasDone = new List<Tarefa>();
        private Utilizador utilizador;
        public frmKanban(Utilizador utilizador)
        {
            InitializeComponent();
            this.utilizador = utilizador;

            label_NomeUser.Text = "Bem vindo: " + utilizador.Nome;
            var kanbancontroller = new KanbanController();

            ListaTarefasToDo = kanbancontroller.VerificarEstadoTodo();
            ListaTarefasDoing = kanbancontroller.VerificarEstadoDoing();
            ListaTarefasDone = kanbancontroller.VerificarEstadoDone();

            lstTodo.DataSource = null;
            lstTodo.DataSource = ListaTarefasToDo;
            lstDoing.DataSource = null;
            lstDoing.DataSource = ListaTarefasDoing; 
            lstDone.DataSource = null;
            lstDone.DataSource = ListaTarefasDone;

            
            isGestor = kanbancontroller.RestricoesUtilizador(utilizador);
            if(isGestor != true)
            {
                //Programador
                utilizadoresToolStripMenuItem.Enabled = false;
                btNova.Text = "Detalhes Tarefa";
            }
            else if(isGestor == true)
            {
                bool GereUtilizador = kanbancontroller.VerificarSeGereUtilizador(utilizador);
                if(GereUtilizador != true)
                {
                    gerirUtilizadoresToolStripMenuItem.Enabled = false;
                }
                else
                {
                    gerirUtilizadoresToolStripMenuItem.Enabled = true;
                }
            }

        }

        private void btPrevisao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaTarefasEmCurso frmTarefasEmCurso = new frmConsultaTarefasEmCurso();
            frmTarefasEmCurso.Show();
        }

        private void btNova_Click(object sender, EventArgs e)
        {
            var tarefaselecionada = lstDone.SelectedItem as Tarefa;

            this.Hide();
            frmDetalhesTarefa frmDetalhesTarefa = new frmDetalhesTarefa(utilizador, tarefaselecionada);
            frmDetalhesTarefa.Show();
        }

        private void gerirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGereUtilizadores frmgereutilizadores = new frmGereUtilizadores();
            frmgereutilizadores.Show();
        }

        private void gerirTiposDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGereTiposTarefas frmgertipotarefas = new frmGereTiposTarefas(utilizador);
            frmgertipotarefas.Show();
        }

        private void btSetDoing_Click(object sender, EventArgs e)
        {
            int contagem = 0;
            foreach(var tarefas in ListaTarefasDoing)
            {
                if(tarefas.Programador.Id == utilizador.Id)
                {
                    contagem = contagem + 1;
                }
            }
            if(contagem > 2)
            {
                MessageBox.Show("Não pode ter mais do que 2 tarefas a realizar ao mesmo tempo!");
            }
            else
            {
                DateTime Datarealinicio = DateTime.Now;
                var kanbancontroller = new KanbanController();
                var tarefaselecionada = lstTodo.SelectedItem as Tarefa;

                kanbancontroller.AlterarEstadoTarefaDoing(tarefaselecionada, utilizador, Datarealinicio);

                ListaTarefasToDo = kanbancontroller.VerificarEstadoTodo();
                ListaTarefasDoing = kanbancontroller.VerificarEstadoDoing();

                lstTodo.DataSource = null;
                lstTodo.DataSource = ListaTarefasToDo;
                lstDoing.DataSource = null;
                lstDoing.DataSource = ListaTarefasDoing;
            }

        }

        private void btSetTodo_Click(object sender, EventArgs e)
        {
            var kanbancontroller = new KanbanController();
            var tarefaselecionada = lstDoing.SelectedItem as Tarefa;

            kanbancontroller.AlterarEstadoTarefaToDo(tarefaselecionada, utilizador);

            ListaTarefasToDo = kanbancontroller.VerificarEstadoTodo();
            ListaTarefasDoing = kanbancontroller.VerificarEstadoDoing();

            lstTodo.DataSource = null;
            lstTodo.DataSource = ListaTarefasToDo;
            lstDoing.DataSource = null;
            lstDoing.DataSource = ListaTarefasDoing;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btSetDone_Click(object sender, EventArgs e)
        {
            var kanbancontroller = new KanbanController();
            var tarefaselecionada = lstDoing.SelectedItem as Tarefa;

            DateTime DataDeRealFim = DateTime.Now;
            kanbancontroller.AlterarEstadoTarefaDone(tarefaselecionada, utilizador, DataDeRealFim);

           
            ListaTarefasDoing = kanbancontroller.VerificarEstadoDoing();
            ListaTarefasDone = kanbancontroller.VerificarEstadoDone();

            lstDone.DataSource = null;
            lstDone.DataSource = ListaTarefasDone;
            lstDoing.DataSource = null;
            lstDoing.DataSource = ListaTarefasDoing;

            
        }
    }
}
