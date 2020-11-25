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

            //Não deixar check no Recebido
            ckbRecebido.Checked = false;

            //Não permitir a geração de colunas automaticas
            dgvItens.AutoGenerateColumns = false;

            //Adicionando 5 dias a data prevista
            dtpDataPre.Value = dtpDataPre.Value.AddDays(5);

            //Definindo a DataGridView
            dgvItens.Columns.Add("cod", "Código");
            dgvItens.Columns.Add("tit", "Filme");
            dgvItens.Columns.Add("barras", "Cod. Barras");
            dgvItens.Columns.Add("preco", "Valor Unitario");
            dgvItens.Columns.Add("dtPrev", "Data Prevista");

            dgvItens.Columns["preco"].DefaultCellStyle.Format = "c";
            dgvItens.Columns["dtPrev"].DefaultCellStyle.Format = "dd MMM yyyy";
        }

        private void txtCdLocacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
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
                txtCdItem.Text = film.Codigo.ToString();
                txtTitulo.Text = film.Titulo.ToString();
                txtVlUnitario.Text = film.Preco.ToString();
            }
        } 

        public void LimparTudo()
        {
            txtCdLocacao.Text = String.Empty;
            txtCdCliente.Text = String.Empty;
            txtNmFuncionario.Text = String.Empty;
            txtCPFCliente.Text = String.Empty;
            txtNomeCliente.Text = String.Empty;
            txtNmFuncionario.Text = String.Empty;
            dtpDataAtual.Value = DateTime.Today;
            txtCdItem.Text = String.Empty;
            txtTitulo.Text = String.Empty;
            txtVlUnitario.Text = String.Empty;
            txtCodigoBarras.Text = String.Empty;
            dtpDataPre.Value = DateTime.Today;
            dtpDataPre.Value = dtpDataPre.Value.AddDays(5);
            cbPagamento.Text = "--Selecione--";
            txtVlTotal.Text = String.Empty;
            lblValorReceb.Visible = false;
            txtVlRecebido.Visible = false;
            txtVlRecebido.Text = String.Empty;
            dgvItens.Rows.Clear();
            txtFunc.Text = String.Empty;
            txtCPFFunc.Text = String.Empty;

        }
        
        public void LimparItens()
        {
            txtCdItem.Text = String.Empty;
            txtTitulo.Text = String.Empty;
            txtVlUnitario.Text = String.Empty;
            txtCodigoBarras.Text = String.Empty;
            dtpDataPre.Value = DateTime.Today;
            dtpDataPre.Value = dtpDataPre.Value.AddDays(5); 
        }

        private void btnAddDGV_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = new DataGridViewRow();

            item.CreateCells(dgvItens);

            item.Cells[0].Value = txtCdItem.Text;
            item.Cells[1].Value = txtTitulo.Text;
            item.Cells[2].Value = txtCodigoBarras.Text;
            item.Cells[3].Value = txtVlUnitario.Text;
            item.Cells[4].Value = dtpDataPre.Value;          
            dgvItens.Rows.Add(item);

            txtVlTotal.Text = dgvItens.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["preco"].Value ?? 0)).ToString();

            LimparItens();
        }        
        private void txtExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCdLocacao.Text))
            {
                MessageBox.Show("Informar o código da Locação!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                LocacaoDAL locdal = new LocacaoDAL();

                locdal.ExcluirLocacao(Convert.ToInt32(txtCdLocacao.Text));

                MessageBox.Show("Locação excluida com sucesso","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtCdLocacao.Text = String.Empty;
            }
        }

        private void cbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPagamento.Text == "Pago Parcial" || cbPagamento.Text == "Pago Total")
            {
                lblValorReceb.Visible = true;
                txtVlRecebido.Visible = true;
            }
            else
            {
                lblValorReceb.Visible = false;
                txtVlRecebido.Visible = false;
            }
        }

        private void btnBuscaLoca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo em construção, melhoria na próxima release","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo em construção, melhoria na próxima release", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdicionarLocacao_Click(object sender, EventArgs e)
        {
            Locacao loc = new Locacao();
            LocacaoDAL locDAL = new LocacaoDAL();

            for (int x = 0; x < dgvItens.Rows.Count; x++)
            {
                loc.CdLocacao = Convert.ToInt32(txtCdLocacao.Text);
                loc.CdItens = Convert.ToInt32(dgvItens.Rows[x].Cells[0].Value);
                loc.FKCliente = Convert.ToInt32(txtCdCliente.Text);
                loc.DtAtual = Convert.ToDateTime(dtpDataAtual.Value);
                loc.DtPrevista = Convert.ToDateTime(dtpDataPre.Value);
                loc.ValorTotal = Convert.ToDecimal(txtVlTotal.Text);
                loc.DsRecebido = ckbRecebido.Checked;

                switch (cbPagamento.Text)
                {
                    case "Pago Total":
                        loc.DsStatusPg = 'T';
                        break;

                    case "Pago Parcial":
                        loc.DsStatusPg = 'P';
                        break;

                    case "Não Pago":
                        loc.DsStatusPg = 'N';
                        break;
                }
                if (txtVlRecebido.Text == "")
                {
                    txtVlRecebido.Text = "0";
                }
                loc.ValorRecebido = Convert.ToDecimal(txtVlRecebido.Text);
                locDAL.InserirLocacao(loc);
            }                     
            MessageBox.Show("Locação inserida com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparTudo();
        }
    }
}
