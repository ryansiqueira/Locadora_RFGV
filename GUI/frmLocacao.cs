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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void txtCdLocacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LocacaoDAL locDAL = new LocacaoDAL();

                Cliente cliente = locDAL.ObterClienteLocacao(Convert.ToInt32(txtCdCliente.Text));

                if (cliente == null)
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeCliente.Text = String.Empty;
                    txtCPFCliente.Text = String.Empty;
                    txtCdCliente.Focus();
                }
                else
                {
                    txtCdCliente.Text = cliente.CdCliente.ToString();
                    txtNomeCliente.Text = cliente.NmCliente;
                    txtCPFCliente.Text = cliente.CPF;
                }
            }            
        }

        private void cbItens_Enter(object sender, EventArgs e)
        {
            LocacaoDAL locDal = new LocacaoDAL();
            cbItens.DataSource = locDal.CarregarFilmes();
            cbItens.DisplayMember = "CdItens";
            cbItens.ValueMember = "Titulo";
        }

        private void txtFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LocacaoDAL locDAL = new LocacaoDAL();

                Funcionarios funcionarios = locDAL.ObterFuncionarioLocacao(Convert.ToInt32(txtFunc.Text));

                if (funcionarios == null)
                {
                    MessageBox.Show("Cliente não cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFunc.Text = String.Empty;
                    txtNmFuncionario.Text = String.Empty;
                    txtFunc.Focus();
                }
                else
                {
                    txtFunc.Text = funcionarios.CdFuncionario.ToString();
                    txtNmFuncionario.Text = funcionarios.NmFuncionario;
                    txtCPFFunc.Text = funcionarios.CPF;
                }
            }
        }
    }
}
