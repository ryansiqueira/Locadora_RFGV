using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = Criptografia.GetMD5Hash(txtSenha.Text);

            UsuarioDAL uDAL = new UsuarioDAL();

            if (uDAL.AutenticarUsuario(usuario, senha))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senha Inválidos");
            }
        }
    }
}
