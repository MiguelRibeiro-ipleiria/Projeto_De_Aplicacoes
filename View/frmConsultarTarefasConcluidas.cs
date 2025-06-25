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
using static iTasks.Controller.TarefasConcluidasController;
using static iTasks.Controller.TarefasEmCursoController;

namespace iTasks
{
    public partial class frmConsultarTarefasConcluidas : Form
    {
        private List<Tarefa> ListConcluida = new List<Tarefa>();
        private List<AtributosSelecionadosDasTarefasConcluidasProgramador> ListConcluidaProgramadores = new List<AtributosSelecionadosDasTarefasConcluidasProgramador>();
        private List<AtributosSelecionadosDasTarefasConcluidasGestor> ListConcluidaGestores = new List<AtributosSelecionadosDasTarefasConcluidasGestor>();

        private Utilizador utilizadorLogado;

        public frmConsultarTarefasConcluidas(Utilizador utilizador)
        {
            InitializeComponent();
            utilizadorLogado = utilizador;
            bool isGestor = false;
            var KanBanController = new KanbanController();



            if (KanBanController.RestricoesUtilizador(utilizadorLogado))
            {
                isGestor = true;
            }
            else
            {
                isGestor = false;
            }

            MostrarTarefasConcluidas(isGestor, utilizadorLogado);


        }

        public void MostrarTarefasConcluidas(bool isGestor, Utilizador utilizador)
        {
            var consultasdone = new TarefasConcluidasController();
            ListConcluida = consultasdone.ConsularUtilizadorTarefasDone(isGestor, utilizador);

            if (isGestor == true)
            {
                //É GESTOR
                foreach (var Tarefa in ListConcluida)
                {
                    var Tempo_A_Concluir = (Tarefa.DataRealFim.Value - Tarefa.DataRealInicio.Value).TotalDays;
                    Tempo_A_Concluir = Math.Round(Tempo_A_Concluir, 0);

                    var Tempo_Previsto_A_Concluir = (Tarefa.DataPrevistoFim.Value - Tarefa.DataPrevistoInicio.Value).TotalDays;
                    Tempo_Previsto_A_Concluir = Math.Round(Tempo_Previsto_A_Concluir, 0);

                    ListConcluidaGestores.Add(new AtributosSelecionadosDasTarefasConcluidasGestor
                    {
                        Nome_Do_Programador = Tarefa.Programador.Nome,
                        Responsavel = Tarefa.Gestor.Nome,
                        Estado = Tarefa.EstadoAtual,
                        Descricao = Tarefa.Descricao,
                        Tipo_Da_Tarefa = Tarefa.TipoTarefa,
                        Story_Points = Tarefa.StoryPoints,
                        Tempo_Em_Dias = Tempo_A_Concluir + " Dias",
                        Tempo_Previsto_Em_Dias = Tempo_Previsto_A_Concluir + " Dias"

                    });

                    gvTarefasConcluidas.DataSource = null;
                    gvTarefasConcluidas.DataSource = ListConcluidaGestores;

                }
            }
            else
            {
                //É PROGRAMADOR
                foreach (var Tarefa in ListConcluida)
                {
                    var Tempo_A_Concluir = (Tarefa.DataRealFim.Value - Tarefa.DataRealInicio.Value).TotalDays;
                    Tempo_A_Concluir = Math.Round(Tempo_A_Concluir, 0);

                    ListConcluidaProgramadores.Add(new AtributosSelecionadosDasTarefasConcluidasProgramador
                    {
                        Nome_Do_Programador = Tarefa.Programador.Nome,
                        Responsavel = Tarefa.Gestor.Nome,
                        Estado = Tarefa.EstadoAtual,
                        Descricao = Tarefa.Descricao,
                        Tipo_Da_Tarefa = Tarefa.TipoTarefa,
                        Story_Points = Tarefa.StoryPoints,
                        Tempo_Em_Dias = Tempo_A_Concluir + " Dias"
                    });

                    gvTarefasConcluidas.DataSource = null;
                    gvTarefasConcluidas.DataSource = ListConcluidaProgramadores;

                }
            }

        }


        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKanban frmKanban = new frmKanban(utilizadorLogado);
            frmKanban.Show();
        }
    }
}
