using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FilmesDAL fDal = new FilmesDAL();
            grvFilmes.DataSource = fDal.ListarTudoFilmes();
            //    < asp:SqlDataSource ID = "BancoLocadora" runat = "server"
            //ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Locadora;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            //ProviderName = "System.Data.SqlClient"
            //SelectCommand = "SELECT Titulo, Caminho From Itens" ></ asp:SqlDataSource >
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
        }

        protected void grvFilmes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string nomeComando = e.CommandName;
            string Titulo = (string)e.CommandArgument;

            if (nomeComando == "CarregaFilme")
            {
                ObterFilmeTitulo(Titulo);
                Response.Redirect("CadastroFIlmes.aspx?Titulo="+Titulo);
            }
        }

        private void ObterFilmeTitulo(string Titulo)
        {
            FilmesDAL fDAL = new FilmesDAL();
            grvFilmes.DataSource = fDAL.ListarTudoFilmes();
        }



    }
}