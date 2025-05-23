using iTasks.Controller;
using iTasks.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks
{
    public partial class frmDetalhesTarefa : Form
    {
        List<TipoTarefa> listatipotarefas = new List<TipoTarefa>();
        List<Programador> listaprogramadores = new List<Programador>();
        private Utilizador utilizador;
        public frmDetalhesTarefa(Utilizador utilizador, Tarefa tarefa)
        {
            InitializeComponent();
            this.utilizador = utilizador;

            InserirDadosNasCB();
            DetalhesTarefa(tarefa);
            VerificarGestorOuProgramador(utilizador);

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDesc.Text;
            int ordem = int.Parse(txtOrdem.Text);
            int storypoints = int.Parse(txtStoryPoints.Text);
            TipoTarefa tipotarefa = (TipoTarefa)cbTipoTarefa.SelectedItem;
            Programador programador = (Programador)cbProgramador.SelectedItem;
            EstadoAtual estadoatual = EstadoAtual.ToDo;
            DateTime DataDeCriacao = DateTime.Now.Date;

            DateTime datainicio = dtInicio.Value;
            DateTime datafim = dtFim.Value;

            txtDataRealini.Text = datainicio.ToString();
            txtdataRealFim.Text = datafim.ToString();

            var tarefascontroller = new TarefasController();
            tarefascontroller.AdicionarTarefa(descricao, ordem, storypoints, tipotarefa, programador, datainicio, datafim, estadoatual, DataDeCriacao);            
        }
        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKanban frmKanban = new frmKanban(utilizador);
            frmKanban.Show();
        }

        private void DetalhesTarefa(Tarefa Tarefa)
        {
            txtId.Text = Tarefa.Id.ToString();
            txtEstado.Text = Tarefa.EstadoAtual.ToString();
            txtDataCriacao.Text = Tarefa.DataCriacao.ToString();
            txtDataRealini.Text = Tarefa.DataRealInicio.ToString();
            txtdataRealFim.Text = Tarefa.DataRealFim.ToString();
        }

        private void InserirDadosNasCB()
        {
            var userscontroller = new UsersController();
            var tipotarefascontroller = new TipoTarefaController();

            listaprogramadores = userscontroller.EnumararProgramadores();
            listatipotarefas = tipotarefascontroller.MostrarTipoTarefa();

            cbProgramador.DataSource = null;
            cbProgramador.DataSource = listaprogramadores;

            cbTipoTarefa.DataSource = null;
            cbTipoTarefa.DataSource = listatipotarefas;
        }

        private void VerificarGestorOuProgramador(Utilizador utilizador)
        {
            var tarefascontroller = new TarefasController();
            bool isGestor = tarefascontroller.VerificarGestorOuProgramador(utilizador);
            RestrincoesAoProgramador(isGestor);
        }

        private void RestrincoesAoProgramador(bool IsGestor)
        {
            if (!IsGestor)
            {
                //É Programador
                txtDesc.Enabled = false;
                txtOrdem.Enabled = false;
                txtStoryPoints.Enabled = false;
                cbProgramador.Enabled = false;
                cbTipoTarefa.Enabled = false;
                dtFim.Enabled = false;
                dtInicio.Enabled = false;
                btGravar.Enabled = false;
            }
        }



    }
}
