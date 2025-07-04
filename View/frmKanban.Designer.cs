﻿namespace iTasks
{
    partial class frmKanban
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTodo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDoing = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirUtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirTiposDeTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasEmCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSetDoing = new System.Windows.Forms.Button();
            this.btSetDone = new System.Windows.Forms.Button();
            this.btSetTodo = new System.Windows.Forms.Button();
            this.btNova = new System.Windows.Forms.Button();
            this.label_NomeUser = new System.Windows.Forms.Label();
            this.btPrevisao = new System.Windows.Forms.Button();
            this.textBox_Erros_Lst_TODO = new System.Windows.Forms.TextBox();
            this.textBox_Erros_Lst_DOING = new System.Windows.Forms.TextBox();
            this.textBox_Erros_Lst_DONE = new System.Windows.Forms.TextBox();
            this.textBox_Aviso_ExportarCSV = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTodo
            // 
            this.lstTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTodo.FormattingEnabled = true;
            this.lstTodo.ItemHeight = 16;
            this.lstTodo.Location = new System.Drawing.Point(4, 19);
            this.lstTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTodo.Name = "lstTodo";
            this.lstTodo.Size = new System.Drawing.Size(395, 520);
            this.lstTodo.TabIndex = 0;
            this.lstTodo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTodo_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTodo);
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(403, 543);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ToDo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDoing);
            this.groupBox2.Location = new System.Drawing.Point(427, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(403, 543);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doing";
            // 
            // lstDoing
            // 
            this.lstDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDoing.FormattingEnabled = true;
            this.lstDoing.ItemHeight = 16;
            this.lstDoing.Location = new System.Drawing.Point(4, 19);
            this.lstDoing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDoing.Name = "lstDoing";
            this.lstDoing.Size = new System.Drawing.Size(395, 520);
            this.lstDoing.TabIndex = 0;
            this.lstDoing.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDoing_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDone);
            this.groupBox3.Location = new System.Drawing.Point(837, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(403, 543);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Done";
            // 
            // lstDone
            // 
            this.lstDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 16;
            this.lstDone.Location = new System.Drawing.Point(4, 19);
            this.lstDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(395, 520);
            this.lstDone.TabIndex = 0;
            this.lstDone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDone_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.utilizadoresToolStripMenuItem,
            this.listagensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1257, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.exportarParaCSVToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exportarParaCSVToolStripMenuItem
            // 
            this.exportarParaCSVToolStripMenuItem.Name = "exportarParaCSVToolStripMenuItem";
            this.exportarParaCSVToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.exportarParaCSVToolStripMenuItem.Text = "Exportar Tarefas Concluídas para CSV";
            this.exportarParaCSVToolStripMenuItem.Click += new System.EventHandler(this.exportarParaCSVToolStripMenuItem_Click);
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirUtilizadoresToolStripMenuItem,
            this.gerirTiposDeTarefasToolStripMenuItem});
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.ShowShortcutKeys = false;
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.utilizadoresToolStripMenuItem.Text = "Gestão da Aplicação";
            // 
            // gerirUtilizadoresToolStripMenuItem
            // 
            this.gerirUtilizadoresToolStripMenuItem.Name = "gerirUtilizadoresToolStripMenuItem";
            this.gerirUtilizadoresToolStripMenuItem.ShowShortcutKeys = false;
            this.gerirUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.gerirUtilizadoresToolStripMenuItem.Text = "Gerir Utilizadores";
            this.gerirUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.gerirUtilizadoresToolStripMenuItem_Click);
            // 
            // gerirTiposDeTarefasToolStripMenuItem
            // 
            this.gerirTiposDeTarefasToolStripMenuItem.Name = "gerirTiposDeTarefasToolStripMenuItem";
            this.gerirTiposDeTarefasToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.gerirTiposDeTarefasToolStripMenuItem.Text = "Gerir Tipos de Tarefas";
            this.gerirTiposDeTarefasToolStripMenuItem.Click += new System.EventHandler(this.gerirTiposDeTarefasToolStripMenuItem_Click);
            // 
            // listagensToolStripMenuItem
            // 
            this.listagensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarefasTerminadasToolStripMenuItem,
            this.tarefasEmCursoToolStripMenuItem});
            this.listagensToolStripMenuItem.Name = "listagensToolStripMenuItem";
            this.listagensToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.listagensToolStripMenuItem.Text = "Listagens";
            // 
            // tarefasTerminadasToolStripMenuItem
            // 
            this.tarefasTerminadasToolStripMenuItem.Name = "tarefasTerminadasToolStripMenuItem";
            this.tarefasTerminadasToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.tarefasTerminadasToolStripMenuItem.Text = "Tarefas Concluídas";
            this.tarefasTerminadasToolStripMenuItem.Click += new System.EventHandler(this.tarefasTerminadasToolStripMenuItem_Click);
            // 
            // tarefasEmCursoToolStripMenuItem
            // 
            this.tarefasEmCursoToolStripMenuItem.Name = "tarefasEmCursoToolStripMenuItem";
            this.tarefasEmCursoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.tarefasEmCursoToolStripMenuItem.Text = "Tarefas em Curso";
            this.tarefasEmCursoToolStripMenuItem.Click += new System.EventHandler(this.tarefasEmCursoToolStripMenuItem_Click);
            // 
            // btSetDoing
            // 
            this.btSetDoing.Location = new System.Drawing.Point(220, 656);
            this.btSetDoing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSetDoing.Name = "btSetDoing";
            this.btSetDoing.Size = new System.Drawing.Size(195, 28);
            this.btSetDoing.TabIndex = 5;
            this.btSetDoing.Text = "Executar Tarefa >>";
            this.btSetDoing.UseVisualStyleBackColor = true;
            this.btSetDoing.Click += new System.EventHandler(this.btSetDoing_Click);
            // 
            // btSetDone
            // 
            this.btSetDone.Location = new System.Drawing.Point(633, 656);
            this.btSetDone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSetDone.Name = "btSetDone";
            this.btSetDone.Size = new System.Drawing.Size(192, 28);
            this.btSetDone.TabIndex = 6;
            this.btSetDone.Text = "Terminar Tarefa >>";
            this.btSetDone.UseVisualStyleBackColor = true;
            this.btSetDone.Click += new System.EventHandler(this.btSetDone_Click);
            // 
            // btSetTodo
            // 
            this.btSetTodo.Location = new System.Drawing.Point(431, 656);
            this.btSetTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSetTodo.Name = "btSetTodo";
            this.btSetTodo.Size = new System.Drawing.Size(192, 28);
            this.btSetTodo.TabIndex = 7;
            this.btSetTodo.Text = "<< Reiniciar Tarefa";
            this.btSetTodo.UseVisualStyleBackColor = true;
            this.btSetTodo.Click += new System.EventHandler(this.btSetTodo_Click);
            // 
            // btNova
            // 
            this.btNova.Location = new System.Drawing.Point(20, 656);
            this.btNova.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNova.Name = "btNova";
            this.btNova.Size = new System.Drawing.Size(139, 28);
            this.btNova.TabIndex = 8;
            this.btNova.Text = "Nova Tarefa";
            this.btNova.UseVisualStyleBackColor = true;
            this.btNova.Click += new System.EventHandler(this.btNova_Click);
            // 
            // label_NomeUser
            // 
            this.label_NomeUser.AutoSize = true;
            this.label_NomeUser.Location = new System.Drawing.Point(1037, 42);
            this.label_NomeUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NomeUser.Name = "label_NomeUser";
            this.label_NomeUser.Size = new System.Drawing.Size(187, 16);
            this.label_NomeUser.TabIndex = 9;
            this.label_NomeUser.Text = "Bem vindo: <Nome Utilizador>";
            this.label_NomeUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btPrevisao
            // 
            this.btPrevisao.Location = new System.Drawing.Point(16, 36);
            this.btPrevisao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPrevisao.Name = "btPrevisao";
            this.btPrevisao.Size = new System.Drawing.Size(223, 28);
            this.btPrevisao.TabIndex = 10;
            this.btPrevisao.Text = "Ver Previsão de Conclusão";
            this.btPrevisao.UseVisualStyleBackColor = true;
            this.btPrevisao.Click += new System.EventHandler(this.btPrevisao_Click);
            // 
            // textBox_Erros_Lst_TODO
            // 
            this.textBox_Erros_Lst_TODO.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Erros_Lst_TODO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Erros_Lst_TODO.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Erros_Lst_TODO.ForeColor = System.Drawing.Color.Red;
            this.textBox_Erros_Lst_TODO.Location = new System.Drawing.Point(20, 614);
            this.textBox_Erros_Lst_TODO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Erros_Lst_TODO.Multiline = true;
            this.textBox_Erros_Lst_TODO.Name = "textBox_Erros_Lst_TODO";
            this.textBox_Erros_Lst_TODO.ReadOnly = true;
            this.textBox_Erros_Lst_TODO.Size = new System.Drawing.Size(395, 34);
            this.textBox_Erros_Lst_TODO.TabIndex = 33;
            // 
            // textBox_Erros_Lst_DOING
            // 
            this.textBox_Erros_Lst_DOING.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Erros_Lst_DOING.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Erros_Lst_DOING.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Erros_Lst_DOING.ForeColor = System.Drawing.Color.Red;
            this.textBox_Erros_Lst_DOING.Location = new System.Drawing.Point(431, 614);
            this.textBox_Erros_Lst_DOING.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Erros_Lst_DOING.Multiline = true;
            this.textBox_Erros_Lst_DOING.Name = "textBox_Erros_Lst_DOING";
            this.textBox_Erros_Lst_DOING.ReadOnly = true;
            this.textBox_Erros_Lst_DOING.Size = new System.Drawing.Size(395, 34);
            this.textBox_Erros_Lst_DOING.TabIndex = 34;
            // 
            // textBox_Erros_Lst_DONE
            // 
            this.textBox_Erros_Lst_DONE.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Erros_Lst_DONE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Erros_Lst_DONE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Erros_Lst_DONE.ForeColor = System.Drawing.Color.Red;
            this.textBox_Erros_Lst_DONE.Location = new System.Drawing.Point(841, 614);
            this.textBox_Erros_Lst_DONE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Erros_Lst_DONE.Multiline = true;
            this.textBox_Erros_Lst_DONE.Name = "textBox_Erros_Lst_DONE";
            this.textBox_Erros_Lst_DONE.ReadOnly = true;
            this.textBox_Erros_Lst_DONE.Size = new System.Drawing.Size(395, 34);
            this.textBox_Erros_Lst_DONE.TabIndex = 35;
            // 
            // textBox_Aviso_ExportarCSV
            // 
            this.textBox_Aviso_ExportarCSV.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Aviso_ExportarCSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Aviso_ExportarCSV.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Aviso_ExportarCSV.ForeColor = System.Drawing.Color.Green;
            this.textBox_Aviso_ExportarCSV.Location = new System.Drawing.Point(837, 648);
            this.textBox_Aviso_ExportarCSV.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Aviso_ExportarCSV.Multiline = true;
            this.textBox_Aviso_ExportarCSV.Name = "textBox_Aviso_ExportarCSV";
            this.textBox_Aviso_ExportarCSV.ReadOnly = true;
            this.textBox_Aviso_ExportarCSV.Size = new System.Drawing.Size(395, 36);
            this.textBox_Aviso_ExportarCSV.TabIndex = 36;
            // 
            // frmKanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 699);
            this.Controls.Add(this.textBox_Aviso_ExportarCSV);
            this.Controls.Add(this.textBox_Erros_Lst_DONE);
            this.Controls.Add(this.textBox_Erros_Lst_DOING);
            this.Controls.Add(this.textBox_Erros_Lst_TODO);
            this.Controls.Add(this.btPrevisao);
            this.Controls.Add(this.label_NomeUser);
            this.Controls.Add(this.btNova);
            this.Controls.Add(this.btSetTodo);
            this.Controls.Add(this.btSetDone);
            this.Controls.Add(this.btSetDoing);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKanban";
            this.Text = "frmKanban";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDoing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirUtilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirTiposDeTarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasTerminadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasEmCursoToolStripMenuItem;
        private System.Windows.Forms.Button btSetDoing;
        private System.Windows.Forms.Button btSetDone;
        private System.Windows.Forms.Button btSetTodo;
        private System.Windows.Forms.Button btNova;
        private System.Windows.Forms.Label label_NomeUser;
        private System.Windows.Forms.Button btPrevisao;
        private System.Windows.Forms.TextBox textBox_Erros_Lst_TODO;
        private System.Windows.Forms.TextBox textBox_Erros_Lst_DOING;
        private System.Windows.Forms.TextBox textBox_Erros_Lst_DONE;
        private System.Windows.Forms.TextBox textBox_Aviso_ExportarCSV;
    }
}