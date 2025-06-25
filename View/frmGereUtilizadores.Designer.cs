namespace iTasks
{
    partial class frmGereUtilizadores
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
            this.btGravarGestor = new System.Windows.Forms.Button();
            this.txtNomeGestor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdGestor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstListaGestores = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.Eliminar_Gestor = new System.Windows.Forms.Button();
            this.btLimparGestor = new System.Windows.Forms.Button();
            this.chkGereUtilizadores = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPasswordGestor = new System.Windows.Forms.TextBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameGestor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditarProg = new System.Windows.Forms.Button();
            this.Eliminar_Programador = new System.Windows.Forms.Button();
            this.button_Fechar = new System.Windows.Forms.Button();
            this.btLimparProg = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbGestorProg = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btGravarProg = new System.Windows.Forms.Button();
            this.txtPasswordProg = new System.Windows.Forms.TextBox();
            this.cbNivelProg = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsernameProg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstListaProgramadores = new System.Windows.Forms.ListBox();
            this.txtIdProg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeProg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_erros_programador = new System.Windows.Forms.TextBox();
            this.textBox_erros_gestor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGravarGestor
            // 
            this.btGravarGestor.Location = new System.Drawing.Point(391, 379);
            this.btGravarGestor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGravarGestor.Name = "btGravarGestor";
            this.btGravarGestor.Size = new System.Drawing.Size(268, 28);
            this.btGravarGestor.TabIndex = 37;
            this.btGravarGestor.Text = "Gravar Dados";
            this.btGravarGestor.UseVisualStyleBackColor = true;
            this.btGravarGestor.Click += new System.EventHandler(this.btGravarGestor_Click);
            // 
            // txtNomeGestor
            // 
            this.txtNomeGestor.Location = new System.Drawing.Point(392, 98);
            this.txtNomeGestor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeGestor.Name = "txtNomeGestor";
            this.txtNomeGestor.Size = new System.Drawing.Size(267, 22);
            this.txtNomeGestor.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nome:";
            // 
            // txtIdGestor
            // 
            this.txtIdGestor.Location = new System.Drawing.Point(392, 43);
            this.txtIdGestor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdGestor.Name = "txtIdGestor";
            this.txtIdGestor.ReadOnly = true;
            this.txtIdGestor.Size = new System.Drawing.Size(81, 22);
            this.txtIdGestor.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListaGestores);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(365, 560);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // lstListaGestores
            // 
            this.lstListaGestores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaGestores.FormattingEnabled = true;
            this.lstListaGestores.ItemHeight = 16;
            this.lstListaGestores.Location = new System.Drawing.Point(4, 19);
            this.lstListaGestores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaGestores.Name = "lstListaGestores";
            this.lstListaGestores.Size = new System.Drawing.Size(357, 537);
            this.lstListaGestores.TabIndex = 0;
            this.lstListaGestores.SelectedIndexChanged += new System.EventHandler(this.lstListaGestores_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_erros_gestor);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.Eliminar_Gestor);
            this.groupBox2.Controls.Add(this.btLimparGestor);
            this.groupBox2.Controls.Add(this.chkGereUtilizadores);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btGravarGestor);
            this.groupBox2.Controls.Add(this.txtPasswordGestor);
            this.groupBox2.Controls.Add(this.cbDepartamento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUsernameGestor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtIdGestor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNomeGestor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(681, 591);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestores";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(391, 480);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(268, 28);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditarGestor_Click);
            // 
            // Eliminar_Gestor
            // 
            this.Eliminar_Gestor.Location = new System.Drawing.Point(391, 412);
            this.Eliminar_Gestor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminar_Gestor.Name = "Eliminar_Gestor";
            this.Eliminar_Gestor.Size = new System.Drawing.Size(268, 28);
            this.Eliminar_Gestor.TabIndex = 48;
            this.Eliminar_Gestor.Text = "Eliminar Gestor";
            this.Eliminar_Gestor.UseVisualStyleBackColor = true;
            this.Eliminar_Gestor.Click += new System.EventHandler(this.Eliminar_Gestor_Click);
            // 
            // btLimparGestor
            // 
            this.btLimparGestor.Location = new System.Drawing.Point(391, 446);
            this.btLimparGestor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimparGestor.Name = "btLimparGestor";
            this.btLimparGestor.Size = new System.Drawing.Size(268, 28);
            this.btLimparGestor.TabIndex = 44;
            this.btLimparGestor.Text = "Limpar Dados";
            this.btLimparGestor.UseVisualStyleBackColor = true;
            this.btLimparGestor.Click += new System.EventHandler(this.btLimparGestor_Click);
            // 
            // chkGereUtilizadores
            // 
            this.chkGereUtilizadores.AutoSize = true;
            this.chkGereUtilizadores.Location = new System.Drawing.Point(392, 303);
            this.chkGereUtilizadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkGereUtilizadores.Name = "chkGereUtilizadores";
            this.chkGereUtilizadores.Size = new System.Drawing.Size(133, 20);
            this.chkGereUtilizadores.TabIndex = 43;
            this.chkGereUtilizadores.Text = "Gere Utilizadores";
            this.chkGereUtilizadores.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Departamento:";
            // 
            // txtPasswordGestor
            // 
            this.txtPasswordGestor.Location = new System.Drawing.Point(392, 196);
            this.txtPasswordGestor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordGestor.Name = "txtPasswordGestor";
            this.txtPasswordGestor.Size = new System.Drawing.Size(267, 22);
            this.txtPasswordGestor.TabIndex = 40;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(392, 250);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(267, 24);
            this.cbDepartamento.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // txtUsernameGestor
            // 
            this.txtUsernameGestor.Location = new System.Drawing.Point(392, 146);
            this.txtUsernameGestor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameGestor.Name = "txtUsernameGestor";
            this.txtUsernameGestor.Size = new System.Drawing.Size(267, 22);
            this.txtUsernameGestor.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Username:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_erros_programador);
            this.groupBox3.Controls.Add(this.btnEditarProg);
            this.groupBox3.Controls.Add(this.Eliminar_Programador);
            this.groupBox3.Controls.Add(this.button_Fechar);
            this.groupBox3.Controls.Add(this.btLimparProg);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbGestorProg);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btGravarProg);
            this.groupBox3.Controls.Add(this.txtPasswordProg);
            this.groupBox3.Controls.Add(this.cbNivelProg);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtUsernameProg);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtIdProg);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtNomeProg);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(705, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(681, 591);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Programadores";
            // 
            // btnEditarProg
            // 
            this.btnEditarProg.Location = new System.Drawing.Point(391, 480);
            this.btnEditarProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarProg.Name = "btnEditarProg";
            this.btnEditarProg.Size = new System.Drawing.Size(268, 28);
            this.btnEditarProg.TabIndex = 50;
            this.btnEditarProg.Text = "Editar";
            this.btnEditarProg.UseVisualStyleBackColor = true;
            this.btnEditarProg.Click += new System.EventHandler(this.btnEditarProg_Click);
            // 
            // Eliminar_Programador
            // 
            this.Eliminar_Programador.Location = new System.Drawing.Point(391, 414);
            this.Eliminar_Programador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminar_Programador.Name = "Eliminar_Programador";
            this.Eliminar_Programador.Size = new System.Drawing.Size(268, 28);
            this.Eliminar_Programador.TabIndex = 49;
            this.Eliminar_Programador.Text = "Eliminar Programador";
            this.Eliminar_Programador.UseVisualStyleBackColor = true;
            this.Eliminar_Programador.Click += new System.EventHandler(this.Eliminar_Programador_Click);
            // 
            // button_Fechar
            // 
            this.button_Fechar.Location = new System.Drawing.Point(573, 540);
            this.button_Fechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Fechar.Name = "button_Fechar";
            this.button_Fechar.Size = new System.Drawing.Size(101, 39);
            this.button_Fechar.TabIndex = 46;
            this.button_Fechar.Text = "Fechar";
            this.button_Fechar.UseVisualStyleBackColor = true;
            this.button_Fechar.Click += new System.EventHandler(this.button_Fechar_Click);
            // 
            // btLimparProg
            // 
            this.btLimparProg.Location = new System.Drawing.Point(391, 446);
            this.btLimparProg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimparProg.Name = "btLimparProg";
            this.btLimparProg.Size = new System.Drawing.Size(268, 28);
            this.btLimparProg.TabIndex = 45;
            this.btLimparProg.Text = "Limpar Dados";
            this.btLimparProg.UseVisualStyleBackColor = true;
            this.btLimparProg.Click += new System.EventHandler(this.btLimparProg_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 283);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Gestor:";
            // 
            // cbGestorProg
            // 
            this.cbGestorProg.FormattingEnabled = true;
            this.cbGestorProg.Location = new System.Drawing.Point(392, 303);
            this.cbGestorProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGestorProg.Name = "cbGestorProg";
            this.cbGestorProg.Size = new System.Drawing.Size(267, 24);
            this.cbGestorProg.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nível de Experiência:";
            // 
            // btGravarProg
            // 
            this.btGravarProg.Location = new System.Drawing.Point(391, 379);
            this.btGravarProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGravarProg.Name = "btGravarProg";
            this.btGravarProg.Size = new System.Drawing.Size(268, 28);
            this.btGravarProg.TabIndex = 37;
            this.btGravarProg.Text = "Gravar Dados";
            this.btGravarProg.UseVisualStyleBackColor = true;
            this.btGravarProg.Click += new System.EventHandler(this.btGravarProg_Click);
            // 
            // txtPasswordProg
            // 
            this.txtPasswordProg.Location = new System.Drawing.Point(392, 196);
            this.txtPasswordProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordProg.Name = "txtPasswordProg";
            this.txtPasswordProg.Size = new System.Drawing.Size(267, 22);
            this.txtPasswordProg.TabIndex = 40;
            // 
            // cbNivelProg
            // 
            this.cbNivelProg.FormattingEnabled = true;
            this.cbNivelProg.Location = new System.Drawing.Point(392, 250);
            this.cbNivelProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNivelProg.Name = "cbNivelProg";
            this.cbNivelProg.Size = new System.Drawing.Size(267, 24);
            this.cbNivelProg.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Password:";
            // 
            // txtUsernameProg
            // 
            this.txtUsernameProg.Location = new System.Drawing.Point(392, 146);
            this.txtUsernameProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernameProg.Name = "txtUsernameProg";
            this.txtUsernameProg.Size = new System.Drawing.Size(267, 22);
            this.txtUsernameProg.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Username:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstListaProgramadores);
            this.groupBox4.Location = new System.Drawing.Point(8, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(365, 560);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista";
            // 
            // lstListaProgramadores
            // 
            this.lstListaProgramadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaProgramadores.FormattingEnabled = true;
            this.lstListaProgramadores.ItemHeight = 16;
            this.lstListaProgramadores.Location = new System.Drawing.Point(4, 19);
            this.lstListaProgramadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaProgramadores.Name = "lstListaProgramadores";
            this.lstListaProgramadores.Size = new System.Drawing.Size(357, 537);
            this.lstListaProgramadores.TabIndex = 0;
            this.lstListaProgramadores.SelectedIndexChanged += new System.EventHandler(this.lstListaProgramadores_SelectedIndexChanged);
            // 
            // txtIdProg
            // 
            this.txtIdProg.Location = new System.Drawing.Point(392, 43);
            this.txtIdProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProg.Name = "txtIdProg";
            this.txtIdProg.ReadOnly = true;
            this.txtIdProg.Size = new System.Drawing.Size(81, 22);
            this.txtIdProg.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Id:";
            // 
            // txtNomeProg
            // 
            this.txtNomeProg.Location = new System.Drawing.Point(392, 98);
            this.txtNomeProg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeProg.Name = "txtNomeProg";
            this.txtNomeProg.Size = new System.Drawing.Size(267, 22);
            this.txtNomeProg.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Nome:";
            // 
            // textBox_erros_programador
            // 
            this.textBox_erros_programador.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_erros_programador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_erros_programador.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_erros_programador.ForeColor = System.Drawing.Color.Red;
            this.textBox_erros_programador.Location = new System.Drawing.Point(391, 335);
            this.textBox_erros_programador.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_erros_programador.Multiline = true;
            this.textBox_erros_programador.Name = "textBox_erros_programador";
            this.textBox_erros_programador.ReadOnly = true;
            this.textBox_erros_programador.Size = new System.Drawing.Size(283, 34);
            this.textBox_erros_programador.TabIndex = 51;
            // 
            // textBox_erros_gestor
            // 
            this.textBox_erros_gestor.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_erros_gestor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_erros_gestor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_erros_gestor.ForeColor = System.Drawing.Color.Red;
            this.textBox_erros_gestor.Location = new System.Drawing.Point(391, 335);
            this.textBox_erros_gestor.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_erros_gestor.Multiline = true;
            this.textBox_erros_gestor.Name = "textBox_erros_gestor";
            this.textBox_erros_gestor.ReadOnly = true;
            this.textBox_erros_gestor.Size = new System.Drawing.Size(290, 34);
            this.textBox_erros_gestor.TabIndex = 52;
            // 
            // frmGereUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGereUtilizadores";
            this.Text = "frmListaUtilizadores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGravarGestor;
        private System.Windows.Forms.TextBox txtNomeGestor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdGestor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstListaGestores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPasswordGestor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameGestor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkGereUtilizadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btGravarProg;
        private System.Windows.Forms.TextBox txtPasswordProg;
        private System.Windows.Forms.ComboBox cbNivelProg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsernameProg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstListaProgramadores;
        private System.Windows.Forms.TextBox txtIdProg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeProg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbGestorProg;
        private System.Windows.Forms.Button btLimparGestor;
        private System.Windows.Forms.Button btLimparProg;
        private System.Windows.Forms.Button button_Fechar;
        private System.Windows.Forms.Button Eliminar_Gestor;
        private System.Windows.Forms.Button Eliminar_Programador;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEditarProg;
        private System.Windows.Forms.TextBox textBox_erros_gestor;
        private System.Windows.Forms.TextBox textBox_erros_programador;
    }
}