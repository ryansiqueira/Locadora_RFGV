namespace GUI
{
    partial class frmCadastroCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDtNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1DsEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBuscarCpf = new System.Windows.Forms.Button();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 26);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(439, 22);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Nascimento:";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(161, 63);
            this.txtDtNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDtNascimento.Mask = "00/00/0000";
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(149, 22);
            this.txtDtNascimento.TabIndex = 4;
            this.txtDtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(161, 98);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(149, 22);
            this.txtCPF.TabIndex = 6;
            this.txtCPF.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(371, 187);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(149, 24);
            this.cbSexo.TabIndex = 8;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viuvo"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(161, 188);
            this.cbEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(149, 24);
            this.cbEstadoCivil.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado Civil:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(161, 145);
            this.txtRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(149, 22);
            this.txtRG.TabIndex = 12;
            this.txtRG.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "RG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(105, 25);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(415, 22);
            this.txtEndereco.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(105, 64);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 22);
            this.txtCidade.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(284, 64);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(43, 22);
            this.txtEstado.TabIndex = 17;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(391, 64);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCep.Mask = "00 000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(129, 22);
            this.txtCep.TabIndex = 20;
            this.txtCep.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "CEP:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(105, 103);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(149, 22);
            this.txtTelefone.TabIndex = 22;
            this.txtTelefone.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefone:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(369, 103);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Mask = "(00) 0 0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(149, 22);
            this.txtCelular.TabIndex = 24;
            this.txtCelular.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Celular:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 145);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 22);
            this.txtEmail.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(105, 187);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(149, 24);
            this.cbStatus.TabIndex = 28;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(1029, 254);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCpf);
            this.groupBox1.Controls.Add(this.btnBuscarCodigo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDtNascimento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbEstadoCivil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 235);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtCep);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(588, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 235);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnCPF,
            this.ColumnStatus,
            this.ColumnEditar,
            this.ColumnExcluir,
            this.ColumnDtNascimento,
            this.ColumnSexo,
            this.Column1DsEstadoCivil,
            this.Column1RG,
            this.Column1Endereco,
            this.Column1Cidade,
            this.Column1CEP,
            this.Column1Estado,
            this.Column1Telefone,
            this.Column1Email,
            this.Column1Celular});
            this.dgvCliente.Location = new System.Drawing.Point(5, 306);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1124, 412);
            this.dgvCliente.TabIndex = 32;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(921, 254);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(392, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 22);
            this.txtCodigo.TabIndex = 34;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "CdCliente";
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "NmCliente";
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.DataPropertyName = "CPF";
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.MinimumWidth = 6;
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            this.ColumnCPF.Width = 125;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.DataPropertyName = "DsStatus";
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 6;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Width = 125;
            // 
            // ColumnEditar
            // 
            this.ColumnEditar.HeaderText = "Editar";
            this.ColumnEditar.MinimumWidth = 6;
            this.ColumnEditar.Name = "ColumnEditar";
            this.ColumnEditar.ReadOnly = true;
            this.ColumnEditar.Text = "Editar";
            this.ColumnEditar.UseColumnTextForButtonValue = true;
            this.ColumnEditar.Width = 125;
            // 
            // ColumnExcluir
            // 
            this.ColumnExcluir.HeaderText = "Excluir";
            this.ColumnExcluir.MinimumWidth = 6;
            this.ColumnExcluir.Name = "ColumnExcluir";
            this.ColumnExcluir.ReadOnly = true;
            this.ColumnExcluir.Text = "Excluir";
            this.ColumnExcluir.UseColumnTextForButtonValue = true;
            this.ColumnExcluir.Width = 125;
            // 
            // ColumnDtNascimento
            // 
            this.ColumnDtNascimento.DataPropertyName = "DtNascimento";
            this.ColumnDtNascimento.HeaderText = "DtNascimento";
            this.ColumnDtNascimento.MinimumWidth = 6;
            this.ColumnDtNascimento.Name = "ColumnDtNascimento";
            this.ColumnDtNascimento.ReadOnly = true;
            this.ColumnDtNascimento.Visible = false;
            this.ColumnDtNascimento.Width = 125;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.DataPropertyName = "Sexo";
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.MinimumWidth = 6;
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            this.ColumnSexo.Visible = false;
            this.ColumnSexo.Width = 125;
            // 
            // Column1DsEstadoCivil
            // 
            this.Column1DsEstadoCivil.DataPropertyName = "DsEstadoCivil";
            this.Column1DsEstadoCivil.HeaderText = "DsEstadoCivil";
            this.Column1DsEstadoCivil.MinimumWidth = 6;
            this.Column1DsEstadoCivil.Name = "Column1DsEstadoCivil";
            this.Column1DsEstadoCivil.ReadOnly = true;
            this.Column1DsEstadoCivil.Visible = false;
            this.Column1DsEstadoCivil.Width = 125;
            // 
            // Column1RG
            // 
            this.Column1RG.DataPropertyName = "RG";
            this.Column1RG.HeaderText = "RG";
            this.Column1RG.MinimumWidth = 6;
            this.Column1RG.Name = "Column1RG";
            this.Column1RG.ReadOnly = true;
            this.Column1RG.Visible = false;
            this.Column1RG.Width = 125;
            // 
            // Column1Endereco
            // 
            this.Column1Endereco.DataPropertyName = "Endereco";
            this.Column1Endereco.HeaderText = "Endereco";
            this.Column1Endereco.MinimumWidth = 6;
            this.Column1Endereco.Name = "Column1Endereco";
            this.Column1Endereco.ReadOnly = true;
            this.Column1Endereco.Visible = false;
            this.Column1Endereco.Width = 125;
            // 
            // Column1Cidade
            // 
            this.Column1Cidade.DataPropertyName = "Cidade";
            this.Column1Cidade.HeaderText = "Cidade";
            this.Column1Cidade.MinimumWidth = 6;
            this.Column1Cidade.Name = "Column1Cidade";
            this.Column1Cidade.ReadOnly = true;
            this.Column1Cidade.Visible = false;
            this.Column1Cidade.Width = 125;
            // 
            // Column1CEP
            // 
            this.Column1CEP.DataPropertyName = "CEP";
            this.Column1CEP.HeaderText = "CEP";
            this.Column1CEP.MinimumWidth = 6;
            this.Column1CEP.Name = "Column1CEP";
            this.Column1CEP.ReadOnly = true;
            this.Column1CEP.Visible = false;
            this.Column1CEP.Width = 125;
            // 
            // Column1Estado
            // 
            this.Column1Estado.DataPropertyName = "Estado";
            this.Column1Estado.HeaderText = "Estado";
            this.Column1Estado.MinimumWidth = 6;
            this.Column1Estado.Name = "Column1Estado";
            this.Column1Estado.ReadOnly = true;
            this.Column1Estado.Visible = false;
            this.Column1Estado.Width = 125;
            // 
            // Column1Telefone
            // 
            this.Column1Telefone.DataPropertyName = "Telefone";
            this.Column1Telefone.HeaderText = "Telefone";
            this.Column1Telefone.MinimumWidth = 6;
            this.Column1Telefone.Name = "Column1Telefone";
            this.Column1Telefone.ReadOnly = true;
            this.Column1Telefone.Visible = false;
            this.Column1Telefone.Width = 125;
            // 
            // Column1Email
            // 
            this.Column1Email.DataPropertyName = "Email";
            this.Column1Email.HeaderText = "Email";
            this.Column1Email.MinimumWidth = 6;
            this.Column1Email.Name = "Column1Email";
            this.Column1Email.ReadOnly = true;
            this.Column1Email.Visible = false;
            this.Column1Email.Width = 125;
            // 
            // Column1Celular
            // 
            this.Column1Celular.DataPropertyName = "Celular";
            this.Column1Celular.HeaderText = "Celular";
            this.Column1Celular.MinimumWidth = 6;
            this.Column1Celular.Name = "Column1Celular";
            this.Column1Celular.ReadOnly = true;
            this.Column1Celular.Visible = false;
            this.Column1Celular.Width = 125;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(330, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Codigo:";
            // 
            // btnBuscarCpf
            // 
            this.btnBuscarCpf.Location = new System.Drawing.Point(317, 98);
            this.btnBuscarCpf.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCpf.Name = "btnBuscarCpf";
            this.btnBuscarCpf.Size = new System.Drawing.Size(48, 22);
            this.btnBuscarCpf.TabIndex = 34;
            this.btnBuscarCpf.Text = "...";
            this.btnBuscarCpf.UseVisualStyleBackColor = true;
            this.btnBuscarCpf.Click += new System.EventHandler(this.btnBuscarCpf_Click);
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(527, 64);
            this.btnBuscarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(43, 22);
            this.btnBuscarCodigo.TabIndex = 35;
            this.btnBuscarCodigo.Text = "...";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 744);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadastroCliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDtNascimento;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDtNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1DsEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Celular;
        private System.Windows.Forms.Button btnBuscarCpf;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Label label15;
    }
}