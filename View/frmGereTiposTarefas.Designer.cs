﻿namespace iTasks
{
    partial class frmGereTiposTarefas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.textBox_Erros_Tipos_De_Tarefas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLista);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(365, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Tipos de Tarefas";
            // 
            // lstLista
            // 
            this.lstLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(4, 19);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(357, 451);
            this.lstLista.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(479, 66);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(380, 22);
            this.txtDesc.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descrição:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(479, 34);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(81, 22);
            this.txtId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id:";
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(480, 137);
            this.btGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(185, 28);
            this.btGravar.TabIndex = 31;
            this.btGravar.Text = "Gravar Dados";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(769, 454);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 28);
            this.btEliminar.TabIndex = 34;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(661, 454);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // textBox_Erros_Tipos_De_Tarefas
            // 
            this.textBox_Erros_Tipos_De_Tarefas.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_Erros_Tipos_De_Tarefas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Erros_Tipos_De_Tarefas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Erros_Tipos_De_Tarefas.ForeColor = System.Drawing.Color.Red;
            this.textBox_Erros_Tipos_De_Tarefas.Location = new System.Drawing.Point(479, 95);
            this.textBox_Erros_Tipos_De_Tarefas.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Erros_Tipos_De_Tarefas.Multiline = true;
            this.textBox_Erros_Tipos_De_Tarefas.Name = "textBox_Erros_Tipos_De_Tarefas";
            this.textBox_Erros_Tipos_De_Tarefas.ReadOnly = true;
            this.textBox_Erros_Tipos_De_Tarefas.Size = new System.Drawing.Size(390, 34);
            this.textBox_Erros_Tipos_De_Tarefas.TabIndex = 36;
            // 
            // frmGereTiposTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 497);
            this.Controls.Add(this.textBox_Erros_Tipos_De_Tarefas);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGereTiposTarefas";
            this.Text = "frmGereTiposTarefas";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox textBox_Erros_Tipos_De_Tarefas;
    }
}