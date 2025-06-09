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
    public partial class frmDetalhesTarefa : Form
    {
        List<TipoTarefa> listatipotarefas = new List<TipoTarefa>();
        List<Programador> listaprogramadores = new List<Programador>();
        private Utilizador utilizador;
        private Tarefa tarefa;

        public frmDetalhesTarefa(Utilizador utilizador, Tarefa TarefaPassada)
        {
            InitializeComponent();
            this.utilizador = utilizador;
            this.tarefa = TarefaPassada;

            InserirDadosNasCB();
            DetalhesTarefa(tarefa);
            VerificarGestorOuProgramador(utilizador);

        }

        private void btGravar_Click(object sender, EventArgs e)
        { 
            textBox_Erros.Clear();
            var tarefascontroller = new TarefasController();
            try
            {
                string descricao = txtDesc.Text;
                int storypoints = int.Parse(txtStoryPoints.Text);
                TipoTarefa tipotarefa = (TipoTarefa)cbTipoTarefa.SelectedItem;
                Programador programador = (Programador)cbProgramador.SelectedItem;
                EstadoAtual estadoatual = EstadoAtual.ToDo;
                DateTime DataDeCriacao = DateTime.Now;
                int ordemInc = int.Parse(txtOrdem.Text);
                DateTime datainicio = dtInicio.Value;
                DateTime datafim = dtFim.Value;

                if (TarefaCriada(tarefa) == true)
                {
                    bool isfibonnaci = tarefascontroller.VerificarNumeroFibonacci(storypoints);
                    if (isfibonnaci == true)
                    {
                        tarefascontroller.AlterarTarefa(tarefa, descricao, ordemInc, storypoints, tipotarefa, programador, datainicio, datafim, estadoatual, DataDeCriacao);
                        MessageBox.Show("Tarefa Alterada com Sucesso!");
                    }
                    else
                    {
                        textBox_Erros.AppendText("- StoryPoints incorretos (ex.: 1, 2, 3, 5, 8 ...)\n");
                    }
                }
                else
                {
                    bool isfibonnaci = tarefascontroller.VerificarNumeroFibonacci(storypoints);
                    bool iscorrectordem = tarefascontroller.OrdemRep(programador, ordemInc);
                    if (isfibonnaci == true)
                    {
                        if (iscorrectordem == true)
                        {
                            if (datainicio <= datafim)
                            {
                                tarefascontroller.AdicionarTarefa(descricao, ordemInc, storypoints, tipotarefa, programador, datainicio, datafim, estadoatual, DataDeCriacao);
                                MessageBox.Show("Tarefa Criada com Sucesso!");
                            }
                            else
                            {
                                textBox_Erros.AppendText("- Data Inválida (A data de fim tem de ser maior que a de inicio)\n");
                            }
                        }
                        else
                        {
                            textBox_Erros.AppendText("- Ordem em uso, altere a ordem da tarefa\n");
                        }
                    }
                    else
                    {
                        textBox_Erros.AppendText("- StoryPoints incorretos (ex.: 1, 2, 3, 5, 8 ...)\n");
                    }
                }
            }
            catch (FormatException)
            {
                textBox_Erros.AppendText("- Preencha todos os dados\n");
            }
            catch (Exception ex)
            {
                textBox_Erros.AppendText("- Erro: " + ex.Message + "\n");
            }
        }
        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKanban frmKanban = new frmKanban(utilizador);
            frmKanban.Show();
        }

        private void DetalhesTarefa(Tarefa Tarefa)
        {
            if (TarefaCriada(Tarefa) == true)
            {
                btGravar.Text = "Alterar Dados";

                txtOrdem.Text = Tarefa.OrdemExecucao.ToString();
                txtStoryPoints.Text = Tarefa.StoryPoints.ToString();
                txtDesc.Text = Tarefa.Descricao;
                cbProgramador.Text = Tarefa.Programador.ToString();
                cbTipoTarefa.Text = Tarefa.TipoTarefa.ToString();

                txtId.Text = Tarefa.Id.ToString();
                txtEstado.Text = Tarefa.EstadoAtual.ToString();
                txtDataCriacao.Text = Tarefa.DataCriacao.ToString();
                if (Tarefa.DataRealInicio == null)
                {
                    txtDataRealini.Text = "Dado Incompleto";
                }
                else
                {
                    txtDataRealini.Text = Tarefa.DataRealInicio.ToString();
                }
                if (Tarefa.DataRealFim == null)
                {
                    txtdataRealFim.Text = "Dado Incompleto";
                }
                else
                {
                    txtdataRealFim.Text = Tarefa.DataRealFim.ToString();
                }
            }
            else
            {
                btGravar.Text = "Criar Dados";

                txtOrdem.Text = null;
                txtStoryPoints.Text = null;
                txtDesc.Text = null;
                cbProgramador.Text = null;
                cbTipoTarefa.Text = null;
                txtId.Text = null;
                txtEstado.Text = null;
                txtDataCriacao.Text = null;
                txtDataRealini.Text = null;
                txtdataRealFim.Text = null;

                InserirDadosNasCB();
            }

           
        }

        private void InserirDadosNasCB()
        {
            var tarefascontroller = new TarefasController();
            var tipotarefascontroller = new TipoTarefaController();

            listaprogramadores = tarefascontroller.EnumararProgramadoresdosUsers(utilizador);
            listatipotarefas = tipotarefascontroller.MostrarTipoTarefa();

            cbProgramador.DataSource = null;
            cbProgramador.DataSource = listaprogramadores;

            cbTipoTarefa.DataSource = null;
            cbTipoTarefa.DataSource = listatipotarefas;
        }

        private void VerificarGestorOuProgramador(Utilizador utilizador)
        {
            var tarefascontroller = new TarefasController();
            bool isGestor = tarefascontroller.VerificarGestorOuProgramador(utilizador);
            RestrincoesAoProgramador(isGestor);
        }

        private void RestrincoesAoProgramador(bool IsGestor)
        {
            if (!IsGestor)
            {
                //É Programador
                txtDesc.Enabled = false;
                txtOrdem.Enabled = false;
                txtStoryPoints.Enabled = false;
                cbProgramador.Enabled = false;
                cbTipoTarefa.Enabled = false;
                dtFim.Enabled = false;
                dtInicio.Enabled = false;
                btGravar.Enabled = false;
            }
        }
        private void cbProgramador_SelectedIndexChanged(object sender, EventArgs e)
        {
            Programador programador = (Programador)cbProgramador.SelectedItem;

            if(programador == null)
            {

            }
            else
            {
                var tarefascontroller = new TarefasController();
                int ordemInc = tarefascontroller.IncrementarOrdem(programador);
                txtOrdem.Text = ordemInc.ToString();
            }
        }

        public bool TarefaCriada(Tarefa tarefa)
        {
            var tarefascontroller = new TarefasController();
            return tarefascontroller.IsTarefa(tarefa);
        }
    }
}
