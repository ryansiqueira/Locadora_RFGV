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

        public void InserirLocacao(Locacao locacao,int QtdeItens)
        {
            

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            for (int i = 0; i <= QtdeItens; i++)
            {
                string sql = "INSERT INTO Locacao VALUES (@CdLocacao, @CdItens, @FKCliente, @DtAtual, @DtPrevista, @ValorTotal, @DsStatusPg, @QtdeItens)";
                SqlCommand cmd = new SqlCommand(sql, conn);
            }      


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

            string sql = "SELECT Titulo, Preco FROM Itens WHERE CodigoBarras = @CodigoBarras";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CodigoBarras", CodigoBarras);

            SqlDataReader dr = cmd.ExecuteReader();
            Filmes film = null;

            if (dr.HasRows && dr.Read())
            {
                film = new Filmes();

                film.Titulo = dr["Titulo"].ToString();
                film.Preco = Convert.ToDecimal(dr["Preco"]);                
            }
            conn.Close();
            return film;
        }

        public DataTable CarregarFilmes()
        {
            SqlConnection sql = new SqlConnection(connectionString);
            sql.Open();
            SqlCommand cmd = new SqlCommand("Select Titulo From Itens", sql);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            DataRow row = table.NewRow();
            row["Titulo"] = "";
            table.Rows.InsertAt(row, 0);

            sql.Close();
            return table;
        }
    }
}
