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
    public partial class frmGereUtilizadores : Form
    {
        public frmGereUtilizadores()
        {
            InitializeComponent();
            cbDepartamento.Items.AddRange(Enum.GetNames(typeof(Departamento)));
            cbNivelProg.Items.AddRange(Enum.GetNames(typeof(NivelExperiencia)));

        }


        private void btGravarGestor_Click(object sender, EventArgs e)
        {

            string nome = txtNomeGestor.Text;
            string username = txtUsernameGestor.Text;
            string pass = txtPasswordGestor.Text;
            string selectedText = cbDepartamento.SelectedItem.ToString();
            Departamento departamento = (Departamento)Enum.Parse(typeof(Departamento), selectedText);
            bool gerirutilizadores = chkGereUtilizadores.Checked;

            var controller = new UsersController();
            controller.AdicionarGestor(nome, username, pass, departamento, gerirutilizadores);

        }

        private void btGravarProg_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProg.Text;
            string username = txtUsernameProg.Text;
            string pass = txtPasswordProg.Text;
            string selectedText = cbNivelProg.SelectedItem.ToString();
            NivelExperiencia NivelDeExperiencia = (NivelExperiencia)Enum.Parse(typeof(NivelExperiencia), selectedText);

        }
    }
}
