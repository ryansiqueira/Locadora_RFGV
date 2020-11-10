using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Configuration;
//using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace DAL
{
    public class FuncionarioDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;

        public void InserirFuncionarios(Funcionarios func)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Funcionarios VALUES(@nm,@CPF,@nas,@estciv,@sexo,@email,@telefone,@rg,@ende,@cid,@cep,@esta,@celula,@status";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nm", func.NmFuncionario);
            cmd.Parameters.AddWithValue("@CPF", func.CPF);
            cmd.Parameters.AddWithValue("@nas", func.DtNascimento);
            cmd.Parameters.AddWithValue("@estciv", func.EstadoCivil);
            cmd.Parameters.AddWithValue("@sexo", func.Sexo);
            cmd.Parameters.AddWithValue("@email", func.Email);
            cmd.Parameters.AddWithValue("@telefone", func.Telefone);
            cmd.Parameters.AddWithValue("@rg", func.RG);
            cmd.Parameters.AddWithValue("@ende", func.Endereco);
            cmd.Parameters.AddWithValue("@cid", func.Cidade);
            cmd.Parameters.AddWithValue("@cep", func.CEP);
            cmd.Parameters.AddWithValue("@esta", func.Estado);
            cmd.Parameters.AddWithValue("@celula", func.Celular);
            cmd.Parameters.AddWithValue("@status", func.DsStatus);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void ExcluirFuncionario(int CdFuncionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Funcionarios WHERE CdFuncionarios = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", CdFuncionario);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AtualizaFuncionario(int CdFuncionario)
        {
            Funcionarios func = new Funcionarios();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Funcionarios SET NmFuncionario = @nm, CPF = @CPF, DtNascimentos = @nas, DsEstadoCivil = @estciv,Sexo = @sexo, Email = @email," +
                "Telefone = @telefone, RG = @rg, Endereco = @ende, Cidade = @cid, CEP = @cep, Estado = @esta, Celular = @celula, DsStatus = @status" +
                "WHERE CdFuncionario = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", CdFuncionario);
            cmd.Parameters.AddWithValue("@nm", func.NmFuncionario);
            cmd.Parameters.AddWithValue("@CPF", func.CPF);
            cmd.Parameters.AddWithValue("@nas", func.DtNascimento);
            cmd.Parameters.AddWithValue("@estciv", func.EstadoCivil);
            cmd.Parameters.AddWithValue("@sexo", func.Sexo);
            cmd.Parameters.AddWithValue("@email", func.Email);
            cmd.Parameters.AddWithValue("@telefone", func.Telefone);
            cmd.Parameters.AddWithValue("@rg", func.RG);
            cmd.Parameters.AddWithValue("@ende", func.Endereco);
            cmd.Parameters.AddWithValue("@cid", func.Cidade);
            cmd.Parameters.AddWithValue("@cep", func.CEP);
            cmd.Parameters.AddWithValue("@esta", func.Estado);
            cmd.Parameters.AddWithValue("@celula", func.Celular);
            cmd.Parameters.AddWithValue("@status", func.DsStatus);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Funcionarios ObterFuncionario(int CdFuncionario, int cpf)
        {
            Funcionarios func = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sqlcod = "SELECT * FROM Funcionarios WHERE CdFuncionarios = @cod";

            SqlCommand cmd = new SqlCommand(sqlcod, conn);
            cmd.Parameters.AddWithValue("@cod", CdFuncionario);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows && dr.Read())
            {
                func = new Funcionarios();
                func.CdFuncionario = Convert.ToInt32(dr["CdFuncionarios"]);
                func.NmFuncionario = Convert.ToString(dr["NmFuncionarios"]);
                func.CPF = Convert.ToString(dr["CPF"]);
                func.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                func.EstadoCivil = Convert.ToChar(dr["EstadoCilvil"]);
                func.Sexo = Convert.ToChar(dr["Sexo"]);
                func.Email = Convert.ToString(dr["Email"]);
                func.Telefone = Convert.ToString(dr["Telefone"]);
                func.RG = Convert.ToString(dr["RG"]);
                func.Endereco = Convert.ToString(dr["Endereco"]);
                func.Cidade = Convert.ToString(dr["Cidade"]);
                func.CEP = Convert.ToString(dr["CEP"]);
                func.Estado = Convert.ToString(dr["Estado"]);
                func.Celular = Convert.ToString(dr["Celular"]);
                func.DsStatus = Convert.ToString(dr["DsStatus"]);
            }

            string sqlcpf = "SELECT * FROM Funcionarios WHERE CdFuncionarios = @cpf";

            SqlCommand cmdcpf = new SqlCommand(sqlcpf, conn);
            cmd.Parameters.AddWithValue("@cpf", cpf);

            SqlDataReader drcpf = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                func = new Funcionarios();
                func.CdFuncionario = Convert.ToInt32(dr["CdFuncionarios"]);
                func.NmFuncionario = Convert.ToString(dr["NmFuncionarios"]);
                func.CPF = Convert.ToString(dr["CPF"]);
                func.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                func.EstadoCivil = Convert.ToChar(dr["EstadoCilvil"]);
                func.Sexo = Convert.ToChar(dr["Sexo"]);
                func.Email = Convert.ToString(dr["Email"]);
                func.Telefone = Convert.ToString(dr["Telefone"]);
                func.RG = Convert.ToString(dr["RG"]);
                func.Endereco = Convert.ToString(dr["Endereco"]);
                func.Cidade = Convert.ToString(dr["Cidade"]);
                func.CEP = Convert.ToString(dr["CEP"]);
                func.Estado = Convert.ToString(dr["Estado"]);
                func.Celular = Convert.ToString(dr["Celular"]);
                func.DsStatus = Convert.ToString(dr["DsStatus"]);
            }

            conn.Close();

            return func;
        }

        public List<Funcionarios> ListarFuncionarios()
        {
            List<Funcionarios> ListaFunc = new List<Funcionarios>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Funcionarios";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Funcionarios func;

                while (dr.Read())
                {
                    func = new Funcionarios();
                    func.CdFuncionario = Convert.ToInt32(dr["CdFuncionarios"]);
                    func.NmFuncionario = Convert.ToString(dr["NmFuncionarios"]);
                    func.CPF = Convert.ToString(dr["CPF"]);
                    func.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                    func.EstadoCivil = Convert.ToChar(dr["EstadoCilvil"]);
                    func.Sexo = Convert.ToChar(dr["Sexo"]);
                    func.Email = Convert.ToString(dr["Email"]);
                    func.Telefone = Convert.ToString(dr["Telefone"]);
                    func.RG = Convert.ToString(dr["RG"]);
                    func.Endereco = Convert.ToString(dr["Endereco"]);
                    func.Cidade = Convert.ToString(dr["Cidade"]);
                    func.CEP = Convert.ToString(dr["CEP"]);
                    func.Estado = Convert.ToString(dr["Estado"]);
                    func.Celular = Convert.ToString(dr["Celular"]);
                    func.DsStatus = Convert.ToString(dr["DsStatus"]);

                    ListaFunc.Add(func);
                }
            }

            conn.Close();

            return ListaFunc;
        }
    }
}
