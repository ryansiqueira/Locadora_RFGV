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
            cmd.Parameters.AddWithValue("@paisnascimento", objArtista.PaisNascimento);
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

        public Filmes ObterFilmesArtista(string NmArtista)
        {
            Artista objArtista = null;
            Filmes objFilmes = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT B.Titulo FROM Artistas A INNER JOIN Itens B ON A.NmArtistas = B.Atores WHERE A.NmArtistas = @nome";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", NmArtista);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objArtista = new Artista();
                objFilmes = new Filmes();
                objArtista.Nome = NmArtista;
                objFilmes.Atores = dr["Atores"].ToString();
            }
                conn.Close();

                return objFilmes;
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
                    //objArtista.FotodoArtista = dr["Foto"]; 

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
    }
}
