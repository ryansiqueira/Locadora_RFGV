using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace WebUI
{
    public partial class PageContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Contato objContato = new Contato();
            objContato.Email = txtEmail.Text;
            objContato.Nome = txtNome.Text;
            objContato.Assunto = txtAssunto.Text;
            objContato.Mensagem = txtMensagem.Text;
            objContato.DataMensagem = DateTime.Today;

            ContatoDAL cDAL = new ContatoDAL();
            cDAL.EnviarMensagem(objContato);

            lblMensagemTela.Text = "Mensagem Enviada com Sucesso";

            LimparCampos();
        }

        public void LimparCampos()
        {
            txtEmail.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtAssunto.Text = String.Empty;
            txtMensagem.Text = String.Empty;
        }
    }
}