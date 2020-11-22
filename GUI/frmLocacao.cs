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
using System.Linq;

namespace GUI
{
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();

            //Adicionando 5 dias a data prevista
            dtpDataPre.Value = dtpDataPre.Value.AddDays(5);

            //Definindo a DataGridView
            dgvItens.Columns.Add("tit", "Filme");
            dgvItens.Columns.Add("barras", "Cod. Barras");
            dgvItens.Columns.Add("preco", "Valor Unitario");
            dgvItens.Columns.Add("dtPrev", "Data Prevista");

            dgvItens.Columns["preco"].DefaultCellStyle.Format = "c";
            dgvItens.Columns["dtPrev"].DefaultCellStyle.Format = "dd MMM yyyy";
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

        private void btnBuscarBarras_Click(object sender, EventArgs e)
        {
            LocacaoDAL ldal = new LocacaoDAL();

            Filmes film = ldal.ObterItensBarras(Convert.ToInt32(txtCodigoBarras.Text));

            if (film == null)
            {
                MessageBox.Show("Esse código de barras não está cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoBarras.Text = String.Empty;
                txtCodigoBarras.Focus();
            }
            else
            {
                txtTitulo.Text = film.Titulo.ToString();
                txtVlUnitario.Text = film.Preco.ToString();
            }
        }       

        private void btnAddDGV_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = new DataGridViewRow();

            item.CreateCells(dgvItens);
           
            item.Cells[0].Value = txtTitulo.Text;
            item.Cells[1].Value = txtCodigoBarras.Text;
            item.Cells[2].Value = txtVlUnitario.Text;
            item.Cells[3].Value = dtpDataPre.Value;          
            dgvItens.Rows.Add(item);

            txtVlTotal.Text = dgvItens.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["preco"].Value ?? 0)).ToString("c");
        }
    }
}
