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

            string sql = "INSERT INTO Devolucao VALUES (@Locacao, @dataprevista, @dataentrega, @valortotal, @valorpago, @pagamento, @recebido )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Locacao", objDevolucao.CdLocacao);
            cmd.Parameters.AddWithValue("@dataprevista", objDevolucao.DataPrevista);
            cmd.Parameters.AddWithValue("@dataentrega", objDevolucao.DatadeEntrega);
            cmd.Parameters.AddWithValue("@valortotal", objDevolucao.ValorTotal);
            cmd.Parameters.AddWithValue("@valorpago", objDevolucao.ValorPago);
            cmd.Parameters.AddWithValue("@pagamento", objDevolucao.Pagamento);
            cmd.Parameters.AddWithValue("@recebido", objDevolucao.Recebido);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Locacao BuscarLocacao (int codigoLocacao)
        {
            Locacao objLocacao = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT CdLocacao, DtPrevista, ValorTotal, DsStatusPg, DsRecebido FROM Locacao WHERE CdLocacao = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigoLocacao);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objLocacao = new Locacao();
                objLocacao.CdLocacao = Convert.ToInt32(dr["CdLocacao"]);
            }

            conn.Close();

            return objLocacao;
        }
    }
}
