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
    public partial class frmConsultaTarefasEmCurso : Form
    {
        private List<Tarefa> ListTarefaEmCurso = new List<Tarefa>();
        private Utilizador utilizadorLogado;
        public frmConsultaTarefasEmCurso(Utilizador utilizador)
        {
            InitializeComponent();
            utilizadorLogado = utilizador;
            var kanbancontroller = new KanbanController();

            ListTarefaEmCurso = kanbancontroller.VerificarEstadoDoing();
            gvTarefasEmCurso.DataSource = null;
            gvTarefasEmCurso.DataSource = ListTarefaEmCurso;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKanban frmKanban = new frmKanban(utilizadorLogado);
            frmKanban.Show();
        }
    }
}
        
