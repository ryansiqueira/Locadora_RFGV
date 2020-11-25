using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace GUI
{
    public partial class frmCadastroUsuarios : Form
    {
        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.DsLogin = txtUsuario.Text;
            objUsuario.DsSenha = Criptografia.GetMD5Hash(txtSenha.Text);
            objUsuario.Administrador = CkAdministrador.Checked;

            UsuarioDAL uDAL = new UsuarioDAL();
            uDAL.CadastroUsuario(objUsuario);

            MessageBox.Show("Usuário Cadastrado com Sucesso");
        }
    }
}
