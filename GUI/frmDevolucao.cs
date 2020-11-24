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
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
            cbxPagamento.Text = "--Selecione--";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigoLocacao = Convert.ToInt32(txtCodigo.Text);

            DevolucaoDAL dDAL = new DevolucaoDAL();
            Locacao objLocacao = dDAL.BuscarLocacao(codigoLocacao);

            if (objLocacao == null)
            {
                MessageBox.Show("Locacao Não Encontrada");
            }
            else
            {
                txtCodigo.Text = objLocacao.CdLocacao.ToString();
                dtpDataPrevista.Value = Convert.ToDateTime(objLocacao.DtPrevista);
                dtpDataEntrega.Value = DateTime.Now;
                txtValorPago.Text = objLocacao.ValorRecebido.ToString();
                cbxPagamento.Text = objLocacao.DsStatusPg.ToString();
                ckbRecebido.Checked = objLocacao.DsRecebido;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Devolucao objDevolucao = new Devolucao();
            DevolucaoDAL dDAL = new DevolucaoDAL();

            objDevolucao.CdDevolucao = Convert.ToInt32(txtCodigo.Text);
            objDevolucao.CdLocacao = Convert.ToInt32(txtCodigoBarras.Text);
            objDevolucao.DataPrevista = dtpDataPrevista.Value;
            objDevolucao.DatadeEntrega = dtpDataEntrega.Value;
            objDevolucao.ValorPago = Convert.ToDecimal(txtValorPago.Text);
            objDevolucao.ValorTotal = Convert.ToDecimal(txtValor.Text);
            objDevolucao.Recebido = ckbRecebido.Checked;

            switch (cbxPagamento.Text)
            {
                case "Pago Total":
                    objDevolucao.Pagamento = 'T';
                    break;

                case "Pago Parcial":
                    objDevolucao.Pagamento = 'P';
                    break;

                case "Não Pago":
                    objDevolucao.Pagamento = 'N';
                    break;
            }

            dDAL.InserirDevolucao(objDevolucao);

            //if (cbxPagamento.Text == "Pago Total")
            //{
            //    if (txtValor.Text == txtValorPago.Text)
            //    {
            //        objDevolucao.Recebido = Convert.ToDecimal(txtValorPago.Text);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Valor total difere do recebido para 'Pagamento Completo'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //    }
            //}
            //else if (cbPagamento.Text == "Pago Parcial")
            //{
            //    if (txtVlTotal.Text == txtVlRecebido.Text)
            //    {
            //        MessageBox.Show("O correto é 'Pago Total'", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //    }
            //    else if (Convert.ToInt32(txtVlRecebido.Text) > Convert.ToInt32(txtVlTotal.Text))
            //    {
            //        MessageBox.Show("Não é possivel receber a mais do que o total", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //    }
            //    else
            //    {
            //        loc.ValorRecebido = Convert.ToDecimal(txtVlRecebido.Text);
            //    }
            //}
            //else
            //{
            //    txtVlRecebido.Text = "0";
            //    loc.ValorRecebido = Convert.ToDecimal(txtVlRecebido.Text);
            //    locDAL.InserirLocacao(loc);
            //    MessageBox.Show("Locação inserida com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LimparTudo();
            //}
        }
    }
}
