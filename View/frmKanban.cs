using iTasks.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iTasks
{
    public partial class frmKanban : Form
    {
        public bool isGestor;

        public List<Tarefa> ListaTarefasToDo = new List<Tarefa>();
        public List<Tarefa> ListaTarefasDoing = new List<Tarefa>();
        public List<Tarefa> ListaTarefasDone = new List<Tarefa>();
        Dictionary<string, double> SP_Tempo = new Dictionary<string, double>();

        private Utilizador utilizador;
        public frmKanban(Utilizador utilizador)
        {
            InitializeComponent();
            this.utilizador = utilizador;

            label_NomeUser.Text = "Bem vindo: " + utilizador.Nome;
            var kanbancontroller = new KanbanController();

            ListaTarefasToDo = kanbancontroller.VerificarEstadoTodo();
            ListaTarefasDoing = kanbancontroller.VerificarEstadoDoing();
            ListaTarefasDone = kanbancontroller.VerificarEstadoDone();

            lstTodo.DataSource = null;
            lstTodo.DataSource = ListaTarefasToDo;
            lstDoing.DataSource = null;
            lstDoing.DataSource = ListaTarefasDoing; 
            lstDone.DataSource = null;
            lstDone.DataSource = ListaTarefasDone;

            
            isGestor = kanbancontroller.RestricoesUtilizador(utilizador);
            if(isGestor != true)
            {
                //Programador
                utilizadoresToolStripMenuItem.Enabled = false;
                exportarParaCSVToolStripMenuItem.Enabled = false;
                tarefasEmCursoToolStripMenuItem.Enabled = false;
            }
            else if(isGestor == true)
            {
                bool GereUtilizador = kanbancontroller.VerificarSeGereUtilizador(utilizador);
                if(GereUtilizador != true)
                {
                    gerirUtilizadoresToolStripMenuItem.Enabled = false;
                }
                else
                {
                    gerirUtilizadoresToolStripMenuItem.Enabled = true;
                }
            }

        }

        private void btPrevisao_Click(object sender, EventArgs e)
        {
            DetalhesTempoPorSP();
        }

        private void btNova_Click(object sender, EventArgs e)
        {
            Tarefa NovaTarefa = new Tarefa();

            this.Hide();
            frmDetalhesTarefa frmDetalhesTarefa = new frmDetalhesTarefa(utilizador, NovaTarefa);
            frmDetalhesTarefa.Show();
        }

        private void gerirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGereUtilizadores frmgereutilizadores = new frmGereUtilizadores();
            frmgereutilizadores.Show();
        }

        private void gerirTiposDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGereTiposTarefas frmgertipotarefas = new frmGereTiposTarefas(utilizador);
            frmgertipotarefas.Show();
        }

        private void btSetDoing_Click(object sender, EventArgs e)
        {
            textBox_Erros_Lst_DOING.Clear();
            textBox_Erros_Lst_TODO.Clear();
            textBox_Erros_Lst_DONE.Clear();

            textBox_Erros_Lst_TODO.ForeColor = Color.Red;
            var kanbancontroller = new KanbanController();
            var tarefaselecionada = lstTodo.SelectedItem as Tarefa;

            if(tarefaselecionada != null)
            {
                int contagemDoing = 0;
                Tarefa MenorOrdem = kanbancontroller.TarefaMenorOrdemDoUtilizadorNoTODO(utilizador, tarefaselecionada);
                if (MenorOrdem == null)
                {
                    textBox_Erros_Lst_TODO.Text = "- Não é o responsável pela Tarefa!";
                    return;
                }

                foreach (var tarefas in ListaTarefasDoing)
                {
                    if (tarefas.Programador.Id == utilizador.Id)
                    {
                        contagemDoing++;
                    }
                }

                if (contagemDoing >= 2)
                {
                    textBox_Erros_Lst_TODO.Text = "- Não pode ter mais do que 2 tarefas em execução ao mesmo tempo!";
                    return;
                }
                if (tarefaselecionada.OrdemExecucao == MenorOrdem.OrdemExecucao)
                {
                    DateTime Datarealinicio = DateTime.Now;

                    if(kanbancontroller.AlterarEstadoTarefaDoing(tarefaselecionada, utilizador, Datarealinicio))
                    {
                        textBox_Erros_Lst_TODO.ForeColor = Color.Green;
                        textBox_Erros_Lst_DOING.ForeColor = Color.Green;

                        textBox_Erros_Lst_TODO.Text = "- A " + tarefaselecionada.OrdemExecucao + "º Tarefa de " + tarefaselecionada.Programador.Nome + " foi movida! (Doing)";
                        textBox_Erros_Lst_DOING.Text = "- " + tarefaselecionada.OrdemExecucao + "º Tarefa de " + tarefaselecionada.Programador.Nome + " adicionada!";

                        ListaTarefasToDo = kanbancontroller.VerificarEstadoTodo();
                        ListaTarefasDoing = kanbancontroller.VerificarEstadoDoing();

                        lstTodo.DataSource = null;
                        lstTodo.DataSource = ListaTarefasToDo;
                        lstDoing.DataSource = null;
                        lstDoing.DataSource = ListaTarefasDoing;
                    }
                    else
                    {
                        textBox_Erros_Lst_TODO.Text = "- Esta tarefa não lhe pertence!";
                    }

                }
                else
                {
                    textBox_Erros_Lst_TODO.Text = "- Incie outras tarefas para poder começar esta!";
                }
            }
            else
            {
                textBox_Erros_Lst_TODO.Text = "- Selecione alguma tarefa!";
            }


        }

        private void btSetTodo_Click(object sender, EventArgs e)
        {
            textBox_Erros_Lst_DOING.Clear();
            textBox_Erros_Lst_TODO.Clear();
            textBox_Erros_Lst_DONE.Clear();
            textBox_Erros_Lst_DOING.ForeColor = Color.Red;

            var kanbancontroller = new KanbanController();
            var tarefaselecionada = lstDoing.SelectedItem as Tarefa;
            
            if(tarefaselecionada != null)
            {
                Tarefa MaiorOrdem = kanbancontroller.TarefaMaiorOrdemDoUtilizadorNoDOING(utilizador, tarefaselecionada);
                if (MaiorOrdem == null)
                {
                    textBox_Erros_Lst_DOING.Text = "- Esta tarefa não lhe pertence!";
                    return;
                }
                if (tarefaselecionada.OrdemExecucao == MaiorOrdem.OrdemExecucao)
                {
                    if (kanbancontroller.AlterarEstadoTarefaToDo(tarefaselecionada, utilizador))
                    {
                        ListaTarefasToDo = kanbancontroller.VerificarEstadoTodo();
                        ListaTarefasDoing = kanbancontroller.VerificarEstadoDoing();

                        lstTodo.DataSource = null;
                        lstTodo.DataSource = ListaTarefasToDo;
                        lstDoing.DataSource = null;
                        lstDoing.DataSource = ListaTarefasDoing;

                        textBox_Erros_Lst_TODO.ForeColor = Color.Green;
                        textBox_Erros_Lst_DOING.ForeColor = Color.Green;

                        textBox_Erros_Lst_DOING.Text = "- A " + tarefaselecionada.OrdemExecucao + "º Tarefa de " + tarefaselecionada.Programador.Nome + " foi movida! (ToDo)";
                        textBox_Erros_Lst_TODO.Text = "- " + tarefaselecionada.OrdemExecucao + "º Tarefa de " + tarefaselecionada.Programador.Nome + " adicionada!";
                    }
                    else
                    {
                        textBox_Erros_Lst_DOING.Text = "- Esta tarefa não lhe pertence!";
                    }


                }
                else
                {
                    textBox_Erros_Lst_DOING.Text = "- Retire as tarefas com maior ordem primeiro!";
                }
            }
            else
            {
                textBox_Erros_Lst_DOING.Text = "- Selecione alguma tarefa!";
            }


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btSetDone_Click(object sender, EventArgs e)
        {
            textBox_Erros_Lst_DOING.Clear();
            textBox_Erros_Lst_TODO.Clear();
            textBox_Erros_Lst_DONE.Clear();
            textBox_Erros_Lst_DOING.ForeColor = Color.Red;


            var kanbancontroller = new KanbanController();
            var tarefaselecionada = lstDoing.SelectedItem as Tarefa;
            
            if(tarefaselecionada != null)
            {
                Tarefa MenorOrdem = kanbancontroller.TarefaMenorOrdemDoUtilizadorNODOING(utilizador, tarefaselecionada);

                if (MenorOrdem == null) {
                    textBox_Erros_Lst_DOING.Text = "- Não é o responsável pela Tarefa!";
                    return;
                }
                else
                {
                    if (tarefaselecionada.OrdemExecucao == MenorOrdem.OrdemExecucao)
                    {
                        DateTime DataDeRealFim = DateTime.Now;
                        kanbancontroller.AlterarEstadoTarefaDone(tarefaselecionada, utilizador, DataDeRealFim);


                        ListaTarefasDoing = kanbancontroller.VerificarEstadoDoing();
                        ListaTarefasDone = kanbancontroller.VerificarEstadoDone();

                        lstDone.DataSource = null;
                        lstDone.DataSource = ListaTarefasDone;
                        lstDoing.DataSource = null;
                        lstDoing.DataSource = ListaTarefasDoing;

                        textBox_Erros_Lst_DONE.ForeColor = Color.Green;
                        textBox_Erros_Lst_DOING.ForeColor = Color.Green;

                        textBox_Erros_Lst_DOING.Text = "- A " + tarefaselecionada.OrdemExecucao + "º Tarefa de " + tarefaselecionada.Programador.Nome + " foi movida! (Done)";
                        textBox_Erros_Lst_DONE.Text = "- A " + tarefaselecionada.OrdemExecucao + "º Tarefa de " + tarefaselecionada.Programador.Nome + " foi concluida!";

                    }
                    else
                    {
                        textBox_Erros_Lst_DOING.Text = "- Conclua outras tarefas para completar esta!";
                    }
                }

            }
            else
            {
                textBox_Erros_Lst_DOING.Text = "- Selecione alguma tarefa!";
            }


        }

        private void lstDone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_Erros_Lst_DONE.Clear();
            textBox_Erros_Lst_DONE.ForeColor = Color.Red;
            if (!ExecutarDetalhesTarefa(lstDone))
            {
                textBox_Erros_Lst_DONE.Text = "- Selecione uma tarefa para ver os detalhes!";
            }
            
        }

        private void lstDoing_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_Erros_Lst_DOING.Clear();
            textBox_Erros_Lst_DOING.ForeColor = Color.Red;
            if (!ExecutarDetalhesTarefa(lstDoing))
            {
                textBox_Erros_Lst_DOING.Text = "- Selecione uma tarefa para ver os detalhes!";
            }
            
        }

        private void lstTodo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_Erros_Lst_TODO.Clear(); 
            textBox_Erros_Lst_TODO.ForeColor = Color.Red;
            if (!ExecutarDetalhesTarefa(lstTodo))
            {
                textBox_Erros_Lst_TODO.Text = "- Selecione uma tarefa para ver os detalhes!";
            }
        }
        private bool ExecutarDetalhesTarefa(ListBox lstbox)
        {
            var tarefaselecionada = lstbox.SelectedItem as Tarefa;
            if(tarefaselecionada != null)
            {
                this.Hide();
                frmDetalhesTarefa frmDetalhesTarefa = new frmDetalhesTarefa(utilizador, tarefaselecionada);
                frmDetalhesTarefa.Show();
                return true;
            }
            else
            {
                return false;
            }

        }

        private void exportarParaCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FileStream TarefasDoneDados = new FileStream("C:/Users/migue/source/repos/PASTA DEFENITIVA DO PROJETO/Projeto_De_Aplicacoes/CSVDadosTaredasDone.csv", FileMode.Create, FileAccess.Write);
            StreamWriter escrever_dados_tarefas_done = new StreamWriter(TarefasDoneDados);

            escrever_dados_tarefas_done.WriteLine("Programador;Descricao;DataPrevistaInicio;DataPrevistaFim;TipoTarefa;DataRealInicio;DataRealFim");
            foreach (var TarefasDone in ListaTarefasDone)
            {
                escrever_dados_tarefas_done.WriteLine(TarefasDone.Programador+";"+TarefasDone.Descricao+";"+TarefasDone.DataPrevistoInicio+";"+TarefasDone.DataPrevistoFim+";"+TarefasDone.TipoTarefa+";"+TarefasDone.DataRealInicio+";"+TarefasDone.DataRealFim+";");
            }
            textBox_Aviso_ExportarCSV.Text = "As tarefas concluídas foram exportadas para o ficheiro .CSV, às " + DateTime.Now;


            escrever_dados_tarefas_done.Close();
            TarefasDoneDados.Close();
        }

        private void tarefasTerminadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultarTarefasConcluidas frmConcluidas = new frmConsultarTarefasConcluidas(utilizador);
            frmConcluidas.Show();
        }

        private void tarefasEmCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaTarefasEmCurso frmEmCurso = new frmConsultaTarefasEmCurso(utilizador);
            frmEmCurso.Show();
        }

        public void DetalhesTempoPorSP()
        {
            var kanbancontroller = new KanbanController();

            var popup = new Form()
            {
                Width = 300,
                Height = 200,
                Text = "Detalhes de Tempo de Tarefas",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            var txtTempo = new TextBox()
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true,
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.DimGray,
                BorderStyle = BorderStyle.None,
                ScrollBars = ScrollBars.Vertical
            };
            txtTempo.Text = "Selecione uma das opções acima!";

            var option1 = new ToolStripMenuItem("Horas");
            var option2 = new ToolStripMenuItem("Minutos");
            var option3 = new ToolStripMenuItem("Segundos");

            var MenuTempo = new MenuStrip();

            option1.Click += (sender, e) =>
            {
                var SP_Tempo = kanbancontroller.TarefasCalculo(ListaTarefasDone, ListaTarefasToDo, "horas");
                txtTempo.Text = "";
                if (SP_Tempo.Count <= 0)
                {
                    txtTempo.Text = "Sem tarefas no estado TODO ou Sem dados de tarefas realizadas para mostrar";
                }
                else
                {
                    txtTempo.Clear();
                    foreach (var kv in SP_Tempo)
                    {
                        txtTempo.AppendText($"SP {kv.Key}: {kv.Value} horas{Environment.NewLine}");
                    }
                }

            };

            option2.Click += (sender, e) =>
            {
                var SP_Tempo = kanbancontroller.TarefasCalculo(ListaTarefasDone, ListaTarefasToDo,  "minutos");
                txtTempo.Text = "";
                if (SP_Tempo.Count <= 0)
                {
                    txtTempo.Text = "Sem tarefas no estado TODO ou Sem dados de tarefas realizadas para mostrar";
                }
                else
                {
                    txtTempo.Clear();
                    foreach (var kv in SP_Tempo)
                    {
                        txtTempo.AppendText($"SP {kv.Key}: {kv.Value} minutos{Environment.NewLine}");
                    }
                }
            };

            option3.Click += (sender, e) =>
            {
                var SP_Tempo = kanbancontroller.TarefasCalculo(ListaTarefasDone, ListaTarefasToDo, "segundos");
                txtTempo.Text = "";
                if (SP_Tempo.Count <= 0)
                {
                    txtTempo.Text = "Sem tarefas no estado TODO ou Sem dados de tarefas realizadas para mostrar";
                }
                else
                {
                    txtTempo.Clear();
                    foreach (var kv in SP_Tempo)
                    {
                        txtTempo.AppendText($"SP {kv.Key}: {kv.Value} segundos{Environment.NewLine}");
                    }
                }

            };

            MenuTempo.Items.Add(option1);
            MenuTempo.Items.Add(option2);
            MenuTempo.Items.Add(option3);

            popup.MainMenuStrip = MenuTempo;
            popup.Controls.Add(txtTempo);     
            popup.Controls.Add(MenuTempo);    

            popup.ShowDialog();
        }

    }
}
