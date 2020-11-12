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
    public partial class FrmCadastroFuncionarios : Form
    {
        public FrmCadastroFuncionarios()
        {
            InitializeComponent();
            CarregarFuncionarios();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Funcionarios fun = new Funcionarios();

            fun.NmFuncionario = txtNome.Text;
            fun.CPF = mksCPF.Text;
            fun.DtNascimento = dtpNascimento.Value;
            switch (cbEstadoCivil.Text)
            {
                case "Solteiro":
                    fun.EstadoCivil = 'S';
                    break;

                case "Casado":
                    fun.EstadoCivil = 'C';
                    break;

                case "Divorciado":
                    fun.EstadoCivil = 'D';
                    break;

                case "Viúvo":
                    fun.EstadoCivil = 'V';
                    break;
            }
            switch (cbSexo.Text)
            {
                case "Masculino":
                    fun.Sexo = 'M';
                    break;

                case "Feminino":
                    fun.Sexo = 'F';
                    break;

                case "Não-binário":
                    fun.Sexo = 'N';
                    break;
            }
            fun.Email = txtEmail.Text;
            fun.Telefone = txtTelefone.Text;
            fun.RG = mskRG.Text;
            fun.Endereco = txtEndereco.Text;
            fun.Cidade = txtCidade.Text;
            fun.CEP = mskCEP.Text;
            fun.Estado = cbEstados.Text;
            fun.Celular = txtCelular.Text;
            fun.DsStatus = ckbStatus.Checked;

            FuncionarioDAL fdal = new FuncionarioDAL();
            fdal.InserirFuncionarios(fun);

            MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarFuncionarios();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == String.Empty || mksCPF.Text == String.Empty)
            {
                MessageBox.Show("Informe um código ou CPF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FuncionarioDAL fdal = new FuncionarioDAL();

                fdal.ExcluirFuncionario(Convert.ToInt32(txtCodigo.Text));
                MessageBox.Show("Funcionario Excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregarFuncionarios();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Funcionarios fun = new Funcionarios();

            fun.CdFuncionario = Convert.ToInt32(txtCodigo.Text);
            fun.NmFuncionario = txtNome.Text;
            fun.CPF = mksCPF.Text;
            fun.DtNascimento = Convert.ToDateTime(dtpNascimento.Value);
            switch (cbEstadoCivil.Text)
            {
                case "Solteiro":
                    fun.EstadoCivil = 'S';
                    break;

                case "Casado":
                    fun.EstadoCivil = 'C';
                    break;

                case "Divorciado":
                    fun.EstadoCivil = 'D';
                    break;

                case "Viúvo":
                    fun.EstadoCivil = 'V';
                    break;
            }
            switch (cbSexo.Text)
            {
                case "Masculino":
                    fun.Sexo = 'M';
                    break;

                case "Feminino":
                    fun.Sexo = 'F';
                    break;

                case "Não-binário":
                    fun.Sexo = 'N';
                    break;
            }
            fun.Email = txtEmail.Text;
            fun.Telefone = txtTelefone.Text;
            fun.RG = mskRG.Text;
            fun.Endereco = txtEndereco.Text;
            fun.Cidade = txtCidade.Text;
            fun.CEP = mskCEP.Text;
            fun.Estado = cbEstados.Text;
            fun.Celular = txtCelular.Text;
            fun.DsStatus = ckbStatus.Checked;

            FuncionarioDAL fdal = new FuncionarioDAL();
            fdal.AtualizaFuncionario(fun);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarCd_Click(object sender, EventArgs e)
        {
            FuncionarioDAL fdal = new FuncionarioDAL();

            Funcionarios fun = fdal.ObterFuncionarioCod(Convert.ToInt32(txtCodigo.Text));

            if (fdal == null)
            {
                MessageBox.Show("Não há registros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                txtCodigo.Text = fun.CdFuncionario.ToString();
                txtNome.Text = fun.NmFuncionario;
                mksCPF.Text = fun.CPF;
                dtpNascimento.Value = fun.DtNascimento;
                switch (fun.EstadoCivil)
                {
                    case 'S':
                        cbEstadoCivil.Text = "Solteiro";
                        break;

                    case 'C':
                        cbEstadoCivil.Text = "Casado";
                        break;

                    case 'D':
                        cbEstadoCivil.Text = "Divorciado";
                        break;

                    case 'V':
                        cbEstadoCivil.Text = "Viúvo";
                        break;
                }
                switch (fun.Sexo)
                {
                    case 'M':
                        cbSexo.Text = "Masculino";
                        break;

                    case 'F':
                        cbSexo.Text = "Feminino";
                        break;

                    case 'N':
                        cbSexo.Text = "Não-binário";
                        break;
                }
                txtEmail.Text = fun.Email;
                txtTelefone.Text = fun.Telefone;
                mskRG.Text = fun.RG;
                txtEndereco.Text = fun.Endereco;
                txtCidade.Text = fun.Cidade;
                mskCEP.Text = fun.CEP;
                cbEstados.Text = fun.Estado;
                txtCelular.Text = fun.Celular;
                ckbStatus.Checked = fun.DsStatus;
            }
        }

        public void CarregarFuncionarios()
        {
            FuncionarioDAL fdal = new FuncionarioDAL();
            dgvFuncionarios.DataSource = fdal.ListarFuncionarios();
        }
        
        private void btnBuscarCPF_Click(object sender, EventArgs e)
        {
            FuncionarioDAL fdal = new FuncionarioDAL();

            Funcionarios fun = fdal.ObterFuncionarioCPF(mksCPF.Text);

            if (fun == null)
            {
                MessageBox.Show("Não há registros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                txtCodigo.Text = fun.CdFuncionario.ToString();
                txtNome.Text = fun.NmFuncionario;
                mksCPF.Text = fun.CPF;
                dtpNascimento.Value = fun.DtNascimento;
                switch (fun.EstadoCivil)
                {
                    case 'S':
                        cbEstadoCivil.Text = "Solteiro";
                        break;

                    case 'C':
                        cbEstadoCivil.Text = "Casado";
                        break;

                    case 'D':
                        cbEstadoCivil.Text = "Divorciado";
                        break;

                    case 'V':
                        cbEstadoCivil.Text = "Viúvo";
                        break;
                }
                switch (fun.Sexo)
                {
                    case 'M':
                        cbSexo.Text = "Masculino";
                        break;

                    case 'F':
                        cbSexo.Text = "Feminino";
                        break;

                    case 'N':
                        cbSexo.Text = "Não-binário";
                        break;
                }
                txtEmail.Text = fun.Email;
                txtTelefone.Text = fun.Telefone;
                mskRG.Text = fun.RG;
                txtEndereco.Text = fun.Endereco;
                txtCidade.Text = fun.Cidade;
                mskCEP.Text = fun.CEP;
                cbEstados.Text = fun.Estado;
                txtCelular.Text = fun.Celular;
                ckbStatus.Checked = fun.DsStatus;
            }
        }
    }
}
