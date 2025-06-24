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
            label_erro_gestores.Text = "";
            try
            {
                string nome = txtNomeGestor.Text;
                string username = txtUsernameGestor.Text;
                string pass = txtPasswordGestor.Text;
                
                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass) || cbDepartamento.SelectedItem == null)
                {
                    label_erro_gestores.Text = "Preencha todos os campos";  
                    return;
                }

                string selectedText = cbDepartamento.SelectedItem.ToString();
                Departamento departamento = (Departamento)Enum.Parse(typeof(Departamento), selectedText);
                bool gerirutilizadores = chkGereUtilizadores.Checked;

                if (CheckUsername(username) == true)
                {
                    label_erro_gestores.Text = "Username em uso";
                }
                else
                {
                    var controller = new UsersController();
                    controller.AdicionarGestor(nome, username, pass, departamento, gerirutilizadores);
                    AtualizarLista("Gestor");


                }
            }
            catch (Exception ex)
            {
                label_erro_gestores.Text = "Erro: " + ex.Message;
            }
        }

        private void btGravarProg_Click(object sender, EventArgs e)
        {
            label_erro_programadores.Text = "";
            try
            {
                string nome = txtNomeProg.Text;
                string username = txtUsernameProg.Text;
                string pass = txtPasswordProg.Text;
                string selectedNivelText = cbNivelProg.SelectedItem.ToString();
                NivelExperiencia NivelDeExperiencia = (NivelExperiencia)Enum.Parse(typeof(NivelExperiencia), selectedNivelText);
                Gestor gestorselecionado = (Gestor)cbGestorProg.SelectedItem;

                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
                {
                    label_erro_programadores.Text = "Preencha todos os campos";
                    return;
                }

                if (CheckUsername(username) == true)
                {
                    label_erro_programadores.Text = "Username em uso";

                }
                else
                {
                    var controller = new UsersController();
                    controller.AdicionarProgramador(nome, username, pass, NivelDeExperiencia, gestorselecionado);
                    AtualizarLista("Programador");
                }
            }
            catch (Exception ex)
            {
                label_erro_programadores.Text = "Erro: " + ex.Message;
            }
        }

        private void lstListaGestores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Gestor GestorSelecionado = lstListaGestores.SelectedItem as Gestor;
                if(GestorSelecionado == null)
                {
                    lstListaGestores.ClearSelected();
                    txtIdGestor.Clear();
                    txtNomeGestor.Clear();
                    txtPasswordGestor.Clear();
                    txtUsernameGestor.Clear();
                    cbDepartamento.SelectedIndex = -1;
                    chkGereUtilizadores.Checked = false;
                    return;
                }
                else
                {
                    txtIdGestor.Text = GestorSelecionado.Id.ToString();
                    txtNomeGestor.Text = GestorSelecionado.Nome;
                    txtPasswordGestor.Text = GestorSelecionado.Password;
                    txtUsernameGestor.Text = GestorSelecionado.Username;
                    cbDepartamento.Text = GestorSelecionado.Departamento.ToString();
                    txtUsernameGestor.Text = GestorSelecionado.Username;
                    chkGereUtilizadores.Checked = GestorSelecionado.GereUtilizadores;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }


        }

        private void lstListaProgramadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Programador ProgramadorSelecionado = lstListaProgramadores.SelectedItem as Programador;
                if (ProgramadorSelecionado == null)
                {
                    lstListaGestores.ClearSelected();
                    txtIdProg.Clear();
                    txtNomeProg.Clear();
                    txtPasswordProg.Clear();
                    txtNomeProg.Clear();
                    txtUsernameProg.Clear();
                    cbNivelProg.SelectedIndex = -1;
                    cbGestorProg.SelectedIndex = -1;
                    return;
                }
                else
                {
                    txtIdProg.Text = ProgramadorSelecionado.Id.ToString();
                    txtNomeProg.Text = ProgramadorSelecionado.Nome;
                    txtPasswordProg.Text = ProgramadorSelecionado.Password;
                    txtUsernameProg.Text = ProgramadorSelecionado.Username;
                    cbNivelProg.Text = ProgramadorSelecionado.NivelExperiencia.ToString();
                    cbGestorProg.Text = ProgramadorSelecionado.Gestor.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }

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
                cbGestorProg.Items.Clear();
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

        private void button_Fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void Eliminar_Gestor_Click(object sender, EventArgs e)
        {
            Gestor GestorSelecionado = lstListaGestores.SelectedItem as Gestor;
            if(GestorSelecionado != null)
            {
                if (ValidGestorBox())
                {

                    var controller = new UsersController();
                    controller.EliminarGestor(GestorSelecionado);

                    listagestores = controller.EnumararGestores();
                    lstListaGestores.DataSource = null;
                    lstListaGestores.DataSource = listagestores;

                    listaprogramadores = controller.EnumararProgramadores();
                    lstListaProgramadores.DataSource = null;
                    lstListaProgramadores.DataSource = listaprogramadores;

                    lstListaGestores.ClearSelected();
                    txtIdGestor.Clear();
                    txtNomeGestor.Clear();
                    txtPasswordGestor.Clear();
                    txtUsernameGestor.Clear();
                    cbDepartamento.SelectedIndex = -1;
                    chkGereUtilizadores.Checked = false;

                    lstListaGestores.ClearSelected();
                    txtIdProg.Clear();
                    txtNomeProg.Clear();
                    txtPasswordProg.Clear();
                    txtNomeProg.Clear();
                    txtUsernameProg.Clear();
                    cbNivelProg.SelectedIndex = -1;
                    cbGestorProg.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Nenhum Gestor selecionado");
            }
        }

        private void Eliminar_Programador_Click(object sender, EventArgs e)
        {
            Programador ProgramadorSelecionado = lstListaProgramadores.SelectedItem as Programador;
            if (ProgramadorSelecionado != null)
            {
                if (ValidProgramadorBox())
                {
                    var controller = new UsersController();
                    controller.EliminarProgramador(ProgramadorSelecionado);

                    listaprogramadores = controller.EnumararProgramadores();
                    lstListaProgramadores.DataSource = null;
                    lstListaProgramadores.DataSource = listaprogramadores;


                    lstListaProgramadores.ClearSelected();
                    txtIdProg.Clear();
                    txtNomeProg.Clear();
                    txtPasswordProg.Clear();
                    txtNomeProg.Clear();
                    txtUsernameProg.Clear();
                    cbNivelProg.SelectedIndex = -1;
                    cbGestorProg.SelectedIndex = -1;
                }
            }     
            else
            {
                MessageBox.Show("Nenhum Programador selecionado");
            }

        }

        private bool ValidGestorBox()
        {
            var popup = new Form()
            {
                Width = 400,
                Height = 200,
                Text = "Eliminar Gestor",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                AcceptButton = null,
                CancelButton = null
            };

            var messageLabel = new Label()
            {
                Text = "Eliminar o gestor irá também eliminar todos os seus programadores e tarefas!",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 60,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Padding = new Padding(10)
            };

            var avisalabel = new Label()
            {
                Text = "Deseja continuar?",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            var buttonPanel = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.RightToLeft,
                Dock = DockStyle.Bottom,
                Padding = new Padding(10),
                Height = 60
            };

            var okButton = new Button()
            {
                Text = "Eliminar",
                DialogResult = DialogResult.OK,
                Width = 100,
                Height = 35
            };

            var cancelButton = new Button()
            {
                Text = "Cancelar",
                DialogResult = DialogResult.Cancel,
                Width = 100,
                Height = 35
            };

            buttonPanel.Controls.Add(okButton);
            buttonPanel.Controls.Add(cancelButton);

            popup.Controls.Add(buttonPanel);
            popup.Controls.Add(avisalabel);
            popup.Controls.Add(messageLabel);

            popup.AcceptButton = okButton;
            popup.CancelButton = cancelButton;

            var result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidProgramadorBox()
        {
            var popup = new Form()
            {
                Width = 400,
                Height = 200,
                Text = "Eliminar Programador",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                AcceptButton = null,
                CancelButton = null
            };

            var messageLabel = new Label()
            {
                Text = "Eliminar o programador irá também eliminar todas as suas tarefas!",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 60,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Padding = new Padding(10)
            };

            var avisalabel = new Label()
            {
                Text = "Deseja continuar?",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 40,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            var buttonPanel = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.RightToLeft,
                Dock = DockStyle.Bottom,
                Padding = new Padding(10),
                Height = 60
            };

            var okButton = new Button()
            {
                Text = "Eliminar",
                DialogResult = DialogResult.OK,
                Width = 100,
                Height = 35
            };

            var cancelButton = new Button()
            {
                Text = "Cancelar",
                DialogResult = DialogResult.Cancel,
                Width = 100,
                Height = 35
            };

            buttonPanel.Controls.Add(okButton);
            buttonPanel.Controls.Add(cancelButton);

            popup.Controls.Add(buttonPanel);
            popup.Controls.Add(avisalabel);
            popup.Controls.Add(messageLabel);

            popup.AcceptButton = okButton;
            popup.CancelButton = cancelButton;

            var result = popup.ShowDialog();

            if (result == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnEditarGestor_Click(object sender, EventArgs e)
        {
            Gestor GestorSelecionado = lstListaGestores.SelectedItem as Gestor;
            var controller = new UsersController();
            string nome = txtNomeGestor.Text;
            string username = txtUsernameGestor.Text;
            string pass = txtPasswordGestor.Text;
            string selectedText = cbDepartamento.SelectedItem.ToString();
            Departamento departamento = (Departamento)Enum.Parse(typeof(Departamento), selectedText);
            bool gerirutilizadores = chkGereUtilizadores.Checked;
            controller.EditarGestor(GestorSelecionado,nome,username,pass, departamento, gerirutilizadores);
            AtualizarLista("Gestor");
            
        }

        private void btnEditarProg_Click(object sender, EventArgs e)
        {

            Programador ProgramadorSelecionado = lstListaProgramadores.SelectedItem as Programador;
            var controller = new UsersController();
            string nome = txtNomeProg.Text;
            string username = txtUsernameProg.Text;
            string pass = txtPasswordProg.Text;
            string selectedNivelText = cbNivelProg.SelectedItem.ToString();
            NivelExperiencia NivelDeExperiencia = (NivelExperiencia)Enum.Parse(typeof(NivelExperiencia), selectedNivelText);
            Gestor gestorselecionado = (Gestor)cbGestorProg.SelectedItem;
            controller.EditarProgramador(ProgramadorSelecionado, nome, username, pass, NivelDeExperiencia, gestorselecionado);
            AtualizarLista("Programador");
          
         }
    }
}
