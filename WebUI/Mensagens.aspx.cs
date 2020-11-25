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
    public partial class Mensagens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Administrador.Admin == true && Logado.UsuarioLogado == true)
            {
                CarregarPessoas();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }   

        private void CarregarPessoas()
        {
            ContatoDAL cDAL = new ContatoDAL();
            gvMensagens.DataSource = cDAL.ListarMensagens();
            gvMensagens.DataBind();
        }
    }
}