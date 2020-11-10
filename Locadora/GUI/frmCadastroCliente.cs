using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();
            Cliente.NmCliente = txtNome.Text;
            Cliente.DtNascimento = Convert.ToDateTime( txtDtNascimento.Text);
            Cliente.CPF = txtCPF.Text;
            Cliente.DsEstadoCivil = cbEstadoCivil.SelectedText;
            Cliente.Email = txtEmail.Text;
            Cliente.Endereco = txtEndereco.Text;
            Cliente.DsStatus = cbStatus.SelectedText;
            Cliente.Cidade = txtCidade.Text;
            Cliente.RG = txtRG.Text;
            Cliente.Estado = txtEstado.Text;
            Cliente.CEP = txtCep.Text;
            Cliente.Celular = txtCelular.Text;
            Cliente.Telefone = txtTelefone.Text;
            Cliente.Sexo = cbSexo.SelectedText;
            ClienteDAL dal = new ClienteDAL();
            dal.CadastroCliente(Cliente);
            MessageBox.Show("Cliente Cadastrado Com Sucesso","Cliente", MessageBoxButtons.OK);




            

        }
    }
}
