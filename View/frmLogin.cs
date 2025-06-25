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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var logincontroller = new LoginController();
            bool islogged = logincontroller.Login(username, password);
            if(islogged == true)
            {
                this.Hide();

                Utilizador utilizadorlogado = logincontroller.UserLoggedInfo(username, password);

                frmKanban frmKanban = new frmKanban(utilizadorlogado);
                frmKanban.Show();

                Infologged.Text = "LOGADO";
            }
            else
            {
                Infologged.Text = "Dados Incorretos";
            }

        }

        private void button_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGereUtilizadores frmGerirUtilizadores = new frmGereUtilizadores();
            frmGerirUtilizadores.Show();
        }
    }
}
