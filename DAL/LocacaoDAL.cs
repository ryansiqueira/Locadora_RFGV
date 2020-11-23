using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Models;
using System.Data;

namespace DAL
{
    public class LocacaoDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;

        public void InserirLocacao(Locacao locacao)
        {           
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            
            string sql = "INSERT INTO Locacao VALUES (@CdLocacao, @CdItens, @FKCliente, @DtAtual, @DtPrevista, @ValorTotal, @DsStatusPg, @ValorRecebido, @DsRecebido)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CdLocacao", locacao.CdLocacao);
            cmd.Parameters.AddWithValue("@CdItens", locacao.CdItens);
            cmd.Parameters.AddWithValue("@FKCliente", locacao.FKCliente);
            cmd.Parameters.AddWithValue("@DtAtual", locacao.DtAtual);
            cmd.Parameters.AddWithValue("@DtPrevista", locacao.DtPrevista);
            cmd.Parameters.AddWithValue("@ValorTotal", locacao.ValorTotal);
            cmd.Parameters.AddWithValue("@DsStatusPg", locacao.DsStatusPg);
            cmd.Parameters.AddWithValue("@ValorRecebido", locacao.ValorRecebido);
            cmd.Parameters.AddWithValue("@DsRecebido", locacao.DsRecebido);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Cliente ObterClienteLocacao(int CdCliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT CdCliente, NmCliente, CPF FROM Clientes WHERE CdCliente = @CodigoCliente";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CodigoCliente", CdCliente);

            SqlDataReader dr = cmd.ExecuteReader();
            Cliente Cliente = null;

            if (dr.HasRows && dr.Read())
            {
                Cliente = new Cliente();

                Cliente.CdCliente = Convert.ToInt32(dr["CdCliente"]);
                Cliente.NmCliente = dr["NmCliente"].ToString();                
                Cliente.CPF = dr["CPF"].ToString();                
            }
            conn.Close();
            return Cliente;
        }

        public Funcionarios ObterFuncionarioLocacao(int CdFuncionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT CdFuncionario, NmFuncionario, CPF FROM Funcionarios WHERE CdFuncionario = @CdFuncionario";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CdFuncionario", CdFuncionario);

            SqlDataReader dr = cmd.ExecuteReader();
            Funcionarios func = null;

            if (dr.HasRows && dr.Read())
            {
                func = new Funcionarios();

                func.CdFuncionario = Convert.ToInt32(dr["CdFuncionario"]);
                func.NmFuncionario = dr["NmFuncionario"].ToString();
                func.CPF = dr["CPF"].ToString();
            }
            conn.Close();
            return func;
        }

        public Filmes ObterItensBarras(int CodigoBarras)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT CdItem ,Titulo, Preco FROM Itens WHERE CodigoBarras = @CodigoBarras";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CodigoBarras", CodigoBarras);

            SqlDataReader dr = cmd.ExecuteReader();
            Filmes film = null;

            if (dr.HasRows && dr.Read())
            {
                film = new Filmes();

                film.Codigo = Convert.ToInt32(dr["CdItem"]);
                film.Titulo = dr["Titulo"].ToString();
                film.Preco = Convert.ToDecimal(dr["Preco"]);                
            }
            conn.Close();
            return film;
        }

        public void ExcluirLocacao(int CdLocacao)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            
            conn.Open();

            string sql = "DELETE FROM Locacao WHERE CdLocacao = @CdLocacao";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CdLocacao", CdLocacao);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
