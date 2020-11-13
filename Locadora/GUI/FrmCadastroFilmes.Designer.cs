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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.rbDVD = new System.Windows.Forms.RadioButton();
            this.rbBLURAY = new System.Windows.Forms.RadioButton();
            this.dtDataadquirida = new System.Windows.Forms.DateTimePicker();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.GridViewHistorico = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtValorcusto = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.chLocado = new System.Windows.Forms.CheckBox();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.GridViewListarItens = new System.Windows.Forms.DataGridView();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gênero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diretor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapaFilme = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtGenero = new System.Windows.Forms.ComboBox();
            this.txtAtoresParticipantes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListarItens)).BeginInit();
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
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(215, 47);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 13;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(215, 118);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(132, 22);
            this.txtTitulo.TabIndex = 15;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(215, 204);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(132, 22);
            this.txtAno.TabIndex = 17;
            // 
            // rbDVD
            // 
            this.rbDVD.AutoSize = true;
            this.rbDVD.Checked = true;
            this.rbDVD.Location = new System.Drawing.Point(215, 251);
            this.rbDVD.Margin = new System.Windows.Forms.Padding(4);
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
            this.rbBLURAY.Margin = new System.Windows.Forms.Padding(4);
            this.rbBLURAY.Name = "rbBLURAY";
            this.rbBLURAY.Size = new System.Drawing.Size(84, 21);
            this.rbBLURAY.TabIndex = 1;
            this.rbBLURAY.Text = "BLURAY";
            this.rbBLURAY.UseVisualStyleBackColor = true;
            // 
            // dtDataadquirida
            // 
            this.dtDataadquirida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataadquirida.Location = new System.Drawing.Point(215, 335);
            this.dtDataadquirida.Margin = new System.Windows.Forms.Padding(4);
            this.dtDataadquirida.Name = "dtDataadquirida";
            this.dtDataadquirida.Size = new System.Drawing.Size(132, 22);
            this.dtDataadquirida.TabIndex = 19;
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(215, 506);
            this.txtDiretor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(132, 22);
            this.txtDiretor.TabIndex = 23;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(88, 660);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 38);
            this.btnAdicionar.TabIndex = 25;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(229, 658);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(133, 38);
            this.btnAtualizar.TabIndex = 27;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(371, 660);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(133, 38);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.GridViewHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewHistorico.Name = "GridViewHistorico";
            this.GridViewHistorico.RowHeadersWidth = 51;
            this.GridViewHistorico.Size = new System.Drawing.Size(1035, 311);
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
            this.btnBuscar.Location = new System.Drawing.Point(354, 80);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(208, 28);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar por Codigo de Barras";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(213, 535);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(147, 105);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 31;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFoto_FileOk);
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.Location = new System.Drawing.Point(371, 562);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(133, 55);
            this.btnCarregarFoto.TabIndex = 32;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.UseVisualStyleBackColor = true;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(212, 300);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(135, 22);
            this.txtPreco.TabIndex = 38;
            // 
            // txtValorcusto
            // 
            this.txtValorcusto.Location = new System.Drawing.Point(212, 383);
            this.txtValorcusto.Name = "txtValorcusto";
            this.txtValorcusto.Size = new System.Drawing.Size(135, 22);
            this.txtValorcusto.TabIndex = 39;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(212, 86);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(135, 22);
            this.txtCodigoBarra.TabIndex = 40;
            // 
            // chLocado
            // 
            this.chLocado.AutoSize = true;
            this.chLocado.Checked = true;
            this.chLocado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLocado.Location = new System.Drawing.Point(212, 425);
            this.chLocado.Name = "chLocado";
            this.chLocado.Size = new System.Drawing.Size(77, 21);
            this.chLocado.TabIndex = 41;
            this.chLocado.Text = "Locado";
            this.chLocado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Location = new System.Drawing.Point(355, 115);
            this.btnBuscarTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(208, 28);
            this.btnBuscarTitulo.TabIndex = 43;
            this.btnBuscarTitulo.Text = "Buscar por Titulo";
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.btnBuscarTitulo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(511, 660);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 40);
            this.btnLimpar.TabIndex = 44;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // GridViewListarItens
            // 
            this.GridViewListarItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewListarItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoBarras,
            this.Titulo,
            this.Gênero,
            this.Ano,
            this.CdItem,
            this.Tipo,
            this.Preco,
            this.DtAdquirida,
            this.VlCusto,
            this.Situacao,
            this.Atores,
            this.Diretor,
            this.CapaFilme});
            this.GridViewListarItens.Location = new System.Drawing.Point(724, 47);
            this.GridViewListarItens.Name = "GridViewListarItens";
            this.GridViewListarItens.RowHeadersWidth = 51;
            this.GridViewListarItens.RowTemplate.Height = 24;
            this.GridViewListarItens.Size = new System.Drawing.Size(1036, 306);
            this.GridViewListarItens.TabIndex = 45;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.DataPropertyName = "CodigoBarras";
            this.CodigoBarras.HeaderText = "Codigo de Barras";
            this.CodigoBarras.MinimumWidth = 6;
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.Width = 125;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 125;
            // 
            // Gênero
            // 
            this.Gênero.DataPropertyName = "Gênero";
            this.Gênero.HeaderText = "Gênero";
            this.Gênero.MinimumWidth = 6;
            this.Gênero.Name = "Gênero";
            this.Gênero.Width = 125;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.MinimumWidth = 6;
            this.Ano.Name = "Ano";
            this.Ano.Width = 125;
            // 
            // CdItem
            // 
            this.CdItem.DataPropertyName = "CdItem";
            this.CdItem.HeaderText = "Código";
            this.CdItem.MinimumWidth = 6;
            this.CdItem.Name = "CdItem";
            this.CdItem.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = false;
            this.Tipo.Width = 125;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.MinimumWidth = 6;
            this.Preco.Name = "Preco";
            this.Preco.Visible = false;
            this.Preco.Width = 125;
            // 
            // DtAdquirida
            // 
            this.DtAdquirida.DataPropertyName = "DtAdquirida";
            this.DtAdquirida.HeaderText = "Data Adquirida";
            this.DtAdquirida.MinimumWidth = 6;
            this.DtAdquirida.Name = "DtAdquirida";
            this.DtAdquirida.Visible = false;
            this.DtAdquirida.Width = 125;
            // 
            // VlCusto
            // 
            this.VlCusto.DataPropertyName = "VlCusto";
            this.VlCusto.HeaderText = "Valor de Custo";
            this.VlCusto.MinimumWidth = 6;
            this.VlCusto.Name = "VlCusto";
            this.VlCusto.Visible = false;
            this.VlCusto.Width = 125;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.MinimumWidth = 6;
            this.Situacao.Name = "Situacao";
            this.Situacao.Visible = false;
            this.Situacao.Width = 125;
            // 
            // Atores
            // 
            this.Atores.DataPropertyName = "Atores";
            this.Atores.HeaderText = "Atores";
            this.Atores.MinimumWidth = 6;
            this.Atores.Name = "Atores";
            this.Atores.Visible = false;
            this.Atores.Width = 125;
            // 
            // Diretor
            // 
            this.Diretor.DataPropertyName = "Diretor";
            this.Diretor.HeaderText = "Diretor";
            this.Diretor.MinimumWidth = 6;
            this.Diretor.Name = "Diretor";
            this.Diretor.Visible = false;
            this.Diretor.Width = 125;
            // 
            // CapaFilme
            // 
            this.CapaFilme.DataPropertyName = "CapaFilme";
            this.CapaFilme.HeaderText = "Capa do Filme";
            this.CapaFilme.MinimumWidth = 6;
            this.CapaFilme.Name = "CapaFilme";
            this.CapaFilme.Visible = false;
            this.CapaFilme.Width = 125;
            // 
            // txtGenero
            // 
            this.txtGenero.FormattingEnabled = true;
            this.txtGenero.Location = new System.Drawing.Point(212, 159);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(135, 24);
            this.txtGenero.TabIndex = 46;
            this.txtGenero.Enter += new System.EventHandler(this.txtGenero_Enter);
            // 
            // txtAtoresParticipantes
            // 
            this.txtAtoresParticipantes.FormattingEnabled = true;
            this.txtAtoresParticipantes.Location = new System.Drawing.Point(212, 465);
            this.txtAtoresParticipantes.Name = "txtAtoresParticipantes";
            this.txtAtoresParticipantes.Size = new System.Drawing.Size(135, 24);
            this.txtAtoresParticipantes.TabIndex = 47;
            this.txtAtoresParticipantes.Enter += new System.EventHandler(this.txtAtoresParticipantes_Enter);
            // 
            // frmCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 791);
            this.Controls.Add(this.txtAtoresParticipantes);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.GridViewListarItens);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(this.chLocado);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.txtValorcusto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.GridViewHistorico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.dtDataadquirida);
            this.Controls.Add(this.rbBLURAY);
            this.Controls.Add(this.rbDVD);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtTitulo);
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
            this.Load += new System.EventHandler(this.frmCadastroFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListarItens)).EndInit();
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
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.RadioButton rbDVD;
        private System.Windows.Forms.RadioButton rbBLURAY;
        private System.Windows.Forms.DateTimePicker dtDataadquirida;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView GridViewHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtValorcusto;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.CheckBox chLocado;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView GridViewListarItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gênero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diretor;
        private System.Windows.Forms.DataGridViewImageColumn CapaFilme;
        private System.Windows.Forms.ComboBox txtGenero;
        private System.Windows.Forms.ComboBox txtAtoresParticipantes;
    }
}

