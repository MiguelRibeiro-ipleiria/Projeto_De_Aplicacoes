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
        public frmDetalhesTarefa()
        {
            InitializeComponent();
            var userscontroller = new UsersController();
            var tipotarefascontroller = new TipoTarefaController();
            listaprogramadores = userscontroller.EnumararProgramadores();
            listatipotarefas = tipotarefascontroller.MostrarTipoTarefa();

            cbProgramador.DataSource = null;
            cbProgramador.DataSource = listaprogramadores;

            cbTipoTarefa.DataSource = null;
            cbTipoTarefa.DataSource = listatipotarefas;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDesc.Text;
            string ordem = txtOrdem.Text;
            int storypoints = int.Parse(txtStoryPoints.Text);
            TipoTarefa tipotarefa = (TipoTarefa)cbTipoTarefa.SelectedItem;
            Programador programador = (Programador)cbProgramador.SelectedItem;

            DateTime datainicio = dtInicio.Value;
            DateTime datafim = dtFim.Value;

            txtDataRealini.Text = datainicio.ToString();
            txtdataRealFim.Text = datafim.ToString();

            var tarefascontroller = new TarefasController();
            tarefascontroller.AdicionarTarefa(descricao, ordem, storypoints, tipotarefa, programador, datainicio, datafim);            
        }
    }
}
