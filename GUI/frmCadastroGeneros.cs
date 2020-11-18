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
    public partial class frmCadastroGeneros : Form
    {
        public frmCadastroGeneros()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.Nome = txtNome.Text;

            GeneroDAL gDAL = new GeneroDAL();
            gDAL.InserirGenero(objGenero);

            MessageBox.Show("Genero Adicionado com Sucesso");

            CarregarGeneros();
            LimparCampos();
        }
        private void CarregarGeneros()
        {
            GeneroDAL gDAL = new GeneroDAL();
            dgvGeneros.DataSource = gDAL.ListarGenero();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.CdGenero = Convert.ToInt32(txtCodigo.Text);
            objGenero.Nome = txtNome.Text;

            GeneroDAL gDAL = new GeneroDAL();
            gDAL.AlterarGenero(objGenero);

            MessageBox.Show("Genero Alterado com Sucesso");

            CarregarGeneros();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int CdGenero = Convert.ToInt32(txtCodigo.Text);

            GeneroDAL gDAL = new GeneroDAL();
            gDAL.ExcluirGenero(CdGenero);

            MessageBox.Show("Genero Excluido com Sucesso");

            CarregarGeneros();
            LimparCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int CdGenero = Convert.ToInt32(txtCodigo.Text);

            GeneroDAL gDAL = new GeneroDAL();

            Genero objGenero = gDAL.ObterGenero(CdGenero);

            if (objGenero == null)
            {
                MessageBox.Show("Genero Não Encontrado");
            }
            else
            {
                txtNome.Text = objGenero.Nome;
            }
        }

        private void frmCadastroGeneros_Load(object sender, EventArgs e)
        {
            CarregarGeneros();
        }

        public void LimparCampos()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
        }
    }
}
