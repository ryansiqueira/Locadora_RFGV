using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class FilmesDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;
        public void InserirFilmes(Filmes objFilmes)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Itens VALUES (@codigobarras, @titulo, @genero, @ano, @tipo, @preco, @dataadquirida, @valorcusto, @situacao, @atores, @diretor, @capafilme)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@codigo", objFilmes.Codigo);
            cmd.Parameters.AddWithValue("@codigobarras", objFilmes.CodigoBarras);
            cmd.Parameters.AddWithValue("@titulo", objFilmes.Titulo);
            cmd.Parameters.AddWithValue("@genero", objFilmes.Genero);
            cmd.Parameters.AddWithValue("@ano", objFilmes.Ano);
            cmd.Parameters.AddWithValue("@tipo", objFilmes.Tipo);
            cmd.Parameters.AddWithValue("@preco", objFilmes.Preco);
            cmd.Parameters.AddWithValue("@dataadquirida", objFilmes.DataAdquirida);
            cmd.Parameters.AddWithValue("@valorcusto", objFilmes.ValorCusto);
            cmd.Parameters.AddWithValue("@situacao", objFilmes.Situacao);
            cmd.Parameters.AddWithValue("@atores", objFilmes.Atores);
            cmd.Parameters.AddWithValue("@diretor", objFilmes.Diretor);
            cmd.Parameters.Add("@capafilme", SqlDbType.VarBinary).Value = objFilmes.CapaFilme;

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        
        public Filmes ObterFilme(int cdFilme)
        {
            Filmes filme = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Itens WHERE CodigoBarras = @codigobarras";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigobarras", cdFilme);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                filme = new Filmes();
                filme.CodigoBarras = cdFilme;
                filme.Codigo = Convert.ToInt32(dr["CdItem"]);
                filme.Titulo = dr["Titulo"].ToString();
                filme.Genero = dr["Genero"].ToString();
                filme.Ano = Convert.ToInt32(dr["Ano"]);
                filme.Tipo = Convert.ToChar(dr["Tipo"]);
                filme.Preco = Convert.ToDecimal(dr["Preco"].ToString());
                filme.DataAdquirida = Convert.ToDateTime(dr["DtAdquirida"]);
                filme.ValorCusto = Convert.ToDecimal(dr["VlCusto"].ToString());
                filme.Situacao = Convert.ToChar(dr["Situacao"].ToString());
                filme.Atores = dr["Atores"].ToString();
                filme.Diretor = dr["Diretor"].ToString();
                if (dr["CapaFilme"]!= DBNull.Value)
                {
                    filme.CapaFilme = (byte[])dr["CapaFilme"];
                }                
            }

            //cmd.ExecuteNonQuery();
            conn.Close();

            return filme;
        }

        public Filmes ObterFilmeTitulo(string tituloFilme)
        {

            Filmes filme = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Itens WHERE Titulo = @titulo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@titulo", tituloFilme);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                filme = new Filmes();
                filme.Titulo = tituloFilme;
                filme.Codigo = Convert.ToInt32(dr["CdItem"]);
                filme.CodigoBarras = Convert.ToInt32(dr["CodigoBarras"]);
                filme.Genero = dr["Genero"].ToString();
                filme.Ano = Convert.ToInt32(dr["Ano"]);
                filme.Tipo = Convert.ToChar(dr["Tipo"]);
                filme.Preco = Convert.ToDecimal(dr["Preco"]);
                filme.DataAdquirida = Convert.ToDateTime(dr["DtAdquirida"]);
                filme.ValorCusto = Convert.ToDecimal(dr["VlCusto"]);
                filme.Situacao = Convert.ToChar(dr["Situacao"]);
                filme.Atores = dr["Atores"].ToString();
                filme.Diretor = dr["Diretor"].ToString();
                //filme.FotoFilme = dr2["CapaFilme"].ToString();
            }
            conn.Close();

            return filme;
        }

        public List<Filmes> ListarFilmes()
        {
            List<Filmes> listaFilmes = new List<Filmes>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT CdItem,CodigoBarras, Titulo, Genero, Ano FROM Itens";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Filmes objFilmes;
                while (dr.Read())
                {
                    objFilmes = new Filmes();
                    objFilmes.Codigo = Convert.ToInt32(dr["CdItem"]);
                    objFilmes.CodigoBarras = Convert.ToInt32(dr["CodigoBarras"]);
                    objFilmes.Titulo = dr["Titulo"].ToString();
                    objFilmes.Genero = dr["Genero"].ToString();
                    objFilmes.Ano = Convert.ToInt32(dr["Ano"]);
                    //objFilmes.Tipo = Convert.ToChar(dr["Tipo"]);
                    //objFilmes.Preco = Convert.ToDecimal(dr["Preco"]);
                    //objFilmes.DataAdquirida = Convert.ToDateTime(dr["DtAdquirida"]);
                    //objFilmes.ValorCusto = Convert.ToDecimal(dr["VlCusto"]);
                    //objFilmes.Situacao = Convert.ToChar(dr["Situacao"]);
                    //objFilmes.Atores = dr["Atores"].ToString();
                    //objFilmes.Diretor = dr["Diretor"].ToString();
                    //objFilmes.CapaFilme = dr["CapaFilme"].ToString();

                    listaFilmes.Add(objFilmes);
                }
            }

            conn.Close();

            return listaFilmes;
        }

        public void EditarFilme(Filmes objFilmes)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Itens SET CodigoBarras = @codigobarras, Titulo = @titulo, Genero = @genero, Ano = @ano, Tipo = @tipo, Preco = @preco, DtAdquirida = @dataadquirida, VlCusto = @valorcusto, Situacao = @situacao, Atores = @atores, Diretor = @diretor, CapaFilme = @capafilme WHERE CdItem = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigobarras", objFilmes.CodigoBarras);
            cmd.Parameters.AddWithValue("@titulo", objFilmes.Titulo);
            cmd.Parameters.AddWithValue("@genero", objFilmes.Genero);
            cmd.Parameters.AddWithValue("@ano", objFilmes.Ano);
            cmd.Parameters.AddWithValue("@tipo", objFilmes.Tipo);
            cmd.Parameters.AddWithValue("@preco", objFilmes.Preco);
            cmd.Parameters.AddWithValue("@dataadquirida", objFilmes.DataAdquirida);
            cmd.Parameters.AddWithValue("@valorcusto", objFilmes.ValorCusto);
            cmd.Parameters.AddWithValue("@situacao", objFilmes.Situacao);
            cmd.Parameters.AddWithValue("@atores", objFilmes.Atores);
            cmd.Parameters.AddWithValue("@diretor", objFilmes.Diretor);
            cmd.Parameters.Add("@capafilme", SqlDbType.VarBinary).Value = objFilmes.CapaFilme;
            cmd.Parameters.AddWithValue("@codigo", objFilmes.Codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void ExcluirItem(int cdFilme)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Itens WHERE CodigoBarras = @codigobarras";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigobarras", cdFilme);

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        //public List<Pessoa> ListarPessoasFiltros(string nome, string email)
        //{
        //    List<Pessoa> listaPessoas = new List<Pessoa>();

        //    SqlConnection conn = new SqlConnection(connectionString);

        //    conn.Open();

        //    string sql = "SELECT * FROM Pessoas WHERE NmPessoa LIKE @nome AND DsEmail LIKE @email";

        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
        //    cmd.Parameters.AddWithValue("@email", $"%{email}%");

        //    SqlDataReader dr = cmd.ExecuteReader();

        //    if (dr.HasRows)
        //    {
        //        Pessoa objPessoa;
        //        while (dr.Read())
        //        {
        //            objPessoa = new Pessoa();
        //            objPessoa.CdPessoa = Convert.ToInt32(dr["CdPessoa"]);
        //            objPessoa.NmPessoa = dr["NmPessoa"].ToString();
        //            objPessoa.NrCPF = dr["NrCPF"].ToString();
        //            objPessoa.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
        //            objPessoa.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
        //            objPessoa.DsSexo = Convert.ToChar(dr["DsSexo"]);
        //            objPessoa.DsEmail = dr["DsEmail"].ToString();
        //            objPessoa.NrTelefone = dr["NrTelefone"].ToString();
        //            objPessoa.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
        //            objPessoa.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);

        //            listaPessoas.Add(objPessoa);
        //        }
        //    }

        //    conn.Close();

        //    return listaPessoas;
        //}

    }
}

