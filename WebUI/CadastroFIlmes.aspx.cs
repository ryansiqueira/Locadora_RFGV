using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace WebUI
{
    public partial class CadastroFIlmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void ObterFilme(string Titulo)
        {
            FilmesDAL fDAL = new FilmesDAL();

            Filmes filme = fDAL.ObterFilme(Convert.ToInt32(Titulo));
            if (filme != null)
            {
                txtTitulo.Text = filme.Titulo;
                txtCodigo.Text = filme.Codigo.ToString();
                txtCodigoBarras.Text = filme.CodigoBarras.ToString();
                txtGenero.Text = filme.Genero;
                txtAno.Text = filme.Ano.ToString();
                RadionTipo.SelectedValue = filme.Tipo.ToString();
                txtPreco.Text = filme.Preco.ToString();
                txtDataAdquirida.Text = filme.DataAdquirida.ToString();
                txtValorCusto.Text = filme.ValorCusto.ToString();
                txtSituacao.Checked = filme.CheckSituacao;
                txtAtores.Text = filme.Atores;
                txtDiretor.Text = filme.Diretor;
                PicFoto.ImageUrl = filme.CapaFilme.ToString();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string Titulo = txtTitulo.Text;
            ObterFilme(Titulo);
        }

        //string Titulo = txtTitulo.Text;
        //ObterFilme(Titulo);
        ////string stTitulo = txtTitulo.Text;

        ////FilmesDAL fDAL = new FilmesDAL();
        ////Filmes filme = fDAL.ObterFilmeTitulo(stTitulo);
        //      Filmes filme = new Filmes();
        //    txtCodigo.Text = Convert.ToString(filme.Codigo);
        //    txtCodigoBarras.Text = Convert.ToString(filme.CodigoBarras);
        //    txtTitulo.Text = filme.Titulo;
        //    txtGenero.Text = filme.Genero;
        //    txtAno.Text = Convert.ToString(filme.Ano);
        //    RadioBLURAY.Checked = filme.Tipo == 'B';
        //    RadionDVD.Checked = filme.Tipo == 'D';
        //    txtPreco.Text = Convert.ToString(filme.Preco);
        //    txtDataAdquirida.Text = filme.DataAdquirida.ToString();
        //    txtValorCusto.Text = Convert.ToString(filme.ValorCusto);
        //    txtSituacao.Checked = filme.Situacao == 'L';
        //    //chNaoLocado.Checked = filme.Situacao == 'N';
        //    txtAtores.Text = filme.Atores;
        //    txtDiretor.Text = filme.Diretor;
        //    //PicFoto.ImageUrl = filme.CapaFilme.ToString();
        ////txtfoto = Convert.ToString(filme.FotoFilme);
        //FilmesDAL fDAL = new FilmesDAL();
    }
}