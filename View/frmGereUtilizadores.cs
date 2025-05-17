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
        List<Gestor> listagestores = new List<Gestor>();
        List<Programador> listaprogramadores = new List<Programador>();

        public frmGereUtilizadores()
        {
            InitializeComponent();
            var controller = new UsersController();
            cbDepartamento.Items.AddRange(Enum.GetNames(typeof(Departamento)));
            cbNivelProg.Items.AddRange(Enum.GetNames(typeof(NivelExperiencia)));

            listagestores = controller.EnumararGestores();
            listaprogramadores = controller.EnumararProgramadores();

            lstListaGestores.DataSource = null;
            lstListaGestores.DataSource = listagestores;

            lstListaProgramadores.DataSource = null;
            lstListaProgramadores.DataSource = listaprogramadores;

            foreach(var gestores in listagestores)
            {
                cbGestorProg.Items.Add(gestores);
            }

        }


        private bool CheckUsername(string username)
        {
            try
            {
                bool usernameExiste = listagestores.Any(g => g.Username == username) || listaprogramadores.Any(g => g.Username == username);
                if (usernameExiste)
                {
                    return true; 
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btGravarGestor_Click(object sender, EventArgs e)
        {

            string nome = txtNomeGestor.Text;
            string username = txtUsernameGestor.Text;
            string pass = txtPasswordGestor.Text;
            string selectedText = cbDepartamento.SelectedItem.ToString();
            Departamento departamento = (Departamento)Enum.Parse(typeof(Departamento), selectedText);
            bool gerirutilizadores = chkGereUtilizadores.Checked;

            if(CheckUsername(username) == true)
            {
                MessageBox.Show("Username em uso!");
            }
            else
            {
                var controller = new UsersController();
                controller.AdicionarGestor(nome, username, pass, departamento, gerirutilizadores);
                AtualizarLista("Gestor");
            }

        }

        private void btGravarProg_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProg.Text;
            string username = txtUsernameProg.Text;
            string pass = txtPasswordProg.Text;
            string selectedNivelText = cbNivelProg.SelectedItem.ToString();
            NivelExperiencia NivelDeExperiencia = (NivelExperiencia)Enum.Parse(typeof(NivelExperiencia), selectedNivelText);
            Gestor gestorselecionado = (Gestor)cbGestorProg.SelectedItem;

            if (CheckUsername(username) == true)
            {
                MessageBox.Show("Username em uso!");
            }
            else
            {
                var controller = new UsersController();
                controller.AdicionarProgramador(nome, username, pass, NivelDeExperiencia, gestorselecionado);
                AtualizarLista("Programador");
            }
        }

        private void lstListaGestores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gestor GestorSelecionado = lstListaGestores.SelectedItem as Gestor;
            txtIdGestor.Text = GestorSelecionado.Id.ToString();
            txtNomeGestor.Text = GestorSelecionado.Nome;
            txtPasswordGestor.Text = GestorSelecionado.Password;
            txtUsernameGestor.Text = GestorSelecionado.Username;
            cbDepartamento.Text = GestorSelecionado.Departamento.ToString();
            txtUsernameGestor.Text = GestorSelecionado.Username;
            chkGereUtilizadores.Checked = GestorSelecionado.GereUtilizadores;
        }

        private void lstListaProgramadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Programador ProgramadorSelecionado = lstListaProgramadores.SelectedItem as Programador;
            txtIdProg.Text = ProgramadorSelecionado.Id.ToString();
            txtNomeProg.Text = ProgramadorSelecionado.Nome;
            txtPasswordProg.Text = ProgramadorSelecionado.Password;
            txtUsernameProg.Text = ProgramadorSelecionado.Username;
            cbNivelProg.Text = ProgramadorSelecionado.NivelExperiencia.ToString();
            cbGestorProg.Text = ProgramadorSelecionado.Gestor.ToString();

        }

        private void btLimparGestor_Click(object sender, EventArgs e)
        {
            txtIdGestor.Text = "";
            txtNomeGestor.Text = "";
            txtPasswordGestor.Text = "";
            txtUsernameGestor.Text = "";
            cbDepartamento.Text = "";
            txtUsernameGestor.Text = "";
            chkGereUtilizadores.Checked = false;
        }

        private void btLimparProg_Click(object sender, EventArgs e)
        {
            txtIdProg.Text = "";
            txtNomeProg.Text = "";
            txtPasswordProg.Text = "";
            txtUsernameProg.Text = "";
            cbNivelProg.Text = "";
            cbGestorProg.Text = "";
        }

        private void AtualizarLista(string utilizador)
        {
            var controller = new UsersController();
            if(utilizador == "Gestor")
            {
                listagestores = controller.EnumararGestores();
                lstListaGestores.DataSource = listagestores;
                foreach (var gestores in listagestores)
                {
                    cbGestorProg.Items.Add(gestores);
                }
            }
            else if(utilizador == "Programador")
            {
                listaprogramadores = controller.EnumararProgramadores();
                lstListaProgramadores.DataSource = listaprogramadores;

            }

        }
    }
}
