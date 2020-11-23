using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;
using Models;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class frmCadastroArtistas : Form
    {
        public frmCadastroArtistas()
        {
            InitializeComponent();
            dgvFilmes.AutoGenerateColumns = false;
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            ofdFoto.FileName = "";
            ofdFoto.Title = "Selecione uma Foto";
            ofdFoto.Filter = "JPEG|* .jpg|PNG|*.png";
            ofdFoto.ShowDialog();
        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {
            picFoto.Image = Image.FromFile(ofdFoto.FileName);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Artista objArtista = new Artista();
            objArtista.Nome = txtNome.Text;
            objArtista.DtNascimento = Convert.ToDateTime(dtpNascimento.Value);
            objArtista.PaisNascimento = txtPaisNasc.Text;
            if (picFoto.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    picFoto.Image.Save(stream, ImageFormat.Jpeg);

                    byte[] FotoArtista = stream.ToArray();

                    objArtista.FotodoArtista = FotoArtista;
                }
            }

            ArtistaDAL aDAL = new ArtistaDAL();
            aDAL.InserirArtista(objArtista);

            MessageBox.Show("Artista Adicionado com Sucesso");

            CarregarArtistas();
            LimparCampos();
        }

        private void CarregarArtistas()
        {
            ArtistaDAL aDAL = new ArtistaDAL();
            dgvArtistas.DataSource = aDAL.ListarArtistas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Artista objArtista = new Artista();
            objArtista.CdArtista = Convert.ToInt32(txtCodigo.Text);
            objArtista.Nome = txtNome.Text;
            objArtista.DtNascimento = Convert.ToDateTime(dtpNascimento.Value);
            objArtista.PaisNascimento = txtPaisNasc.Text;
            if (picFoto.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    picFoto.Image.Save(stream, ImageFormat.Jpeg);

                    byte[] FotoArtista = stream.ToArray();

                    objArtista.FotodoArtista = FotoArtista;
                }
            }

            ArtistaDAL aDAL = new ArtistaDAL();
            aDAL.AlterarArtista(objArtista);

            MessageBox.Show("Artista Alterado com Sucesso");

            CarregarArtistas();
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int CdArtista = Convert.ToInt32(txtCodigo.Text);

            ArtistaDAL aDAL = new ArtistaDAL();
            aDAL.ExcluirArtista(CdArtista);

            MessageBox.Show("Pessoa Excluida com Sucesso");

            CarregarArtistas();
            LimparCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string NmArtista = txtNome.Text;

            ArtistaDAL aDAL = new ArtistaDAL();
            ArtistaDAL fDAL = new ArtistaDAL();

            Artista objArtista = aDAL.ObterArtista(NmArtista);

            if (objArtista == null)
            {
                MessageBox.Show("Artista Não Encontrado");
            }
            else
            {
                byte[] arquivo = objArtista.FotodoArtista;
                txtCodigo.Text = Convert.ToString(objArtista.CdArtista);
                txtNome.Text = objArtista.Nome;
                dtpNascimento.Value = objArtista.DtNascimento;
                txtPaisNasc.Text = objArtista.PaisNascimento;
                Image img1 = ConverteByteParaImagem(arquivo);
                picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                picFoto.Image = img1;
            }

            dgvFilmes.DataSource = fDAL.ObterFilmesArtista(NmArtista);
        }

        private Image ConverteByteParaImagem(byte[] arquivo)
        {
            try
            {
                using (MemoryStream mStream = new MemoryStream(arquivo))
                {
                    return Image.FromStream(mStream);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmCadastroArtistas_Load(object sender, EventArgs e)
        {
            CarregarArtistas();
        }

        public void LimparCampos()
        {
            txtCodigo.Text = String.Empty;
            txtNome.Text = String.Empty;
            dtpNascimento.Value = DateTime.Now;
            txtPaisNasc.Text = String.Empty;
        }
    }
}
