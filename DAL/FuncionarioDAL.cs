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

            string sql = "INSERT INTO Funcionarios VALUES(@nm,@CPF,@nas,@estciv,@sexo,@email,@telefone,@rg,@ende,@cid,@cep,@esta,@celula,@status)";

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

            string sql = "DELETE FROM Funcionarios WHERE CdFuncionario = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", CdFuncionario);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AtualizaFuncionario(Funcionarios func)
        {          
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Funcionarios SET NmFuncionario = @nm, CPF = @CPF, DtNascimento = @nas, DsEstadoCivil = @estciv,Sexo = @sexo, Email = @email," +
                "Telefone = @telefone, RG = @rg, Endereco = @ende, Cidade = @cid, CEP = @cep, Estado = @esta, Celular = @celula, DsStatus = @status" +
                " WHERE CdFuncionario = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", func.CdFuncionario);
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

        public Funcionarios ObterFuncionarioCPF(string cpf)
        {
            Funcionarios func = null;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sqlcpf = "SELECT * FROM Funcionarios WHERE CPF = @cpf";

            SqlCommand cmdcpf = new SqlCommand(sqlcpf, conn);
            cmdcpf.Parameters.AddWithValue("@cpf", cpf);

            SqlDataReader drcpf = cmdcpf.ExecuteReader();

            if (drcpf.HasRows && drcpf.Read())
            {
                func = new Funcionarios();
                func.CdFuncionario = Convert.ToInt32(drcpf["CdFuncionario"]);
                func.NmFuncionario = Convert.ToString(drcpf["NmFuncionario"]);
                func.CPF = Convert.ToString(drcpf["CPF"]);
                func.DtNascimento = Convert.ToDateTime(drcpf["DtNascimento"]);
                func.EstadoCivil = Convert.ToChar(drcpf["DsEstadoCivil"]);
                func.Sexo = Convert.ToChar(drcpf["Sexo"]);
                func.Email = Convert.ToString(drcpf["Email"]);
                func.Telefone = Convert.ToString(drcpf["Telefone"]);
                func.RG = Convert.ToString(drcpf["RG"]);
                func.Endereco = Convert.ToString(drcpf["Endereco"]);
                func.Cidade = Convert.ToString(drcpf["Cidade"]);
                func.CEP = Convert.ToString(drcpf["CEP"]);
                func.Estado = Convert.ToString(drcpf["Estado"]);
                func.Celular = Convert.ToString(drcpf["Celular"]);
                func.DsStatus = Convert.ToBoolean(drcpf["DsStatus"]);
            }

            conn.Close();

            return func;
        }

        public Funcionarios ObterFuncionarioCod(int CdFuncionario)
        {
            Funcionarios func = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sqlcod = "SELECT * FROM Funcionarios WHERE CdFuncionario = @cod";

            SqlCommand cmd = new SqlCommand(sqlcod, conn);
            cmd.Parameters.AddWithValue("@cod", CdFuncionario);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows && dr.Read())
            {
                func = new Funcionarios();
                func.CdFuncionario = Convert.ToInt32(dr["CdFuncionario"]);
                func.NmFuncionario = Convert.ToString(dr["NmFuncionario"]);
                func.CPF = Convert.ToString(dr["CPF"]);
                func.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                func.EstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
                func.Sexo = Convert.ToChar(dr["Sexo"]);
                func.Email = Convert.ToString(dr["Email"]);
                func.Telefone = Convert.ToString(dr["Telefone"]);
                func.RG = Convert.ToString(dr["RG"]);
                func.Endereco = Convert.ToString(dr["Endereco"]);
                func.Cidade = Convert.ToString(dr["Cidade"]);
                func.CEP = Convert.ToString(dr["CEP"]);
                func.Estado = Convert.ToString(dr["Estado"]);
                func.Celular = Convert.ToString(dr["Celular"]);
                func.DsStatus = Convert.ToBoolean(dr["DsStatus"]);
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
                    func.CdFuncionario = Convert.ToInt32(dr["CdFuncionario"]);
                    func.NmFuncionario = Convert.ToString(dr["NmFuncionario"]);
                    func.CPF = Convert.ToString(dr["CPF"]);
                    func.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                    func.EstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
                    func.Sexo = Convert.ToChar(dr["Sexo"]);
                    func.Email = Convert.ToString(dr["Email"]);
                    func.Telefone = Convert.ToString(dr["Telefone"]);
                    func.RG = Convert.ToString(dr["RG"]);
                    func.Endereco = Convert.ToString(dr["Endereco"]);
                    func.Cidade = Convert.ToString(dr["Cidade"]);
                    func.CEP = Convert.ToString(dr["CEP"]);
                    func.Estado = Convert.ToString(dr["Estado"]);
                    func.Celular = Convert.ToString(dr["Celular"]);
                    func.DsStatus = Convert.ToBoolean(dr["DsStatus"]);

                    ListaFunc.Add(func);
                }
            }

            conn.Close();

            return ListaFunc;
        }
    }
}
