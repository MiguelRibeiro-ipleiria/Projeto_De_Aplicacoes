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
    public partial class frmConsultarTarefasConcluidas : Form
    {
        private List<Tarefa> ListConcluida = new List<Tarefa>();
        private Utilizador utilizadorLogado;

        public frmConsultarTarefasConcluidas(Utilizador utilizador)
        {
            InitializeComponent();
            utilizadorLogado = utilizador;
            var consultasdone = new ConsultasDone();

            ListConcluida = consultasdone.ConsultaProgramadorTarefasDone(utilizador);
            gvTarefasConcluidas.DataSource = null;
            gvTarefasConcluidas.DataSource = ListConcluida;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKanban frmKanban = new frmKanban(utilizadorLogado);
            frmKanban.Show();
        }
    }
}
