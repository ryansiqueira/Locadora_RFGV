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
    public class GeneroDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;

        public void InserirGenero(Genero objGenero)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Generos VALUES (@nome)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", objGenero.Nome);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AlterarGenero(Genero objGenero)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Generos SET NmGenero = @nome";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objGenero.Nome);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Genero ObterGenero(int cdGenero)
        {
            Genero objGenero = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Generos WHERE CdGenero = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", cdGenero);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objGenero = new Genero();
                objGenero.CdGenero = cdGenero;
                objGenero.Nome = dr["NmGenero"].ToString();
            }

            conn.Close();

            return objGenero;
        }

        public List<Genero> ListarGenero()
        {
            List<Genero> listaGenero = new List<Genero>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Generos";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Genero objGenero;
                while (dr.Read())
                {
                    objGenero = new Genero();
                    objGenero.CdGenero = Convert.ToInt32(dr["CdGenero"]);
                    objGenero.Nome = dr["NmGenero"].ToString();

                    listaGenero.Add(objGenero);
                }
            }

            conn.Close();

            return listaGenero;
        }

        public void ExcluirGenero(int CdGenero)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Generos WHERE CdGenero = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", CdGenero);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable CarregaGeneros()
        {
            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();
            SqlCommand cmd = new SqlCommand("Select NmGenero From Generos", sql);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            DataRow row = table.NewRow();
            row["NmGenero"] = "";
            table.Rows.InsertAt(row, 0);

            sql.Close();
            return table;

        }
    }
}
