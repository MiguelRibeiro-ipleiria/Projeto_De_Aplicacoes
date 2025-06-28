# ITask

### **Elementos do Grupo – PL1-C**
- Guilherme Ferreira – 2241869  
- Miguel Ribeiro – 2241595  
- Rafael Campos – 2241594  

### **Instituição Responsável**
- IPL (ESTG)  
- TESP Tecnologias Informáticas

![Logo do IPL](Properties/DataSources/ued_h-01.png)

---

# Projeto

## 🎯 Objetivo da Aplicação
Esta aplicação permite a gestão de tarefas através do sistema Kanban, juntamente com a gestão de utilizadores (Gestores e Programadores), utilizando operações de CRUD.  
O desenvolvimento desta aplicação foi realizado no âmbito das UCs de **MDS (Metodologias de Desenvolvimento de Software)** e **DA (Desenvolvimento de Aplicações)**.

## ✅ Funcionalidades Incluídas
- Login e Logout de utilizadores (Gestores e Programadores).
- Criação, edição, leitura e eliminação de:
  - Utilizadores  
  - Tipos de Tarefas  
  - Tarefas  
- Sistema Kanban com restrições.
- Avaliação do tempo médio de tarefas por Sprint.
- Geração de ficheiro CSV para tarefas concluídas.
- Listagens de tarefas:
  - Concluídas  
  - Por concluir  

## 🛠️ Tecnologias Utilizadas
- Linguagens: **C#**, **SQL**
- IDE: **Visual Studio Code**
- Controlo de versões: **Git**

## 🧩 Composição do Projeto

### `Métodos Criados (4)`
- `Utilizador` (com subclasses `Gestor` e `Programador`)
- `TipoTarefa`
- `Tarefa`
- `OrganizacaoContext` (Base de Dados)

### `Controladores Criados (7)`
- `LoginController`
- `KanbanController`
- `TipoTarefaController`
- `TarefasController`
- `UserController`
- `TarefasConcluidasController`
- `TarefasEmCursoController`

### `Forms Criados (7)`
- `frmLogin`
- `frmKanban`
- `frmGereTipoTarefa`
- `frmDetalhesTarefa`
- `frmGereUtilizadores`
- `frmConsultarTarefasConcluidas`
- `frmConsultaTarefasEmCurso`

---

## ⚙️ Instruções para Executar o Projeto

Caso haja problemas ao executar o projeto:
1. Abrir o ficheiro `.sln` na pasta do projeto.
2. Clicar no botão de **Iniciar** no topo do Visual Studio Code.
3. Após a primeira interação com a aplicação (ex.: clicar num botão), esperar entre **3 a 5 segundos** para a inicialização completa.

---

