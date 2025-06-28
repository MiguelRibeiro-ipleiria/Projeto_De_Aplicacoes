# ITask

**`Elementos do Grupo -> PL1-C`**
 - Guilherme Ferreira - 2241869
 - Miguel Ribeiro - 2241595
 - Rafael Campos - 2241594
   
**`Instituição responsável`**
 - IPL (ESTG)
 - TESP Tecnologias Informáticas

<img src="https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.wikipedia.org%2Fwiki%2FFicheiro%3ALog%25C3%25B3tipo_Polit%25C3%25A9cnico_Leiria_01.png&psig=AOvVaw0IY2sprCNN6i5WelBkiaES&ust=1751231273804000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDGm4GDlY4DFQAAAAAdAAAAABAE" alt="Logo do IPL" width="50">

------------------------------------------------------------------------------------------------------
# Projeto

## Objetivo da Aplicação
Esta aplicação permite a gestão de tarefas pelo sistema Kanban, juntamente com a gestão de utilizadores (Gestores e Programadores) e as tarefas apartir de um CRUD. O desenvolvimento desta aplicação foi realizado para cumprir a entrega de um projeto para a UC de MDS (Metodologias de Desenvolvimento de Software) e DA (Desenvolvimento de Aplicações).

## Funcionalidades incluídas no Projeto 
 - Login e Logout de utilizadores (Gestores e Programadores).
 - Criação, Edição, Leitura e Eleminação de Utilizadores, Tipos de Tarefas e Tarefas.
 - Sistema Kanban com restrições.
 - Avaliação do tempo médio de tarefas por SP.
 - Criação de ficheiro CSV para tarefas concluídas.
 - Listagens de Tarefas Concluídas e por concluir.


## Aplicações / Tecnlogias 
 - Em c#, sql
 - Visual Code
 - Git

## Composição do Projeto 

**` Metodos Criados (4)`**
 - Utilizador, com subclasses "Gestor" e "Programador"
 - TipoTarefa
 - Tarefa
 - OrganizacaoContex (Base de Dados)

**` Controladores Criados (7)`**
 - LoginController
 - KanbanController
 - TipoTarefaController
 - TarefasController
 - UserController
 - TarefasConcluidasController
 - TarefasEmCursoController

**` Forms Criados (7)`**
 - frmLogin
 - frmKanban
 - frmGereTipoTarefa
 - frmDetalhesTarefa
 - frmGereUtilizadores
 - frmConsultarTarefasConcluidas
 - frmConsultaTarefasEmCurso


Caso haja problemas a dar run ao projeto
 - Executar o .sln da pasta do projeto
 - Clicar no botão de iniciar no topo do visual code
 - Esperar cerca de 3, 4 ou ate 5 segundos após a primeira interação com a aplicação (pressionar num botão)
   
