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

        public void InserirLocacao(Locacao locacao,int QtdeItens)
        {
            int rept = 0;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            while (rept <= QtdeItens)
            {
                string sql = "INSERT INTO Locacao VALUES (@CdLocacao, @CdItens, @FKCliente, @DtAtual, @DtPrevista, @ValorTotal, @DsStatusPg, @QtdeItens)";
                SqlCommand cmd = new SqlCommand(sql, conn);
            }      


        }

        public Cliente ObterCliente(int CdCliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            Cliente cliente = null;

            return cliente;
        }
        

        

       
        
    }
}
