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
        public List<TipoTarefa> ListaTT = new List<TipoTarefa>();
        private Utilizador utilizador;

        public frmGereTiposTarefas(Utilizador utilizador)
        {
            InitializeComponent();
            lstLista.SelectedIndexChanged += lstLista_SelectedIndexChanged;
            AtualizarLista();

            this.utilizador = utilizador;

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoTarefaSelecionada = lstLista.SelectedItem as TipoTarefa;

            if (tipoTarefaSelecionada != null)
            {
                txtDesc.Text = tipoTarefaSelecionada.Nome;
            }
        }
        private void AtualizarLista()
        {

            var controller = new TipoTarefaController();
            ListaTT = controller.MostrarTipoTarefa();
            lstLista.DataSource = null;
            lstLista.DataSource = ListaTT;
        }
        private void btGravar_Click(object sender, EventArgs e)
        {
            label_descicao_erro.Text = "";
            string descricao = txtDesc.Text;

            if (string.IsNullOrEmpty(descricao))
            {
                label_descicao_erro.Text = "Preencha o campo acima";
            }
            else
            {
                var controller = new TipoTarefaController();
                controller.AdicionarTipoTarefa(descricao);
                AtualizarLista();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKanban frmKanban = new frmKanban(utilizador);
            frmKanban.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            TipoTarefa TipoTarefaSelecionado = lstLista.SelectedItem as TipoTarefa;
            var controller = new TipoTarefaController();
            controller.EliminarTipoTarefa(TipoTarefaSelecionado);
               
            AtualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoTarefa TipoTarefaSelecionado = lstLista.SelectedItem as TipoTarefa;
            var controller = new TipoTarefaController();
            string descricao = txtDesc.Text;
            controller.EditarTipoTarefa(TipoTarefaSelecionado,descricao);
            AtualizarLista();
        }
    }
}
