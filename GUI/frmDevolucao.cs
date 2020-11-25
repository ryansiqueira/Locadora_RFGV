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
            int codigoLocacao = Convert.ToInt32(txtCodigoBarras.Text);

            DevolucaoDAL dDAL = new DevolucaoDAL();
            Locacao objLocacao = dDAL.BuscarLocacao(codigoLocacao);

            if (objLocacao == null)
            {
                MessageBox.Show("Locacao Não Encontrada");
            }
            else
            {
                txtCodigoBarras.Text = objLocacao.CdLocacao.ToString();
                dtpDataPrevista.Value = Convert.ToDateTime(objLocacao.DtPrevista);
                dtpDataEntrega.Value = DateTime.Now;
                txtValorPago.Text = objLocacao.ValorRecebido.ToString();

                switch (objLocacao.DsStatusPg.ToString())
                {
                    case "T":
                        cbxPagamento.Text = "Pago Total";
                        break;

                    case "P":
                        cbxPagamento.Text = "Pago Parcial";
                        break;

                    case "N":
                        cbxPagamento.Text = "Não pago";
                        break;
                }
                txtValor.Text = objLocacao.ValorTotal.ToString();
                txtValorPago.Text = objLocacao.ValorRecebido.ToString();
                ckbRecebido.Checked = objLocacao.DsRecebido;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Devolucao objDevolucao = new Devolucao();
            DevolucaoDAL dDAL = new DevolucaoDAL();

            
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
            MessageBox.Show("Devolução cadastradas com sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
