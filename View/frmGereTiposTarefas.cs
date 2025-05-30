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
    public partial class frmGereTiposTarefas : Form
    {
        private Utilizador utilizador;
        public frmGereTiposTarefas(Utilizador utilizador)
        {
            InitializeComponent();
            AtualizarLista();
            this.utilizador = utilizador;

        }
        public List<TipoTarefa> ListaTT = new List<TipoTarefa>();
        private void AtualizarLista()
        {

            var controller = new TipoTarefaController();
            ListaTT = controller.MostrarTipoTarefa();
            lstLista.DataSource = null;
            lstLista.DataSource = ListaTT;
        }
        private void btGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDesc.Text;


            var controller = new TipoTarefaController();
            controller.AdicionarTipoTarefa(descricao);
            AtualizarLista();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKanban frmKanban = new frmKanban(utilizador);
            frmKanban.Show();
        }
    }
}
