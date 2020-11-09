namespace GUI
{
    partial class frmCadastroFilme
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.lblAtoresParticipantes = new System.Windows.Forms.Label();
            this.lblDataAdquirida = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblValorCusto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.rbDVD = new System.Windows.Forms.RadioButton();
            this.rbBLURAY = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.txtAtoresParticipantes = new System.Windows.Forms.TextBox();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.GridViewListaItens = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.GridViewHistorico = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListaItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(149, 50);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Location = new System.Drawing.Point(152, 510);
            this.lblDiretor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(55, 17);
            this.lblDiretor.TabIndex = 1;
            this.lblDiretor.Text = "Diretor:";
            // 
            // lblAtoresParticipantes
            // 
            this.lblAtoresParticipantes.AutoSize = true;
            this.lblAtoresParticipantes.Location = new System.Drawing.Point(68, 468);
            this.lblAtoresParticipantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtoresParticipantes.Name = "lblAtoresParticipantes";
            this.lblAtoresParticipantes.Size = new System.Drawing.Size(139, 17);
            this.lblAtoresParticipantes.TabIndex = 2;
            this.lblAtoresParticipantes.Text = "Atores Participantes:";
            // 
            // lblDataAdquirida
            // 
            this.lblDataAdquirida.AutoSize = true;
            this.lblDataAdquirida.Location = new System.Drawing.Point(100, 342);
            this.lblDataAdquirida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAdquirida.Name = "lblDataAdquirida";
            this.lblDataAdquirida.Size = new System.Drawing.Size(106, 17);
            this.lblDataAdquirida.TabIndex = 3;
            this.lblDataAdquirida.Text = "Data Adquirida:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(165, 254);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(168, 208);
            this.lblAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(37, 17);
            this.lblAno.TabIndex = 5;
            this.lblAno.Text = "Ano:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(147, 162);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(60, 17);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(159, 122);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 17);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(85, 89);
            this.lblCodigoBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(122, 17);
            this.lblCodigoBarras.TabIndex = 8;
            this.lblCodigoBarras.Text = "Código de Barras:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(137, 430);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(67, 17);
            this.lblSituacao.TabIndex = 9;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblValorCusto
            // 
            this.lblValorCusto.AutoSize = true;
            this.lblValorCusto.Location = new System.Drawing.Point(100, 386);
            this.lblValorCusto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorCusto.Name = "lblValorCusto";
            this.lblValorCusto.Size = new System.Drawing.Size(105, 17);
            this.lblValorCusto.TabIndex = 10;
            this.lblValorCusto.Text = "Valos de custo:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(156, 300);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(49, 17);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(52, 572);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(154, 17);
            this.lblFoto.TabIndex = 12;
            this.lblFoto.Text = "Foto da Capa do Filme:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(215, 47);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 13;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(215, 85);
            this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoBarra.TabIndex = 14;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(215, 118);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(132, 22);
            this.txtTitulo.TabIndex = 15;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(215, 159);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(132, 22);
            this.txtGenero.TabIndex = 16;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(215, 204);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(132, 22);
            this.txtAno.TabIndex = 17;
            // 
            // rbDVD
            // 
            this.rbDVD.AutoSize = true;
            this.rbDVD.Checked = true;
            this.rbDVD.Location = new System.Drawing.Point(215, 251);
            this.rbDVD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDVD.Name = "rbDVD";
            this.rbDVD.Size = new System.Drawing.Size(58, 21);
            this.rbDVD.TabIndex = 0;
            this.rbDVD.TabStop = true;
            this.rbDVD.Text = "DVD";
            this.rbDVD.UseVisualStyleBackColor = true;
            // 
            // rbBLURAY
            // 
            this.rbBLURAY.AutoSize = true;
            this.rbBLURAY.Location = new System.Drawing.Point(336, 251);
            this.rbBLURAY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBLURAY.Name = "rbBLURAY";
            this.rbBLURAY.Size = new System.Drawing.Size(84, 21);
            this.rbBLURAY.TabIndex = 1;
            this.rbBLURAY.Text = "BLURAY";
            this.rbBLURAY.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 297);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 335);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 383);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 20;
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Locado",
            "Não Locado"});
            this.cbSituacao.Location = new System.Drawing.Point(215, 426);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(160, 24);
            this.cbSituacao.TabIndex = 21;
            // 
            // txtAtoresParticipantes
            // 
            this.txtAtoresParticipantes.Location = new System.Drawing.Point(215, 464);
            this.txtAtoresParticipantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAtoresParticipantes.Name = "txtAtoresParticipantes";
            this.txtAtoresParticipantes.Size = new System.Drawing.Size(132, 22);
            this.txtAtoresParticipantes.TabIndex = 22;
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(215, 506);
            this.txtDiretor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(132, 22);
            this.txtDiretor.TabIndex = 23;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(226, 660);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 38);
            this.btnAdicionar.TabIndex = 25;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // GridViewListaItens
            // 
            this.GridViewListaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewListaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GridViewListaItens.Location = new System.Drawing.Point(724, 50);
            this.GridViewListaItens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridViewListaItens.Name = "GridViewListaItens";
            this.GridViewListaItens.RowHeadersWidth = 51;
            this.GridViewListaItens.Size = new System.Drawing.Size(599, 311);
            this.GridViewListaItens.TabIndex = 26;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CodigoBarras";
            this.Column2.HeaderText = "Código de Barras";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Titulo";
            this.Column3.HeaderText = "Titulo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Genero";
            this.Column4.HeaderText = "Gênero";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Ano";
            this.Column5.HeaderText = "Ano";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(226, 706);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 38);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(226, 752);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(133, 38);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // GridViewHistorico
            // 
            this.GridViewHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.GridViewHistorico.Location = new System.Drawing.Point(724, 386);
            this.GridViewHistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridViewHistorico.Name = "GridViewHistorico";
            this.GridViewHistorico.RowHeadersWidth = 51;
            this.GridViewHistorico.Size = new System.Drawing.Size(599, 311);
            this.GridViewHistorico.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NmCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DtLocacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data Locação";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DtDevolucaoPrevista";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data de devolução prevista";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DtDevolucao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de devolução";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "VlPago";
            this.Column1.HeaderText = "Valor Pago";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(356, 44);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(213, 535);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 118);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 791);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.GridViewHistorico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.GridViewListaItens);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.txtAtoresParticipantes);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbBLURAY);
            this.Controls.Add(this.rbDVD);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblValorCusto);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDataAdquirida);
            this.Controls.Add(this.lblAtoresParticipantes);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCadastroFilme";
            this.Text = "Cadastro de Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListaItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDiretor;
        private System.Windows.Forms.Label lblAtoresParticipantes;
        private System.Windows.Forms.Label lblDataAdquirida;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblValorCusto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.RadioButton rbDVD;
        private System.Windows.Forms.RadioButton rbBLURAY;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.TextBox txtAtoresParticipantes;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView GridViewListaItens;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView GridViewHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

