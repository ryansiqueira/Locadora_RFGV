using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class FilmeDAL
    {
        //Pegar o dado de conexão do App.Config ou Web.Config (Arquivos de configuração)
        //private string connectionString = ConfigurationManager.ConnectionStrings["BDSistemaFullConnectionString"].ConnectionString;

        public void InserirPessoa(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Pessoas VALUES (@nome, @cpf, @nasc, @ec, @sexo, @email, @telefone, @recebeSMS, @recebeEmail)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@ec", objPessoa.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
            cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
            cmd.Parameters.AddWithValue("@telefone", objPessoa.NrTelefone);
            cmd.Parameters.AddWithValue("@recebeSMS", objPessoa.BtRecebeSMS);
            cmd.Parameters.AddWithValue("@recebeEmail", objPessoa.BtRecebeEmail);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Pessoa ObterPessoa(int cdPessoa)
        {
            Pessoa pessoa = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Pessoas WHERE CdPessoa = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", cdPessoa);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                pessoa = new Pessoa();
                pessoa.CdPessoa = cdPessoa;
                pessoa.NmPessoa = dr["NmPessoa"].ToString();
                pessoa.NrCPF = dr["NrCPF"].ToString();
                pessoa.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                pessoa.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
                pessoa.DsSexo = Convert.ToChar(dr["DsSexo"]);
                pessoa.DsEmail = dr["DsEmail"].ToString();
                pessoa.NrTelefone = dr["NrTelefone"].ToString();
                pessoa.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
                pessoa.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);
            }

            conn.Close();

            return pessoa;
        }

        public List<Pessoa> ListarPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Pessoas";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {
                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CdPessoa"]);
                    objPessoa.NmPessoa = dr["NmPessoa"].ToString();
                    objPessoa.NrCPF = dr["NrCPF"].ToString();
                    objPessoa.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                    objPessoa.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
                    objPessoa.DsSexo = Convert.ToChar(dr["DsSexo"]);
                    objPessoa.DsEmail = dr["DsEmail"].ToString();
                    objPessoa.NrTelefone = dr["NrTelefone"].ToString();
                    objPessoa.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
                    objPessoa.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);

                    listaPessoas.Add(objPessoa);
                }
            }

            conn.Close();

            return listaPessoas;
        }

        public void AtualizarPessoa(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Pessoas SET NmPessoa = @nome, NrCPF = @cpf, DtNascimento = @nasc, DsEstadoCivil = @ec, DsSexo = @sexo, DsEmail = @email, NrTelefone = @telefone, BtRecebeSMS = @recebeSMS, BtRecebeEmail = @recebeEmail WHERE CdPessoa = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objPessoa.NmPessoa);
            cmd.Parameters.AddWithValue("@cpf", objPessoa.NrCPF);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNascimento);
            cmd.Parameters.AddWithValue("@ec", objPessoa.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
            cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
            cmd.Parameters.AddWithValue("@telefone", objPessoa.NrTelefone);
            cmd.Parameters.AddWithValue("@recebeSMS", objPessoa.BtRecebeSMS);
            cmd.Parameters.AddWithValue("@recebeEmail", objPessoa.BtRecebeEmail);
            cmd.Parameters.AddWithValue("@codigo", objPessoa.CdPessoa);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void ExcluirPessoa(int cdPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Pessoas WHERE CdPessoa = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", cdPessoa);

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public List<Pessoa> ListarPessoasFiltros(string nome, string email)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Pessoas WHERE NmPessoa LIKE @nome AND DsEmail LIKE @email";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
            cmd.Parameters.AddWithValue("@email", $"%{email}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {
                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CdPessoa"]);
                    objPessoa.NmPessoa = dr["NmPessoa"].ToString();
                    objPessoa.NrCPF = dr["NrCPF"].ToString();
                    objPessoa.DtNascimento = Convert.ToDateTime(dr["DtNascimento"]);
                    objPessoa.DsEstadoCivil = Convert.ToChar(dr["DsEstadoCivil"]);
                    objPessoa.DsSexo = Convert.ToChar(dr["DsSexo"]);
                    objPessoa.DsEmail = dr["DsEmail"].ToString();
                    objPessoa.NrTelefone = dr["NrTelefone"].ToString();
                    objPessoa.BtRecebeSMS = Convert.ToBoolean(dr["BtRecebeSMS"]);
                    objPessoa.BtRecebeEmail = Convert.ToBoolean(dr["BtRecebeEmail"]);

                    listaPessoas.Add(objPessoa);
                }
            }

            conn.Close();

            return listaPessoas;
        }

    }
}
}
