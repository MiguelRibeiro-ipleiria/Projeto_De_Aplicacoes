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
            textBox_Erros_Tipos_De_Tarefas.ForeColor = Color.Red;
            textBox_Erros_Tipos_De_Tarefas.Text = "";
            string descricao = txtDesc.Text;

            if (string.IsNullOrEmpty(descricao))
            {
                textBox_Erros_Tipos_De_Tarefas.Text = "Preencha o campo corretamente!";
            }
            else
            {
                var controller = new TipoTarefaController();
                controller.AdicionarTipoTarefa(descricao);
                AtualizarLista();
                textBox_Erros_Tipos_De_Tarefas.ForeColor = Color.Green;
                textBox_Erros_Tipos_De_Tarefas.Text = "Tipo Tarefa inserido com sucesso!";
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
            textBox_Erros_Tipos_De_Tarefas.ForeColor = Color.Red;
            TipoTarefa TipoTarefaSelecionado = lstLista.SelectedItem as TipoTarefa;
            var controller = new TipoTarefaController();

            if(TipoTarefaSelecionado == null)
            {
                textBox_Erros_Tipos_De_Tarefas.Text = "Selecione um tipo de tarefa!";
            }
            else
            {
                controller.EliminarTipoTarefa(TipoTarefaSelecionado);
                AtualizarLista();
                textBox_Erros_Tipos_De_Tarefas.Text = "Tipo de Tarefa eliminado com sucesso!";
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            textBox_Erros_Tipos_De_Tarefas.ForeColor = Color.Red;
            TipoTarefa TipoTarefaSelecionado = lstLista.SelectedItem as TipoTarefa;
            var controller = new TipoTarefaController();
            string descricao = txtDesc.Text;
            if (TipoTarefaSelecionado == null)
            {
                textBox_Erros_Tipos_De_Tarefas.Text = "Selecione um tipo de tarefa!";
            }
            else if (string.IsNullOrEmpty(descricao))
            {
                textBox_Erros_Tipos_De_Tarefas.Text = "Preencha o campo corretamente!";
            }
            else
            {
                textBox_Erros_Tipos_De_Tarefas.ForeColor = Color.Green;
                controller.EditarTipoTarefa(TipoTarefaSelecionado, descricao);
                AtualizarLista();
                textBox_Erros_Tipos_De_Tarefas.Text = "Tipo de Tarefa atualizado com sucesso!";
            }


        }
    }
}
