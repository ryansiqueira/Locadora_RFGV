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
    }
}
