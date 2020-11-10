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
    public partial class frmCadastroFilme : Form
    {
        public frmCadastroFilme()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Filmes objFilmes = new Filmes();
            objFilmes.CodigoBarras = Convert.ToInt32(txtCodigoBarra.Text);
            objFilmes.Titulo = txtTitulo.Text;
            objFilmes.Genero = txtGenero.Text;
            objFilmes.Ano = Convert.ToInt32(txtAno.Text);
            objFilmes.Tipo = rbBLURAY.Checked ? 'B' : 'D';
            objFilmes.Preco = Convert.ToDecimal(txtPreco);
            objFilmes.DataAdquirida = dtDataadquirida.Value;
            objFilmes.ValorCusto = Convert.ToDecimal(txtValorcusto);
            objFilmes.Situacao = cbSituacao.Text;
            objFilmes.Atores = txtAtoresParticipantes.Text;
            objFilmes.Diretor = txtDiretor.Text;
            objFilmes.FotoFilme = foto.ToString();

            FilmesDAL fDAL = new FilmesDAL();
            fDAL.InserirFilmes(objFilmes);

            MessageBox.Show("Filme Inserido com Sucesso");

            
        }
    }
}
