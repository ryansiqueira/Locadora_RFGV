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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.cbItens = new System.Windows.Forms.ComboBox();
            this.btnAdicioanar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtExcluir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(454, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabeçalho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Data Atual:";
            // 
            // dtpDataAtual
            // 
            this.dtpDataAtual.Location = new System.Drawing.Point(101, 122);
            this.dtpDataAtual.Name = "dtpDataAtual";
            this.dtpDataAtual.Size = new System.Drawing.Size(322, 22);
            this.dtpDataAtual.TabIndex = 5;
            // 
            // txtCdLocacao
            // 
            this.txtCdLocacao.Location = new System.Drawing.Point(101, 37);
            this.txtCdLocacao.Name = "txtCdLocacao";
            this.txtCdLocacao.Size = new System.Drawing.Size(322, 22);
            this.txtCdLocacao.TabIndex = 0;
            this.txtCdLocacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCdLocacao_KeyPress);
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Enabled = false;
            this.txtCPFCliente.Location = new System.Drawing.Point(101, 94);
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(322, 22);
            this.txtCPFCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "CPF Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(157, 66);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(266, 22);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.Location = new System.Drawing.Point(101, 66);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.Size = new System.Drawing.Size(50, 22);
            this.txtCdCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Locação:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudQuantidade);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
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
            this.groupBox2.Controls.Add(this.cbItens);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 541);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Selecione--",
            "Pago Total",
            "Pago Parcial",
            "Não Pago"});
            this.comboBox1.Location = new System.Drawing.Point(28, 495);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "--Selecione--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Código de barras:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(6, 78);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(354, 22);
            this.txtCodigoBarras.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Pagamento:";
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Location = new System.Drawing.Point(6, 174);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.Size = new System.Drawing.Size(442, 265);
            this.dgvItens.TabIndex = 10;
            // 
            // dtpDataPre
            // 
            this.dtpDataPre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPre.Location = new System.Drawing.Point(331, 118);
            this.dtpDataPre.Name = "dtpDataPre";
            this.dtpDataPre.Size = new System.Drawing.Size(117, 22);
            this.dtpDataPre.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data Prevista:";
            // 
            // txtVlTotal
            // 
            this.txtVlTotal.Enabled = false;
            this.txtVlTotal.Location = new System.Drawing.Point(350, 447);
            this.txtVlTotal.Name = "txtVlTotal";
            this.txtVlTotal.Size = new System.Drawing.Size(98, 22);
            this.txtVlTotal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Valor Total:";
            // 
            // txtVlUnitario
            // 
            this.txtVlUnitario.Enabled = false;
            this.txtVlUnitario.Location = new System.Drawing.Point(59, 109);
            this.txtVlUnitario.Name = "txtVlUnitario";
            this.txtVlUnitario.Size = new System.Drawing.Size(92, 22);
            this.txtVlUnitario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor:";
            // 
            // cbItens
            // 
            this.cbItens.FormattingEnabled = true;
            this.cbItens.Items.AddRange(new object[] {
            "TESTE\t",
            "RYAN",
            "CLETO",
            "VIADO",
            "OLA",
            "VISH",
            "TI",
            "NOSSA",
            "CORAÇÃO",
            "BAROES"});
            this.cbItens.Location = new System.Drawing.Point(6, 32);
            this.cbItens.Name = "cbItens";
            this.cbItens.Size = new System.Drawing.Size(442, 24);
            this.cbItens.TabIndex = 6;
            // 
            // btnAdicioanar
            // 
            this.btnAdicioanar.Location = new System.Drawing.Point(105, 733);
            this.btnAdicioanar.Name = "btnAdicioanar";
            this.btnAdicioanar.Size = new System.Drawing.Size(82, 42);
            this.btnAdicioanar.TabIndex = 13;
            this.btnAdicioanar.Text = "Adicionar";
            this.btnAdicioanar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(193, 733);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 42);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Atualizar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(281, 733);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(82, 42);
            this.txtExcluir.TabIndex = 15;
            this.txtExcluir.Text = "Excluir";
            this.txtExcluir.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Quantidade:";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(93, 138);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(77, 22);
            this.nudQuantidade.TabIndex = 30;
            this.nudQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 798);
            this.Controls.Add(this.txtExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicioanar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLocacao";
            this.Text = "Locação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
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
        private System.Windows.Forms.ComboBox cbItens;
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
        private System.Windows.Forms.Button btnAdicioanar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button txtExcluir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label10;
    }
}