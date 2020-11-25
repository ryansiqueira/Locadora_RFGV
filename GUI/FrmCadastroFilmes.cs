using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Models;
using DAL;
using System.IO;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class frmCadastroFilme : Form
    {
        public frmCadastroFilme()
        {
            InitializeComponent();
            GridViewListarItens.AutoGenerateColumns = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Filmes objFilmes = new Filmes();
            objFilmes.CodigoBarras = Convert.ToInt32(txtCodigoBarra.Text);
            objFilmes.Titulo = txtTitulo.Text;
            objFilmes.Genero = txtGenero.Text;
            objFilmes.Ano = Convert.ToInt32(txtAno.Text);
            objFilmes.Tipo = rbBLURAY.Checked ? 'B' : 'D';
            objFilmes.Preco = Convert.ToDecimal(txtPreco.Text);
            objFilmes.DataAdquirida = dtDataadquirida.Value;
            objFilmes.ValorCusto = Convert.ToDecimal(txtValorcusto.Text);
            objFilmes.Situacao = chLocado.Checked ? 'L' : 'N';
            objFilmes.Atores = txtAtoresParticipantes.Text;
            objFilmes.Diretor = txtDiretor.Text;
            if (picFoto.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    picFoto.Image.Save(stream, ImageFormat.Jpeg);

                    byte[] CapaFilme = stream.ToArray();

                    var path = Path.Combine(@"c:\Trabalho Anderson\Locadora_RFGV\Locadora\WebUI", "CapasFilmes");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    path = Path.Combine(path, objFilmes.Titulo + ".jpg");
                    System.IO.File.WriteAllBytes(path, CapaFilme);
                    objFilmes.CapaFilme = CapaFilme;
                    objFilmes.Caminho = path;


                    //System.IO.FileInfo fileInfo = new FileInfo(objFilmes.Caminho);

                    //FilmesDAL Cad_Foto = new FilmesDAL();

                    //Cad_Foto.InserirFilmes(picFoto.Text, CapaFilme, picFoto.Name, picFoto.Properties.ZoomPercent);
                }

                //picFoto.Image.Dispose();
                //picFoto.Image = null;
            }

            FilmesDAL fDAL = new FilmesDAL();
            fDAL.InserirFilmes(objFilmes);

            MessageBox.Show("Filme Inserido com Sucesso");

            LimparCampos();
            CarregarFilmes();
            fDAL.SalvarImagemLocal(objFilmes);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cdFilme = Convert.ToInt32(txtCodigoBarra.Text);

            FilmesDAL fDAL = new FilmesDAL();
            Filmes filme = fDAL.ObterFilme(cdFilme);

            if (filme == null)
            {
                MessageBox.Show("Filme não encontrado.");
                LimparCampos();
            }
            else
            {
                byte[] arquivo = filme.CapaFilme;
                txtCodigo.Text = Convert.ToString(filme.Codigo);
                txtCodigoBarra.Text = Convert.ToString(filme.CodigoBarras);
                txtTitulo.Text = filme.Titulo;
                txtGenero.Text = filme.Genero;
                txtAno.Text = Convert.ToString(filme.Ano);
                rbBLURAY.Checked = filme.Tipo == 'B';
                rbDVD.Checked = filme.Tipo == 'D';
                txtPreco.Text = Convert.ToString(filme.Preco);
                dtDataadquirida.Value = filme.DataAdquirida;
                txtValorcusto.Text = Convert.ToString(filme.ValorCusto);
                chLocado.Checked = filme.Situacao == 'L';
                //chNaoLocado.Checked = filme.Situacao == 'N';
                txtAtoresParticipantes.Text = filme.Atores;
                txtDiretor.Text = filme.Diretor;
                Image img1 = ConverteByteParaImagem(arquivo);
                picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                picFoto.Image = img1;
                //picFoto.Image = null;
                //if (picFoto.Image != null && picFoto.Image.Length > 0)
                //{
                //    picFoto.Image = ByteToImage(Funcionario.Foto)
                //}
                //CapaFilme = filme.CapaFilme.byte

            }
        }
        public Image byteArrayToImage(byte[] img)
        {
            using (var ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtCodigoBarra.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtGenero.Text = string.Empty;
            rbBLURAY.Checked = true;
            txtPreco.Text = string.Empty;
            txtAno.Text = string.Empty;
            txtValorcusto.Text = string.Empty;
            chLocado.Checked = true;
            txtAtoresParticipantes.Text = string.Empty;
            txtDiretor.Text = string.Empty;
            picFoto.Image = null;
            dtDataadquirida.Value = DateTime.Now;
        }
        private void CarregarFilmes()
        {
            FilmesDAL fDAL = new FilmesDAL();
            GridViewListarItens.DataSource = fDAL.ListarFilmes();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int cdFilme = Convert.ToInt32(txtCodigoBarra.Text);

            FilmesDAL fDAL = new FilmesDAL();
            fDAL.ExcluirItem(cdFilme);

            MessageBox.Show("Filme excluído com sucesso.");

            LimparCampos();
            CarregarFilmes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Filmes objFilmes = new Filmes();
            objFilmes.Codigo = Convert.ToInt32(txtCodigo.Text);
            objFilmes.CodigoBarras = Convert.ToInt32(txtCodigoBarra.Text);
            objFilmes.Titulo = txtTitulo.Text;
            objFilmes.Genero = txtGenero.Text;
            objFilmes.Ano = Convert.ToInt32(txtAno.Text);
            objFilmes.Tipo = rbBLURAY.Checked ? 'B' : 'D';
            objFilmes.Preco = Convert.ToDecimal(txtPreco.Text);
            objFilmes.DataAdquirida = dtDataadquirida.Value;
            objFilmes.ValorCusto = Convert.ToDecimal(txtValorcusto.Text);
            objFilmes.Situacao = chLocado.Checked ? 'L' : 'N';
            objFilmes.Atores = txtAtoresParticipantes.Text;
            objFilmes.Diretor = txtDiretor.Text;            
            if (picFoto.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    picFoto.Image.Save(stream, ImageFormat.Jpeg);

                    byte[] CapaFilme = stream.ToArray();

                    objFilmes.CapaFilme = CapaFilme;
                }
            }
            FilmesDAL fDAL = new FilmesDAL();
            fDAL.EditarFilme(objFilmes);

            MessageBox.Show("Filme atualizado com Sucesso");

            LimparCampos();
            CarregarFilmes();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {            
            ofdFoto.FileName = "";
            ofdFoto.Title = "Selecione uma imagem";
            ofdFoto.Filter = "JPEG|*.JPG|PNG|*.png";
            ofdFoto.ShowDialog();
        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {
            picFoto.Image = Image.FromFile(ofdFoto.FileName);
        }

        private void GridViewListaItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCadastroFilme_Load(object sender, EventArgs e)
        {
            CarregarFilmes();
        }

        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            string stTitulo = txtTitulo.Text;

            FilmesDAL fDAL = new FilmesDAL();
            Filmes filme = fDAL.ObterFilmeTitulo(stTitulo);

            if (filme == null)
            {
                MessageBox.Show("Filme não encontrado.");
                LimparCampos();
            }
            else
            {
                byte[] arquivo = filme.CapaFilme;
                txtCodigo.Text = Convert.ToString(filme.Codigo);
                txtCodigoBarra.Text = Convert.ToString(filme.CodigoBarras);
                txtTitulo.Text = filme.Titulo;
                txtGenero.Text = filme.Genero;
                txtAno.Text = Convert.ToString(filme.Ano);
                rbBLURAY.Checked = filme.Tipo == 'B';
                rbDVD.Checked = filme.Tipo == 'D';
                txtPreco.Text = Convert.ToString(filme.Preco);
                dtDataadquirida.Value = filme.DataAdquirida;
                txtValorcusto.Text = Convert.ToString(filme.ValorCusto);
                chLocado.Checked = filme.Situacao == 'L';
                //chNaoLocado.Checked = filme.Situacao == 'N';
                txtAtoresParticipantes.Text = filme.Atores;
                txtDiretor.Text = filme.Diretor;
                Image img1 = ConverteByteParaImagem(arquivo);
                picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                picFoto.Image = img1;
                //txtfoto = Convert.ToString(filme.FotoFilme);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtGenero_Enter(object sender, EventArgs e)
        {            
            GeneroDAL gDal = new GeneroDAL();
            txtGenero.DataSource = gDal.CarregaGeneros();
            txtGenero.DisplayMember = "CdGenero";
            txtGenero.ValueMember = "NmGenero";
        }

        private void txtAtoresParticipantes_Enter(object sender, EventArgs e)
        {
            ArtistaDAL tDAL = new ArtistaDAL();
            txtAtoresParticipantes.DataSource = tDAL.CarregaArtistas();
            txtAtoresParticipantes.DisplayMember = "CdArtistia";
            txtAtoresParticipantes.ValueMember = "NmArtistas";
        }

        //private void uploadFile(FileUpload fileUpload, string local_path, string tipoAnexo)
        //{
        //    string extension = "";
        //    int nFileLen = 0;
        //    string contentType = "";
        //    bool errors = false;
        //    string strFilename = "";
        //    byte[] myData = new byte[1];
        //    HttpPostedFile myFile = fileUpload.PostedFile;
        //    nFileLen = myFile.ContentLength;
        //    contentType = myFile.ContentType;
        //    if (nFileLen <= 0)
        //    {
        //        lblErroAnexo.Text = "Selecione um Arquivo!";
        //        errors = true;
        //    }
        //    else
        //    {
        //        myData = new byte[nFileLen];
        //        myFile.InputStream.Read(myData, 0, nFileLen);
        //        strFilename = Path.GetFileName(myFile.FileName);
        //        //strFilename = "(" + fileType + ") - " + strFilename;
        //        extension = Path.GetExtension(strFilename.ToLower());
        //        bool exists = false;
        //        foreach (string s in Directory.GetFiles(local_path))
        //        {
        //            if (Path.GetFileName(s).ToLower() == Path.GetFileName(strFilename).ToLower())
        //            {
        //                exists = true;
        //                break;
        //            }
        //        }
        //        if (exists == true)
        //        {
        //            lblErroAnexo.Text = "Já existe um arquivo com este nome para este cliente.";
        //            errors = true;
        //        }
        //    }
        //    if (errors == false)
        //    {
        //        try
        //        {
        //            FileStream newFile = new FileStream(local_path + "\\" + strFilename, FileMode.Create);
        //            newFile.Write(myData, 0, myData.Length);
        //            newFile.Close();
        //            ValidaRetornoException validaRetorno = new ValidaRetornoException();
        //            OportunidadeAnexoBLL oBLL = new OportunidadeAnexoBLL();
        //            OportunidadeAnexoVO oOportunidadeAnexo = new OportunidadeAnexoVO(0
        //                , int.Parse(txtCodigo.Text)
        //                , strFilename
        //                , extension
        //                , nFileLen
        //                , 0
        //                , 0
        //                , contentType
        //                , local_path
        //                , "0"
        //                , HttpContext.Current.User.Identity.GetUserName()
        //                , DateTime.Now
        //                , null
        //                , null,
        //                tipoAnexo);
        //            validaRetorno = oBLL.InserirAnexo(oOportunidadeAnexo);
        //            if (validaRetorno.Status == false)
        //            {
        //                lblErroAnexo.Text = TrataTexto.TrataTextoAsp(validaRetorno.Excecao.ToString());
        //            }
        //            else
        //            {
        //                CarregaGridAnexos();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            lblErroAnexo.Text = "Erro: Detalhes: " + ex.ToString();
        //        }
        //    }
        //}
    }
}
