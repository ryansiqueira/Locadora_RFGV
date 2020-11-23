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
    public class DevolucaoDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;

        public void InserirDevolucao(Devolucao objDevolucao)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Devolucao VALUES (@FKLocacao, @FKItens, @VlRecebido, @DsStatusPg, @DatadeEntrega)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@FKLocacao", objDevolucao.CdLocacao);
            cmd.Parameters.AddWithValue("@FKItens", objDevolucao.CdItem);
            cmd.Parameters.AddWithValue("@VlRecebido", objDevolucao.ValorTotal);
            cmd.Parameters.AddWithValue("@DsStatusPg", objDevolucao.Pagamento);
            cmd.Parameters.AddWithValue("@DatadeEntrega", objDevolucao.DatadeEntrega);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Locacao BuscarLocacao (int codigobarras)
        {
            Locacao objLocacao = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT A.CdLocacao, A.CdItens, A.FkCliente, A.DtPrevista, A.ValorTotal, A.DsRecebido " +
                "FROM Locacao A INNER JOIN Devolucao B ON B.FKLocacao = A.CdLocacao AND A.CdItens = Itens.CdItens " +
                "WHERE A.CdItens = @codigodebarras";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigodebarras", codigobarras);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objLocacao = new Locacao();
                objLocacao.CdLocacao = Convert.ToInt32(dr["CdLocacao"]);
                objLocacao.CdItens = Convert.ToInt32(dr["CdItens"]);
                objLocacao.FKCliente = Convert.ToInt32(dr["FkCliente"]);
                objLocacao.DtPrevista = Convert.ToDateTime(dr["DtPrevista"]);
                objLocacao.ValorTotal = Convert.ToDecimal(dr["ValorTotal"]);
                //objLocacao.
            }

            conn.Close();

            return objLocacao;
        }
    }
}
