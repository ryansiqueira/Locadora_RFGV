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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var usuarioDAL = new UsuarioDAL();
            e.Authenticated = usuarioDAL.AutenticarUsuario(Login1.UserName, Criptografia.GetMD5Hash(Login1.Password));
            Logado.UsuarioLogado = e.Authenticated;
            if (e.Authenticated)
            {
                Administrador.Admin = usuarioDAL.VerificaAdmin(Login1.UserName).Administrador;
            }
        }
    }
}