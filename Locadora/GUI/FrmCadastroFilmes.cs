using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace GUI
{
    public partial class frmCadastroFilme : Form
    {
        public frmCadastroFilme()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Filmes objFilmes = new Filmes();
            objFilmes.CodigoBarras = Convert.ToInt32(txtCodigoBarra.Text);
            objFilmes.Titulo = txtTitulo.Text;
            objFilmes.Genero = txtGenero.Text;
            objFilmes.Ano = Convert.ToInt32(txtAno.Text);
            objFilmes.Tipo = rbBLURAY.Checked ? 'B' : 'D';
            objFilmes.Preco = Convert.ToDecimal(txtPreco.Text);
            objFilmes.DataAdquirida = dtDataadquirida.Value;
            objFilmes.ValorCusto = Convert.ToDecimal(txtValorcusto.Text);
            objFilmes.Situacao = chLocado.Checked ? 'L' : 'N';
            objFilmes.Atores = txtAtoresParticipantes.Text;
            objFilmes.Diretor = txtDiretor.Text;
            //objFilmes.FotoFilme = Convert.ToString(picFoto.Text);

            FilmesDAL fDAL = new FilmesDAL();
            fDAL.InserirFilmes(objFilmes);

            MessageBox.Show("Filme Inserido com Sucesso");

            LimparCampos();
            CarregarFilmes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cdFilme = Convert.ToInt32(txtCodigoBarra.Text);
            
            FilmesDAL fDAL = new FilmesDAL();
            Filmes filme = fDAL.ObterFilme(cdFilme);

            if (filme == null)
            {
                MessageBox.Show("Filme não encontrado.");
                LimparCampos();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(filme.Codigo);
                txtCodigoBarra.Text = Convert.ToString(filme.CodigoBarras);
                txtTitulo.Text = filme.Titulo;
                txtGenero.Text = filme.Genero;
                txtAno.Text = Convert.ToString(filme.Ano);
                rbBLURAY.Checked = filme.Tipo == 'B';
                rbDVD.Checked = filme.Tipo == 'D';
                txtPreco.Text = Convert.ToString(filme.Preco);
                dtDataadquirida.Value = filme.DataAdquirida;
                txtValorcusto.Text = Convert.ToString(filme.ValorCusto);
                chLocado.Checked = filme.Situacao == 'L';
                //chNaoLocado.Checked = filme.Situacao == 'N';
                txtAtoresParticipantes.Text = filme.Atores;
                txtDiretor.Text = filme.Diretor;
                //txtfoto = Convert.ToString(filme.FotoFilme);
            }
        }
        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtCodigoBarra.Text = string.Empty;
            txtTitulo.Text = string.Empty;            
            txtGenero.Text = string.Empty;
            rbBLURAY.Checked = true;
            txtPreco.Text = string.Empty;
            txtAno.Text = string.Empty;
            txtValorcusto.Text = string.Empty;
            chLocado.Checked = true;
            txtAtoresParticipantes.Text = string.Empty;
            txtDiretor.Text = string.Empty;
            picFoto.Text = string.Empty;
            dtDataadquirida.Value = DateTime.Now;
        }
        private void CarregarFilmes()
        {
            FilmesDAL fDAL = new FilmesDAL();
            GridViewListaItens.DataSource = fDAL.ListarFilmes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cdFilme = Convert.ToInt32(txtCodigoBarra.Text);

            FilmesDAL fDAL = new FilmesDAL();
            fDAL.ExcluirItem(cdFilme);

            MessageBox.Show("Filme excluído com sucesso.");

            LimparCampos();
            CarregarFilmes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Filmes objFilmes = new Filmes();
            objFilmes.Codigo = Convert.ToInt32(txtCodigo.Text);
            objFilmes.CodigoBarras = Convert.ToInt32(txtCodigoBarra.Text);
            objFilmes.Titulo = txtTitulo.Text;
            objFilmes.Genero = txtGenero.Text;
            objFilmes.Ano = Convert.ToInt32(txtAno.Text);
            objFilmes.Tipo = rbBLURAY.Checked ? 'B' : 'D';
            objFilmes.Preco = Convert.ToDecimal(txtPreco.Text);
            objFilmes.DataAdquirida = dtDataadquirida.Value;
            objFilmes.ValorCusto = Convert.ToDecimal(txtValorcusto.Text);
            objFilmes.Situacao = chLocado.Checked ? 'L' : 'N';
            objFilmes.Atores = txtAtoresParticipantes.Text;
            objFilmes.Diretor = txtDiretor.Text;
            //objFilmes.FotoFilme = picFoto.();

            FilmesDAL fDAL = new FilmesDAL();
            fDAL.EditarFilme(objFilmes);

            MessageBox.Show("Filme atualizado com Sucesso");

            LimparCampos();
            CarregarFilmes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            ofdFoto.FileName = "";
            ofdFoto.Title = "Selecione uma imagem";
            ofdFoto.Filter = "JPEG|*.JPG|PNG|*.png";
            ofdFoto.ShowDialog();
        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {
            picFoto.Image = Image.FromFile(ofdFoto.FileName);
        }

        private void GridViewListaItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCadastroFilme_Load(object sender, EventArgs e)
        {
            CarregarFilmes();
        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            string stTitulo = txtTitulo.Text;

            FilmesDAL fDAL = new FilmesDAL();
            Filmes filme = fDAL.ObterFilmeTitulo(stTitulo);

            if (filme == null)
            {
                MessageBox.Show("Filme não encontrado.");
                LimparCampos();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(filme.Codigo);
                txtCodigoBarra.Text = Convert.ToString(filme.CodigoBarras);
                txtTitulo.Text = filme.Titulo;
                txtGenero.Text = filme.Genero;
                txtAno.Text = Convert.ToString(filme.Ano);
                rbBLURAY.Checked = filme.Tipo == 'B';
                rbDVD.Checked = filme.Tipo == 'D';
                txtPreco.Text = Convert.ToString(filme.Preco);
                dtDataadquirida.Value = filme.DataAdquirida;
                txtValorcusto.Text = Convert.ToString(filme.ValorCusto);
                chLocado.Checked = filme.Situacao == 'L';
                //chNaoLocado.Checked = filme.Situacao == 'N';
                txtAtoresParticipantes.Text = filme.Atores;
                txtDiretor.Text = filme.Diretor;
                //txtfoto = Convert.ToString(filme.FotoFilme);
            }        
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }   
}
