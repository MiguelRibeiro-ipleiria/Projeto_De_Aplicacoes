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

namespace iTasks
{
    public partial class frmGereTiposTarefas : Form
    {
        public frmGereTiposTarefas()
        {
            InitializeComponent();
            AtualizarLista();


        }
        public List<string> ListaTT = new List<string>();
        private void AtualizarLista()
        {

            var controller = new TipoTarefaController();
            ListaTT = controller.MostrarTipoTarefa();
            lstLista.DataSource = ListaTT;
        }
        private void btGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDesc.Text;


            var controller = new TipoTarefaController();
            controller.AdicionarTipoTarefa(descricao);
            AtualizarLista();


        }
    }
}
