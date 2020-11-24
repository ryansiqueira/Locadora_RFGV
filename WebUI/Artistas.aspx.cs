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
    public partial class Artistas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CarregaArtistas();
            }
        }

        private void CarregaArtistas()
        {
            this.grvArtistas.DataSource = new ArtistaDAL().ListarArtistas();
            this.grvArtistas.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) && string.IsNullOrEmpty(txtPaisNasc.Text))
            {
                this.grvArtistas.DataSource = new ArtistaDAL().ListarArtistas();
                this.grvArtistas.DataBind();
            }
            else
            {
                this.grvArtistas.DataSource = new ArtistaDAL().ListarArtistasPorNomeOuPais(txtNome.Text, txtPaisNasc.Text);
                this.grvArtistas.DataBind();
            }

        }

        protected void grvArtistas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Server.Transfer("ArtistaDetalhe.aspx?cdArtista=" + e.CommandArgument);
        }
    }
}