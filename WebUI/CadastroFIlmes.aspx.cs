using System;
using System.Collections.Generic;
using System.IO;
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
            if(Request.Params["Titulo"] != null)
            {
                ObterFilmeTitulo(lblTitulo.Text = Request.Params["Titulo"].ToString());
            }       
        }

        private void ObterFilmeTitulo(string Titulo)
        {
            FilmesDAL fDAL = new FilmesDAL();

            Filmes filme = fDAL.ObterFilmeTitulo(Titulo);
            if (filme != null)
            {
                lblTitulo.Text = filme.Titulo;
                lblCodigo.Text = filme.Codigo.ToString();
                lblCodigoBarras.Text = filme.CodigoBarras.ToString();
                lblGenero.Text = filme.Genero;
                lblAno.Text = filme.Ano.ToString();
                if (filme.Tipo == 'D')
                {
                    lblTipo.Text = "DVD";
                }   
                else
                {
                    lblTipo.Text = "BLURAY";
                }
                lblPreco.Text = filme.Preco.ToString();
                lblDataAdquirida.Text = filme.DataAdquirida.ToString();
                lblValorCusto.Text = filme.ValorCusto.ToString();
                if (filme.CheckSituacao)
                {
                    lblSituacao.Text = "Locado";
                }    
                else
                {
                    lblSituacao.Text = "Não Locado";
                }
                lblAtores.Text = filme.Atores;
                lblDiretor.Text = filme.Diretor;
                PicFoto.ImageUrl = filme.Caminho;
            }
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