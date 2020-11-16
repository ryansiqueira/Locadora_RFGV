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
            this.btnFecharLocacao = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtDataPrevista = new System.Windows.Forms.DateTimePicker();
            this.dtDataAtual = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDataPrevista = new System.Windows.Forms.Label();
            this.lblNomeItem = new System.Windows.Forms.Label();
            this.lblCPFcliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.lblDataAtual = new System.Windows.Forms.Label();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFecharLocacao
            // 
            this.btnFecharLocacao.Location = new System.Drawing.Point(522, 330);
            this.btnFecharLocacao.Name = "btnFecharLocacao";
            this.btnFecharLocacao.Size = new System.Drawing.Size(122, 32);
            this.btnFecharLocacao.TabIndex = 38;
            this.btnFecharLocacao.Text = "Fechar Locação";
            this.btnFecharLocacao.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(426, 330);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 32);
            this.btnAdicionar.TabIndex = 37;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dtDataPrevista
            // 
            this.dtDataPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPrevista.Location = new System.Drawing.Point(489, 258);
            this.dtDataPrevista.Name = "dtDataPrevista";
            this.dtDataPrevista.Size = new System.Drawing.Size(100, 22);
            this.dtDataPrevista.TabIndex = 36;
            // 
            // dtDataAtual
            // 
            this.dtDataAtual.Enabled = false;
            this.dtDataAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataAtual.Location = new System.Drawing.Point(489, 159);
            this.dtDataAtual.Name = "dtDataAtual";
            this.dtDataAtual.Size = new System.Drawing.Size(100, 22);
            this.dtDataAtual.TabIndex = 35;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(489, 63);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoFuncionario.TabIndex = 34;
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Location = new System.Drawing.Point(489, 96);
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(100, 22);
            this.txtCPFCliente.TabIndex = 33;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(489, 126);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(100, 22);
            this.txtNomeCliente.TabIndex = 32;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(489, 189);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoBarra.TabIndex = 31;
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(489, 226);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(100, 22);
            this.txtNomeFilme.TabIndex = 30;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(489, 292);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 29;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(438, 295);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 17);
            this.lblValor.TabIndex = 28;
            this.lblValor.Text = "Valor:";
            // 
            // lblDataPrevista
            // 
            this.lblDataPrevista.AutoSize = true;
            this.lblDataPrevista.Location = new System.Drawing.Point(387, 263);
            this.lblDataPrevista.Name = "lblDataPrevista";
            this.lblDataPrevista.Size = new System.Drawing.Size(96, 17);
            this.lblDataPrevista.TabIndex = 27;
            this.lblDataPrevista.Text = "Data prevista:";
            // 
            // lblNomeItem
            // 
            this.lblNomeItem.AutoSize = true;
            this.lblNomeItem.Location = new System.Drawing.Point(377, 229);
            this.lblNomeItem.Name = "lblNomeItem";
            this.lblNomeItem.Size = new System.Drawing.Size(106, 17);
            this.lblNomeItem.TabIndex = 26;
            this.lblNomeItem.Text = "Nome do Filme:";
            // 
            // lblCPFcliente
            // 
            this.lblCPFcliente.AutoSize = true;
            this.lblCPFcliente.Location = new System.Drawing.Point(378, 99);
            this.lblCPFcliente.Name = "lblCPFcliente";
            this.lblCPFcliente.Size = new System.Drawing.Size(105, 17);
            this.lblCPFcliente.TabIndex = 25;
            this.lblCPFcliente.Text = "CPF do Cliente:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(367, 129);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(116, 17);
            this.lblNomeCliente.TabIndex = 24;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Location = new System.Drawing.Point(315, 192);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(168, 17);
            this.lblCodigoBarra.TabIndex = 23;
            this.lblCodigoBarra.Text = "Codigo de Barra do filme:";
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.AutoSize = true;
            this.lblDataAtual.Location = new System.Drawing.Point(405, 164);
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(78, 17);
            this.lblDataAtual.TabIndex = 22;
            this.lblDataAtual.Text = "Data Atual:";
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(329, 66);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(154, 17);
            this.lblCodigoFuncionario.TabIndex = 21;
            this.lblCodigoFuncionario.Text = "Código do Funcionario:";
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 518);
            this.Controls.Add(this.btnFecharLocacao);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dtDataPrevista);
            this.Controls.Add(this.dtDataAtual);
            this.Controls.Add(this.txtCodigoFuncionario);
            this.Controls.Add(this.txtCPFCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDataPrevista);
            this.Controls.Add(this.lblNomeItem);
            this.Controls.Add(this.lblCPFcliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCodigoBarra);
            this.Controls.Add(this.lblDataAtual);
            this.Controls.Add(this.lblCodigoFuncionario);
            this.Name = "frmLocacao";
            this.Text = "Locação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecharLocacao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dtDataPrevista;
        private System.Windows.Forms.DateTimePicker dtDataAtual;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDataPrevista;
        private System.Windows.Forms.Label lblNomeItem;
        private System.Windows.Forms.Label lblCPFcliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label lblDataAtual;
        private System.Windows.Forms.Label lblCodigoFuncionario;
    }
}