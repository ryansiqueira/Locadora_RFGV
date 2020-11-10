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
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.dtDataadquirida = new System.Windows.Forms.DateTimePicker();
            this.txtValorcusto = new System.Windows.Forms.TextBox();
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
            this.foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListaItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(112, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Location = new System.Drawing.Point(114, 414);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(41, 13);
            this.lblDiretor.TabIndex = 1;
            this.lblDiretor.Text = "Diretor:";
            // 
            // lblAtoresParticipantes
            // 
            this.lblAtoresParticipantes.AutoSize = true;
            this.lblAtoresParticipantes.Location = new System.Drawing.Point(51, 380);
            this.lblAtoresParticipantes.Name = "lblAtoresParticipantes";
            this.lblAtoresParticipantes.Size = new System.Drawing.Size(104, 13);
            this.lblAtoresParticipantes.TabIndex = 2;
            this.lblAtoresParticipantes.Text = "Atores Participantes:";
            // 
            // lblDataAdquirida
            // 
            this.lblDataAdquirida.AutoSize = true;
            this.lblDataAdquirida.Location = new System.Drawing.Point(75, 278);
            this.lblDataAdquirida.Name = "lblDataAdquirida";
            this.lblDataAdquirida.Size = new System.Drawing.Size(80, 13);
            this.lblDataAdquirida.TabIndex = 3;
            this.lblDataAdquirida.Text = "Data Adquirida:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(124, 206);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(126, 169);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 5;
            this.lblAno.Text = "Ano:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(110, 132);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(119, 99);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(64, 72);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(91, 13);
            this.lblCodigoBarras.TabIndex = 8;
            this.lblCodigoBarras.Text = "Código de Barras:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(103, 349);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 9;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblValorCusto
            // 
            this.lblValorCusto.AutoSize = true;
            this.lblValorCusto.Location = new System.Drawing.Point(75, 314);
            this.lblValorCusto.Name = "lblValorCusto";
            this.lblValorCusto.Size = new System.Drawing.Size(80, 13);
            this.lblValorCusto.TabIndex = 10;
            this.lblValorCusto.Text = "Valos de custo:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(117, 244);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço:";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(39, 465);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(116, 13);
            this.lblFoto.TabIndex = 12;
            this.lblFoto.Text = "Foto da Capa do Filme:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(161, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(161, 69);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBarra.TabIndex = 14;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(161, 96);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 15;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(161, 129);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 16;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(161, 166);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 17;
            // 
            // rbDVD
            // 
            this.rbDVD.AutoSize = true;
            this.rbDVD.Checked = true;
            this.rbDVD.Location = new System.Drawing.Point(161, 204);
            this.rbDVD.Name = "rbDVD";
            this.rbDVD.Size = new System.Drawing.Size(48, 17);
            this.rbDVD.TabIndex = 0;
            this.rbDVD.TabStop = true;
            this.rbDVD.Text = "DVD";
            this.rbDVD.UseVisualStyleBackColor = true;
            // 
            // rbBLURAY
            // 
            this.rbBLURAY.AutoSize = true;
            this.rbBLURAY.Location = new System.Drawing.Point(252, 204);
            this.rbBLURAY.Name = "rbBLURAY";
            this.rbBLURAY.Size = new System.Drawing.Size(68, 17);
            this.rbBLURAY.TabIndex = 1;
            this.rbBLURAY.Text = "BLURAY";
            this.rbBLURAY.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(161, 241);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 18;
            // 
            // dtDataadquirida
            // 
            this.dtDataadquirida.Location = new System.Drawing.Point(161, 272);
            this.dtDataadquirida.Name = "dtDataadquirida";
            this.dtDataadquirida.Size = new System.Drawing.Size(245, 20);
            this.dtDataadquirida.TabIndex = 19;
            // 
            // txtValorcusto
            // 
            this.txtValorcusto.Location = new System.Drawing.Point(161, 311);
            this.txtValorcusto.Name = "txtValorcusto";
            this.txtValorcusto.Size = new System.Drawing.Size(100, 20);
            this.txtValorcusto.TabIndex = 20;
            // 
            // cbSituacao
            // 
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Items.AddRange(new object[] {
            "Locado",
            "Não Locado"});
            this.cbSituacao.Location = new System.Drawing.Point(161, 346);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(121, 21);
            this.cbSituacao.TabIndex = 21;
            // 
            // txtAtoresParticipantes
            // 
            this.txtAtoresParticipantes.Location = new System.Drawing.Point(161, 377);
            this.txtAtoresParticipantes.Name = "txtAtoresParticipantes";
            this.txtAtoresParticipantes.Size = new System.Drawing.Size(100, 20);
            this.txtAtoresParticipantes.TabIndex = 22;
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(161, 411);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(100, 20);
            this.txtDiretor.TabIndex = 23;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(66, 536);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 31);
            this.btnAdicionar.TabIndex = 25;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // GridViewListaItens
            // 
            this.GridViewListaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewListaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GridViewListaItens.Location = new System.Drawing.Point(543, 41);
            this.GridViewListaItens.Name = "GridViewListaItens";
            this.GridViewListaItens.RowHeadersWidth = 51;
            this.GridViewListaItens.Size = new System.Drawing.Size(449, 253);
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
            this.btnEditar.Location = new System.Drawing.Point(172, 535);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 31);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(278, 536);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 31);
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
            this.GridViewHistorico.Location = new System.Drawing.Point(543, 314);
            this.GridViewHistorico.Name = "GridViewHistorico";
            this.GridViewHistorico.RowHeadersWidth = 51;
            this.GridViewHistorico.Size = new System.Drawing.Size(449, 253);
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
            this.btnBuscar.Location = new System.Drawing.Point(267, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(160, 435);
            this.foto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(122, 96);
            this.foto.TabIndex = 31;
            this.foto.TabStop = false;
            // 
            // frmCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 643);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.GridViewHistorico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.GridViewListaItens);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.txtAtoresParticipantes);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.txtValorcusto);
            this.Controls.Add(this.dtDataadquirida);
            this.Controls.Add(this.txtPreco);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCadastroFilme";
            this.Text = "Cadastro de Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListaItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
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
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.DateTimePicker dtDataadquirida;
        private System.Windows.Forms.TextBox txtValorcusto;
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
        private System.Windows.Forms.PictureBox foto;
    }
}

