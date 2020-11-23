//using Models;
//using DAL;
//using GUI;
//using System;
//using System.Data.SqlClient;
//using System.Web.UI.WebControls;
//using System.Configuration;

//namespace WebUI
//{
//    public partial class TelaPrincipal : System.Web.UI.Page
//    {
//        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        protected void Image(object sender, GridViewCommandEventArgs e)
//        {
//            string nomeComando = e.CommandName;
//            int cdItem = Convert.ToInt32(e.CommandArgument);

//            if (nomeComando == "Consultar")
//            {
//                ObterFilme(cdItem);
//            }
//        }

//        public Filmes ObterFilme(int cdFilme)
//        {
//            Filmes filme = null;

//            SqlConnection conn = new SqlConnection(connectionString);

//            conn.Open();

//            string sql = "SELECT * FROM Itens WHERE CdItem = @cditem";
//            SqlCommand cmd = new SqlCommand(sql, conn);
//            cmd.Parameters.AddWithValue("@cditem", cdFilme);

//            SqlDataReader dr = cmd.ExecuteReader();

//            if (dr.HasRows && dr.Read())
//            {
//                filme = new Filmes();
//                filme.Codigo = cdFilme;
//                filme.CodigoBarras = Convert.ToInt32(dr["CodigoBarras"]);                
//                filme.Titulo = dr["Titulo"].ToString();
//                filme.Genero = dr["Genero"].ToString();
//                filme.Ano = Convert.ToInt32(dr["Ano"]);
//                filme.Tipo = Convert.ToChar(dr["Tipo"]);
//                filme.Preco = Convert.ToDecimal(dr["Preco"].ToString());
//                filme.DataAdquirida = Convert.ToDateTime(dr["DtAdquirida"]);
//                filme.ValorCusto = Convert.ToDecimal(dr["VlCusto"].ToString());
//                filme.Situacao = Convert.ToChar(dr["Situacao"].ToString());
//                filme.Atores = dr["Atores"].ToString();
//                filme.Diretor = dr["Diretor"].ToString();
//                if (dr["CapaFilme"] != DBNull.Value)
//                {
//                    filme.CapaFilme = (byte[])dr["CapaFilme"];
//                }
//            }

//            //cmd.ExecuteNonQuery();
//            conn.Close();

//            return filme;
//        }

//        protected void ImageButton_Click(object sender, System.Web.UI.ImageClickEventArgs e)
//        {
//            CadastroFilmes tela = new CadastroFilmes();
            
//        }
//    }
//}