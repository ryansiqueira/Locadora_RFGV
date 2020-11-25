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
    public class ContatoDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;

        public void EnviarMensagem(Contato objContato)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Contatos VALUES (@email, @nome, @assunto, @mensagem)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", objContato.Email);
            cmd.Parameters.AddWithValue("@nome", objContato.Nome);
            cmd.Parameters.AddWithValue("@assunto", objContato.Assunto);
            cmd.Parameters.AddWithValue("@mensagem", objContato.Mensagem);

            conn.Close();
        }
    }
}
