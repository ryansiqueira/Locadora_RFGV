using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;







        public void CadastroCliente(Cliente objCliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Cliente (NmCliente, DtNascimento, Sexo, DsEstadoCivil, RG, CPF, Endereco, Cidade, Cep, Estado, Telefone, Celular, Email, DsStatus) VALUES (@NmCliente, @DtNascimento, @Sexo, @DsEstadoCivil, @RG, @CPF, @Endereco, @Cidade, @Cep, @Estado, @Telefone, @Celular, @Email, @DsStatus)";


            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@NmCliente", objCliente.NmCliente);
            cmd.Parameters.AddWithValue("@DtNascimento", objCliente.DtNascimento);
            cmd.Parameters.AddWithValue("@Sexo", objCliente.Sexo);
            cmd.Parameters.AddWithValue("@DsEstadoCivil", objCliente.DsEstadoCivil);
            cmd.Parameters.AddWithValue("@RG", objCliente.RG);
            cmd.Parameters.AddWithValue("@CPF", objCliente.CPF);
            cmd.Parameters.AddWithValue("@Endereco", objCliente.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", objCliente.Cidade);
            cmd.Parameters.AddWithValue("@Cep", objCliente.CEP);
            cmd.Parameters.AddWithValue("@Estado", objCliente.Estado);
            cmd.Parameters.AddWithValue("@Telefone", objCliente.Telefone);
            cmd.Parameters.AddWithValue("@Celular", objCliente.Celular);
            cmd.Parameters.AddWithValue("@Email", objCliente.Email);
            cmd.Parameters.AddWithValue("@DsStatus", objCliente.DsStatus);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
