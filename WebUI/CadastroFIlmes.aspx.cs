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
                //ObterFilmeTitulo(PicFoto.ImageUrl = Request.Params["Caminho"].ToString());
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
    }
}