using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class ArtistaDetalhe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Params["cdArtista"] != null)
                {
                    CarregaDadosArtista(Convert.ToInt32(Request.Params["cdArtista"].ToString()));
                }
                else
                {
                    Server.Transfer("/Artistas.aspx");
                }
            }

        }

        private void CarregaDadosArtista(int CdArtista)
        {
            Artista artista = new ArtistaDAL().ObterArtista(CdArtista);
            txtCodigo.Text = artista.CdArtista.ToString();
            txtNome.Text = artista.Nome;
            txtDtNasc.Text = artista.DtNascimento.ToString("dd/MM/yyyy");
            txtPaisNasc.Text = artista.PaisNascimento; 
            imgFoto.ImageUrl = artista.FotodoArtista64;

            this.gvFilmesArtista.DataSource = new ArtistaDAL().ObterFilmesArtistaWeb(CdArtista);
            this.gvFilmesArtista.DataBind();
        }
    }
}