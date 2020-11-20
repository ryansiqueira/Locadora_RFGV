using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Models;

namespace DAL
{
    public class LocacaoDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;

        public Locacao InserirLocacao(int QtdeItens)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Locacao VALUES (@CdLocacao, @CdItens,";

            SqlCommand cmd = new SqlCommand(sql,conn);

        }
    }
}
