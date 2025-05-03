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
    public partial class frmGereUtilizadores : Form
    {
        public frmGereUtilizadores()
        {
            InitializeComponent();
        }


        private void btGravarGestor_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtIdGestor.Text);
            string nome = txtNomeGestor.Text;
            string username = txtUsernameGestor.Text;
            string pass = txtPasswordGestor.Text;
            string departamento = cbDepartamento.Text;
            bool gerirutilizadores = chkGereUtilizadores.Checked;

            using (var db = new OrganizacaoContext())
            {
                var user = new Gestor(id, nome, username, pass, departamento, gerirutilizadores);
                db.Utilizadores.Add(user);

                db.SaveChanges();
            }

        }

        private void btGravarProg_Click(object sender, EventArgs e)
        {

        }
    }
}
