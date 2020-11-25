namespace GUI
{
    partial class frmLocacao
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
            this.ckbRecebido = new System.Windows.Forms.CheckBox();
            this.btnBuscaLoca = new System.Windows.Forms.Button();
            this.txtCPFFunc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNmFuncionario = new System.Windows.Forms.TextBox();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataAtual = new System.Windows.Forms.DateTimePicker();
            this.txtCdLocacao = new System.Windows.Forms.TextBox();
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVlRecebido = new System.Windows.Forms.TextBox();
            this.lblValorReceb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCdItem = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnAddDGV = new System.Windows.Forms.Button();
            this.btnBuscarBarras = new System.Windows.Forms.Button();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dtpDataPre = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVlTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVlUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.Button();
            this.btnAdicionarLocacao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbRecebido);
            this.groupBox1.Controls.Add(this.btnBuscaLoca);
            this.groupBox1.Controls.Add(this.txtCPFFunc);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNmFuncionario);
            this.groupBox1.Controls.Add(this.txtFunc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpDataAtual);
            this.groupBox1.Controls.Add(this.txtCdLocacao);
            this.groupBox1.Controls.Add(this.txtCPFCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.txtCdCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabeçalho";
            // 
            // ckbRecebido
            // 
            this.ckbRecebido.AutoSize = true;
            this.ckbRecebido.Enabled = false;
            this.ckbRecebido.Location = new System.Drawing.Point(20, 186);
            this.ckbRecebido.Name = "ckbRecebido";
            this.ckbRecebido.Size = new System.Drawing.Size(90, 21);
            this.ckbRecebido.TabIndex = 37;
            this.ckbRecebido.Text = "Recebido";
            this.ckbRecebido.UseVisualStyleBackColor = true;
            // 
            // btnBuscaLoca
            // 
            this.btnBuscaLoca.Location = new System.Drawing.Point(306, 13);
            this.btnBuscaLoca.Name = "btnBuscaLoca";
            this.btnBuscaLoca.Size = new System.Drawing.Size(82, 33);
            this.btnBuscaLoca.TabIndex = 36;
            this.btnBuscaLoca.Text = "Buscar";
            this.btnBuscaLoca.UseVisualStyleBackColor = true;
            this.btnBuscaLoca.Click += new System.EventHandler(this.btnBuscaLoca_Click);
            // 
            // txtCPFFunc
            // 
            this.txtCPFFunc.Enabled = false;
            this.txtCPFFunc.Location = new System.Drawing.Point(101, 131);
            this.txtCPFFunc.Name = "txtCPFFunc";
            this.txtCPFFunc.Size = new System.Drawing.Size(322, 22);
            this.txtCPFFunc.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "CPF Func:";
            // 
            // txtNmFuncionario
            // 
            this.txtNmFuncionario.Enabled = false;
            this.txtNmFuncionario.Location = new System.Drawing.Point(157, 103);
            this.txtNmFuncionario.Name = "txtNmFuncionario";
            this.txtNmFuncionario.Size = new System.Drawing.Size(266, 22);
            this.txtNmFuncionario.TabIndex = 16;
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(101, 103);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(50, 22);
            this.txtFunc.TabIndex = 15;
            this.txtFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFunc_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Funcionário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data Atual:";
            // 
            // dtpDataAtual
            // 
            this.dtpDataAtual.Location = new System.Drawing.Point(101, 158);
            this.dtpDataAtual.Name = "dtpDataAtual";
            this.dtpDataAtual.Size = new System.Drawing.Size(322, 22);
            this.dtpDataAtual.TabIndex = 5;
            // 
            // txtCdLocacao
            // 
            this.txtCdLocacao.Location = new System.Drawing.Point(101, 20);
            this.txtCdLocacao.Name = "txtCdLocacao";
            this.txtCdLocacao.Size = new System.Drawing.Size(199, 22);
            this.txtCdLocacao.TabIndex = 0;
            this.txtCdLocacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCdLocacao_KeyPress);
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Enabled = false;
            this.txtCPFCliente.Location = new System.Drawing.Point(101, 77);
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(322, 22);
            this.txtCPFCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "CPF Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(157, 49);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(266, 22);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.Location = new System.Drawing.Point(101, 49);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.Size = new System.Drawing.Size(50, 22);
            this.txtCdCliente.TabIndex = 1;
            this.txtCdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCdCliente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Locação:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVlRecebido);
            this.groupBox2.Controls.Add(this.lblValorReceb);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCdItem);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Controls.Add(this.btnAddDGV);
            this.groupBox2.Controls.Add(this.btnBuscarBarras);
            this.groupBox2.Controls.Add(this.cbPagamento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCodigoBarras);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvItens);
            this.groupBox2.Controls.Add(this.dtpDataPre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtVlTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtVlUnitario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 541);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens";
            // 
            // txtVlRecebido
            // 
            this.txtVlRecebido.Location = new System.Drawing.Point(350, 496);
            this.txtVlRecebido.Name = "txtVlRecebido";
            this.txtVlRecebido.Size = new System.Drawing.Size(98, 22);
            this.txtVlRecebido.TabIndex = 36;
            this.txtVlRecebido.Visible = false;
            // 
            // lblValorReceb
            // 
            this.lblValorReceb.AutoSize = true;
            this.lblValorReceb.Location = new System.Drawing.Point(238, 499);
            this.lblValorReceb.Name = "lblValorReceb";
            this.lblValorReceb.Size = new System.Drawing.Size(109, 17);
            this.lblValorReceb.TabIndex = 37;
            this.lblValorReceb.Text = "Valor Recebido:";
            this.lblValorReceb.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Titulo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Código";
            // 
            // txtCdItem
            // 
            this.txtCdItem.Enabled = false;
            this.txtCdItem.Location = new System.Drawing.Point(6, 45);
            this.txtCdItem.Name = "txtCdItem";
            this.txtCdItem.Size = new System.Drawing.Size(169, 22);
            this.txtCdItem.TabIndex = 33;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(181, 45);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(267, 22);
            this.txtTitulo.TabIndex = 32;
            // 
            // btnAddDGV
            // 
            this.btnAddDGV.Location = new System.Drawing.Point(331, 145);
            this.btnAddDGV.Name = "btnAddDGV";
            this.btnAddDGV.Size = new System.Drawing.Size(117, 33);
            this.btnAddDGV.TabIndex = 31;
            this.btnAddDGV.Text = "Adicionar Item";
            this.btnAddDGV.UseVisualStyleBackColor = true;
            this.btnAddDGV.Click += new System.EventHandler(this.btnAddDGV_Click);
            // 
            // btnBuscarBarras
            // 
            this.btnBuscarBarras.Location = new System.Drawing.Point(366, 80);
            this.btnBuscarBarras.Name = "btnBuscarBarras";
            this.btnBuscarBarras.Size = new System.Drawing.Size(82, 33);
            this.btnBuscarBarras.TabIndex = 16;
            this.btnBuscarBarras.Text = "Buscar";
            this.btnBuscarBarras.UseVisualStyleBackColor = true;
            this.btnBuscarBarras.Click += new System.EventHandler(this.btnBuscarBarras_Click);
            // 
            // cbPagamento
            // 
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Items.AddRange(new object[] {
            "--Selecione--",
            "Pago Total",
            "Pago Parcial",
            "Não Pago"});
            this.cbPagamento.Location = new System.Drawing.Point(13, 496);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(212, 24);
            this.cbPagamento.TabIndex = 12;
            this.cbPagamento.Text = "--Selecione--";
            this.cbPagamento.SelectedIndexChanged += new System.EventHandler(this.cbPagamento_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Código de barras:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(6, 90);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(354, 22);
            this.txtCodigoBarras.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Pagamento:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(6, 186);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.Size = new System.Drawing.Size(442, 265);
            this.dgvItens.TabIndex = 10;
            // 
            // dtpDataPre
            // 
            this.dtpDataPre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPre.Location = new System.Drawing.Point(331, 117);
            this.dtpDataPre.Name = "dtpDataPre";
            this.dtpDataPre.Size = new System.Drawing.Size(117, 22);
            this.dtpDataPre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data Prevista:";
            // 
            // txtVlTotal
            // 
            this.txtVlTotal.Enabled = false;
            this.txtVlTotal.Location = new System.Drawing.Point(350, 459);
            this.txtVlTotal.Name = "txtVlTotal";
            this.txtVlTotal.Size = new System.Drawing.Size(98, 22);
            this.txtVlTotal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Valor Total:";
            // 
            // txtVlUnitario
            // 
            this.txtVlUnitario.Enabled = false;
            this.txtVlUnitario.Location = new System.Drawing.Point(59, 134);
            this.txtVlUnitario.Name = "txtVlUnitario";
            this.txtVlUnitario.Size = new System.Drawing.Size(92, 22);
            this.txtVlUnitario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(193, 786);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 42);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Atualizar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(281, 786);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(82, 42);
            this.txtExcluir.TabIndex = 15;
            this.txtExcluir.Text = "Excluir";
            this.txtExcluir.UseVisualStyleBackColor = true;
            this.txtExcluir.Click += new System.EventHandler(this.txtExcluir_Click);
            // 
            // btnAdicionarLocacao
            // 
            this.btnAdicionarLocacao.Location = new System.Drawing.Point(105, 786);
            this.btnAdicionarLocacao.Name = "btnAdicionarLocacao";
            this.btnAdicionarLocacao.Size = new System.Drawing.Size(82, 42);
            this.btnAdicionarLocacao.TabIndex = 16;
            this.btnAdicionarLocacao.Text = "Efetivar Locação";
            this.btnAdicionarLocacao.UseVisualStyleBackColor = true;
            this.btnAdicionarLocacao.Click += new System.EventHandler(this.btnAdicionarLocacao_Click);
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 836);
            this.Controls.Add(this.btnAdicionarLocacao);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLocacao";
            this.Text = "Locação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataAtual;
        private System.Windows.Forms.TextBox txtCdLocacao;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DateTimePicker dtpDataPre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVlTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVlUnitario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button txtExcluir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.Button btnBuscarBarras;
        private System.Windows.Forms.TextBox txtCPFFunc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNmFuncionario;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddDGV;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCdItem;
        private System.Windows.Forms.Button btnBuscaLoca;
        private System.Windows.Forms.TextBox txtVlRecebido;
        private System.Windows.Forms.Label lblValorReceb;
        private System.Windows.Forms.CheckBox ckbRecebido;
        private System.Windows.Forms.Button btnAdicionarLocacao;
    }
}