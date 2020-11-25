
namespace GUI
{
    partial class frmDevolucao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPagamento = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpDataPrevista = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbRecebido = new System.Windows.Forms.CheckBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da Locação:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(205, 63);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(108, 22);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(205, 191);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(108, 22);
            this.txtValor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pagamento:";
            // 
            // cbxPagamento
            // 
            this.cbxPagamento.FormattingEnabled = true;
            this.cbxPagamento.Items.AddRange(new object[] {
            "--Selecione--",
            "Pago Total",
            "Pago Parcial",
            "Não Pago"});
            this.cbxPagamento.Location = new System.Drawing.Point(205, 223);
            this.cbxPagamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPagamento.Name = "cbxPagamento";
            this.cbxPagamento.Size = new System.Drawing.Size(108, 24);
            this.cbxPagamento.TabIndex = 11;
            this.cbxPagamento.Text = "--Selecione--";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(323, 55);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 38);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(312, 282);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(152, 38);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(205, 30);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 22);
            this.txtCodigo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data de Entrega:";
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(205, 127);
            this.dtpDataEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(108, 22);
            this.dtpDataEntrega.TabIndex = 19;
            // 
            // dtpDataPrevista
            // 
            this.dtpDataPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPrevista.Location = new System.Drawing.Point(205, 95);
            this.dtpDataPrevista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataPrevista.Name = "dtpDataPrevista";
            this.dtpDataPrevista.Size = new System.Drawing.Size(108, 22);
            this.dtpDataPrevista.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data Prevista:";
            // 
            // ckbRecebido
            // 
            this.ckbRecebido.AutoSize = true;
            this.ckbRecebido.Location = new System.Drawing.Point(116, 255);
            this.ckbRecebido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbRecebido.Name = "ckbRecebido";
            this.ckbRecebido.Size = new System.Drawing.Size(90, 21);
            this.ckbRecebido.TabIndex = 22;
            this.ckbRecebido.Text = "Recebido";
            this.ckbRecebido.UseVisualStyleBackColor = true;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(205, 159);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(108, 22);
            this.txtValorPago.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Valor Pago:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(16, 282);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(152, 38);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 335);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ckbRecebido);
            this.Controls.Add(this.dtpDataPrevista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxPagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDevolucao";
            this.Text = "Cadastro de Devolução";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPagamento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.DateTimePicker dtpDataPrevista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbRecebido;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastrar;
    }
}