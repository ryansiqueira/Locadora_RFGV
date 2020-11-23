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
    public partial class frmPaginaInicial : Form
    {
        public frmPaginaInicial()
        {
            InitializeComponent();
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFilme tela = new frmCadastroFilme();
            tela.MdiParent = this;

            tela.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios tela = new frmCadastroUsuarios();
            tela.MdiParent = this;

            tela.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente();
            frmCadastroCliente.MdiParent = this;
            frmCadastroCliente.Show();

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionarios func = new FrmCadastroFuncionarios();
            func.MdiParent = this;
            func.Show();
        }

        private void artistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroArtistas func = new frmCadastroArtistas();
            func.MdiParent = this;
            func.Show();
        }

        private void gênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroGeneros func = new frmCadastroGeneros();
            func.MdiParent = this;
            func.Show();
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao loc = new frmLocacao();
            loc.MdiParent = this;
            loc.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucao dev = new frmDevolucao();
            dev.MdiParent = this;
            dev.Show();
        }
    }
}
