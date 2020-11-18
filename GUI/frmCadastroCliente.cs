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

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ClienteDAL dal = new ClienteDAL();
            dgvCliente.DataSource = dal.ListarClientes();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Cliente Cliente = new Cliente();
            Cliente.NmCliente = txtNome.Text;
            Cliente.DtNascimento = Convert.ToDateTime( txtDtNascimento.Text);
            Cliente.CPF = txtCPF.Text;
            Cliente.DsEstadoCivil = cbEstadoCivil.SelectedItem.ToString().Trim();
            Cliente.Email = txtEmail.Text;
            Cliente.Endereco = txtEndereco.Text;
            Cliente.DsStatus = cbStatus.SelectedItem.ToString().Trim();
            Cliente.Cidade = txtCidade.Text;
            Cliente.RG = txtRG.Text;
            Cliente.Estado = txtEstado.Text;
            Cliente.CEP = txtCep.Text;
            Cliente.Celular = txtCelular.Text;
            Cliente.Telefone = txtTelefone.Text;
            Cliente.Sexo = cbSexo.SelectedItem.ToString().Trim();
            ClienteDAL dal = new ClienteDAL();

            if (string.IsNullOrEmpty(txtCodigo.Text))
                dal.CadastroCliente(Cliente);
            else
                dal.AtualizarCliente(Cliente);

            LimparCampos();
            MessageBox.Show("Cliente Cadastrado Com Sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            CarregarGrid();
        }   
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;

            txtNome.Text = string.Empty;
            txtDtNascimento.Text = string.Empty;
            txtCPF.Text = string.Empty;
            cbEstadoCivil.SelectedItem = null;
            txtEmail.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            cbStatus.SelectedItem = null;
            txtCidade.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            cbSexo.SelectedItem = null;
        }
        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtNome.Text)) 
            {
                MessageBox.Show("Campo Nome Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtDtNascimento.Text)) 
            {
                MessageBox.Show("Campo Data nascimento Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtCPF.Text))
            {
                MessageBox.Show("Campo CPF Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(cbEstadoCivil.SelectedItem.ToString()))
            {
                MessageBox.Show("Campo Estado Civil Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo Email Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Campo Endereço Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(cbStatus.SelectedItem.ToString()))
            {
                MessageBox.Show("Campo Status Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Campo Cidade Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtRG.Text))
            {
                MessageBox.Show("Campo RG Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Campo Estado Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtCep.Text))
            {
                MessageBox.Show("Campo CEP Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtCelular.Text))
            {
                MessageBox.Show("Campo Celular Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Campo Telefone Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(cbSexo.SelectedItem.ToString()))
            {
                MessageBox.Show("Campo Sexo Obrigatório.", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.Columns[e.ColumnIndex].Name == "ColumnEditar")
            {
                int id = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells["ColumnCodigo"].Value);
                ClienteDAL dal = new ClienteDAL();
                Cliente objCliente = dal.GetCliente(id);

                LimparCampos();
                txtCodigo.Text = objCliente.CdCliente.ToString();
                txtNome.Text = objCliente.NmCliente;
                txtDtNascimento.Text = objCliente.DtNascimento.ToString();
                txtCPF.Text = objCliente.CPF;
                cbEstadoCivil.SelectedItem = objCliente.DsEstadoCivil.Trim();
                txtEmail.Text = objCliente.Email;
                txtEndereco.Text = objCliente.Endereco;
                cbStatus.SelectedItem = objCliente.DsStatus;
                txtCidade.Text = objCliente.Cidade;
                txtRG.Text = objCliente.RG;
                txtEstado.Text = objCliente.Estado;
                txtCep.Text = objCliente.CEP;
                txtCelular.Text = objCliente.Celular;
                txtTelefone.Text = objCliente.Telefone;
                cbSexo.SelectedItem = objCliente.Sexo;

            }
            if (dgvCliente.Columns[e.ColumnIndex].Name == "ColumnExcluir")
            {
                int id = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells["ColumnCodigo"].Value);
                ClienteDAL dal = new ClienteDAL();
                dal.DeletarCliente(id);
                CarregarGrid();
            }
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Obrigatório informar um código", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
                return;
            }

            LimparCampos();
            int id = Convert.ToInt32(txtCodigo.Text);
            ClienteDAL dal = new ClienteDAL();
            Cliente objCliente = dal.GetCliente(id);

            if (objCliente == null)
            {
                MessageBox.Show("Codigo de cliente não encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtCodigo.Text = objCliente.CdCliente.ToString();
            txtNome.Text = objCliente.NmCliente;
            txtDtNascimento.Text = objCliente.DtNascimento.ToString();
            txtCPF.Text = objCliente.CPF;
            cbEstadoCivil.SelectedItem = objCliente.DsEstadoCivil.Trim();
            txtEmail.Text = objCliente.Email;
            txtEndereco.Text = objCliente.Endereco;
            cbStatus.SelectedItem = objCliente.DsStatus;
            txtCidade.Text = objCliente.Cidade;
            txtRG.Text = objCliente.RG;
            txtEstado.Text = objCliente.Estado;
            txtCep.Text = objCliente.CEP;
            txtCelular.Text = objCliente.Celular;
            txtTelefone.Text = objCliente.Telefone;
            cbSexo.SelectedItem = objCliente.Sexo;
        }

        private void btnBuscarCpf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPF.Text.Replace(",","").Replace("-","").Replace(" ","")))
            {
                MessageBox.Show("Obrigatório informar um código", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LimparCampos();
            int id = Convert.ToInt32(txtCodigo.Text);
            ClienteDAL dal = new ClienteDAL();
            Cliente objCliente = dal.GetCliente(id);

            if (objCliente == null)
            {
                MessageBox.Show("CPF de cliente não encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtCodigo.Text = objCliente.CdCliente.ToString();
            txtNome.Text = objCliente.NmCliente;
            txtDtNascimento.Text = objCliente.DtNascimento.ToString();
            txtCPF.Text = objCliente.CPF;
            cbEstadoCivil.SelectedItem = objCliente.DsEstadoCivil.Trim();
            txtEmail.Text = objCliente.Email;
            txtEndereco.Text = objCliente.Endereco;
            cbStatus.SelectedItem = objCliente.DsStatus;
            txtCidade.Text = objCliente.Cidade;
            txtRG.Text = objCliente.RG;
            txtEstado.Text = objCliente.Estado;
            txtCep.Text = objCliente.CEP;
            txtCelular.Text = objCliente.Celular;
            txtTelefone.Text = objCliente.Telefone;
            cbSexo.SelectedItem = objCliente.Sexo;
        }
    }
}
