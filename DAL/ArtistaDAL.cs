using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Models;
using System.Data;

namespace DAL
{
    public class ArtistaDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;

        public void InserirArtista(Artista objArtista)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Artistas VALUES (@nome, @dtnascimento, @paisnascimento, @foto)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", objArtista.Nome);
            cmd.Parameters.AddWithValue("@dtnascimento", objArtista.DtNascimento);
            cmd.Parameters.AddWithValue("@paisnascimento", objArtista.PaisNascimento);
            cmd.Parameters.AddWithValue("@foto", SqlDbType.VarBinary).Value = objArtista.FotodoArtista;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AlterarArtista(Artista objArtista)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Artistas SET NmArtistas = @nome, DtNascimento = @dtnascimento, PaisNascimento = @paisnasc, Foto = @foto";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objArtista.Nome);
            cmd.Parameters.AddWithValue("@dtnascimento", objArtista.DtNascimento);
            cmd.Parameters.AddWithValue("@paisnasc", objArtista.PaisNascimento);
            cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = objArtista.FotodoArtista;

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Artista ObterArtista(string NmArtista)
        {
            Artista objArtista = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Artistas WHERE NmArtistas = @nome";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", NmArtista);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objArtista = new Artista();
                objArtista.CdArtista = Convert.ToInt32(dr["CdArtista"]);
                objArtista.Nome = NmArtista;
                objArtista.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                objArtista.PaisNascimento = dr["PaisNascimento"].ToString();
                if (dr["Foto"]!= DBNull.Value)
                {
                    objArtista.FotodoArtista = (byte[])dr["Foto"];
                }
            }

            conn.Close();

            return objArtista;
        }


        public Artista ObterArtista(int cdArtista)
        {
            Artista objArtista = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Artistas WHERE CdArtista = @cdArtista";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cdArtista", cdArtista);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objArtista = new Artista();
                objArtista.CdArtista = Convert.ToInt32(dr["CdArtista"]);
                objArtista.Nome = dr["NmArtistas"].ToString();
                objArtista.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                objArtista.PaisNascimento = dr["PaisNascimento"].ToString();
                if (dr["Foto"] != DBNull.Value)
                {
                    objArtista.FotodoArtista = (byte[])dr["Foto"];
                }
            }

            conn.Close();

            return objArtista;
        }
        public List<Filmes> ObterFilmesArtista(string NmArtista)
        {
            List<Filmes> listaFilmes = new List<Filmes>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT B.Titulo FROM Artistas A INNER JOIN Itens B ON A.NmArtistas = B.Atores WHERE A.NmArtistas = @nome";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", NmArtista);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Filmes objFilme;
                while (dr.Read())
                {
                    objFilme = new Filmes();
                    objFilme.Titulo = dr["Titulo"].ToString();

                    listaFilmes.Add(objFilme);
                }
            }
            conn.Close();

                return listaFilmes;
        }

        public List<Artista> ListarArtistas()
        {
            List<Artista> listaArtistas = new List<Artista>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Artistas";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Artista objArtista;
                while (dr.Read())
                {
                    objArtista = new Artista();
                    objArtista.CdArtista = Convert.ToInt32(dr["CdArtista"]);
                    objArtista.Nome = dr["NmArtistas"].ToString();
                    objArtista.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                    objArtista.PaisNascimento = dr["PaisNascimento"].ToString();
                    if (dr["Foto"] != DBNull.Value)
                    {
                        objArtista.FotodoArtista = (byte[])dr["Foto"];
                    }

                    listaArtistas.Add(objArtista);
                }
            }

            conn.Close();

            return listaArtistas;
        }

        public void ExcluirArtista (int CdArtista)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Artistas WHERE CdArtista = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", CdArtista);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable CarregaArtistas()
        {
            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();
            SqlCommand cmd = new SqlCommand("Select NmArtistas From Artistas", sql);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            DataRow row = table.NewRow();
            row["NmArtistas"] = "";
            table.Rows.InsertAt(row, 0);

            sql.Close();
            return table;

        }

        public List<Artista> ListarArtistasPorNomeOuPais(string nome, string pais)
        {
            List<Artista> listaArtistas = new List<Artista>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Artistas WHERE NmArtistas = @nome OR PaisNascimento = @pais";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@pais", pais);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Artista objArtista;
                while (dr.Read())
                {
                    objArtista = new Artista();
                    objArtista.CdArtista = Convert.ToInt32(dr["CdArtista"]);
                    objArtista.Nome = dr["NmArtistas"].ToString();
                    objArtista.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                    objArtista.PaisNascimento = dr["PaisNascimento"].ToString();
                    if (dr["Foto"] != DBNull.Value)
                    {
                        objArtista.FotodoArtista = (byte[])dr["Foto"];
                    }

                    listaArtistas.Add(objArtista);
                }
            }

            conn.Close();

            return listaArtistas;
        }

        public List<Filmes> ObterFilmesArtistaWeb(int CdArtista)
        {
            List<Filmes> listaFilmes = new List<Filmes>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT B.Titulo FROM Artistas A INNER JOIN Itens B ON A.NmArtistas = B.Atores WHERE A.CdArtista = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", CdArtista);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Filmes objFilme;
                while (dr.Read())
                {
                    objFilme = new Filmes();
                    objFilme.Titulo = dr["Titulo"].ToString();

                    listaFilmes.Add(objFilme);
                }
            }
            conn.Close();

            return listaFilmes;
        }
    }
}
