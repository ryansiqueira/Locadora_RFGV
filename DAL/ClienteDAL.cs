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

            string sql = "INSERT INTO Clientes (NmCliente, DtNascimento, Sexo, DsEstadoCivil, RG, CPF, Endereco, Cidade, Cep, Estado, Telefone, Celular, Email, DsStatus) VALUES (@NmCliente, @DtNascimento, @Sexo, @DsEstadoCivil, @RG, @CPF, @Endereco, @Cidade, @Cep, @Estado, @Telefone, @Celular, @Email, @DsStatus)";


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

        public void AtualizarCliente(Cliente objCliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = @"UPDATE Clientes SET 
                    NmCliente = @NmCliente, 
                    DtNascimento = @DtNascimento, 
                    Sexo = @Sexo, 
                    DsEstadoCivil = @DsEstadoCivil, 
                    RG = @RG, 
                    CPF = @CPF, 
                    Endereco = @Endereco, 
                    Cidade = @Cidade, 
                    Cep = @Cep, 
                    Estado = @Estado, 
                    Telefone = @Telefone, 
                    Celular = @Celular, 
                    Email = @Email, 
                    DsStatus = @DsStatus
                    WHERE CdCliente = @CdCliente";


            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CdCliente", objCliente.CdCliente);
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

        public void DeletarCliente(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = @"DELETE FROM Clientes WHERE CdCliente = @CodigoCliente";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CodigoCliente", id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Cliente GetCliente(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = @"SELECT * FROM Clientes WHERE CdCliente = @CodigoCliente";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@CodigoCliente", id);

            SqlDataReader dr = cmd.ExecuteReader();
            Cliente objCliente = null;
            if (dr.HasRows && dr.Read())
            {
                objCliente = new Cliente();

                objCliente.CdCliente = Convert.ToInt32(dr["CdCliente"]);
                objCliente.NmCliente = dr["NmCliente"].ToString();
                objCliente.DtNascimento = Convert.ToDateTime(dr["DtNascimento"].ToString());
                objCliente.CPF = dr["CPF"].ToString();
                objCliente.DsEstadoCivil = dr["DsEstadoCivil"].ToString();
                objCliente.Email = dr["Email"].ToString();
                objCliente.Endereco = dr["Endereco"].ToString();
                objCliente.DsStatus = dr["DsStatus"].ToString();
                objCliente.Cidade = dr["Cidade"].ToString();
                objCliente.RG = dr["RG"].ToString();
                objCliente.Estado = dr["Estado"].ToString();
                objCliente.CEP = dr["CEP"].ToString();
                objCliente.Celular = dr["Celular"].ToString();
                objCliente.Telefone = dr["Telefone"].ToString();
                objCliente.Sexo = dr["Sexo"].ToString();
            }
            conn.Close();
            return objCliente;
        }

        public Cliente GetClientePorCPF(string cpf)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = @"SELECT * FROM Clientes WHERE CPF = @cpf";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cpf", cpf);

            SqlDataReader dr = cmd.ExecuteReader();
            Cliente objCliente = null;
            if (dr.HasRows && dr.Read())
            {
                objCliente = new Cliente();

                objCliente.CdCliente = Convert.ToInt32(dr["CdCliente"]);
                objCliente.NmCliente = dr["NmCliente"].ToString();
                objCliente.DtNascimento = Convert.ToDateTime(dr["DtNascimento"].ToString());
                objCliente.CPF = dr["CPF"].ToString();
                objCliente.DsEstadoCivil = dr["DsEstadoCivil"].ToString();
                objCliente.Email = dr["Email"].ToString();
                objCliente.Endereco = dr["Endereco"].ToString();
                objCliente.DsStatus = dr["DsStatus"].ToString();
                objCliente.Cidade = dr["Cidade"].ToString();
                objCliente.RG = dr["RG"].ToString();
                objCliente.Estado = dr["Estado"].ToString();
                objCliente.CEP = dr["CEP"].ToString();
                objCliente.Celular = dr["Celular"].ToString();
                objCliente.Telefone = dr["Telefone"].ToString();
                objCliente.Sexo = dr["Sexo"].ToString();
            }
            conn.Close();
            return objCliente;
        }

        public List<Cliente> ListarClientes()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = @"SELECT * FROM Clientes";

            SqlCommand cmd = new SqlCommand(sql, conn);

            List<Cliente> lista = new List<Cliente>();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows )
            {
                Cliente objCliente;
                while (dr.Read())
                {
                    objCliente = new Cliente();

                    objCliente.CdCliente = Convert.ToInt32(dr["CdCliente"]);
                    objCliente.NmCliente = dr["NmCliente"].ToString();
                    objCliente.DtNascimento = Convert.ToDateTime(dr["DtNascimento"].ToString());
                    objCliente.CPF = dr["CPF"].ToString();
                    objCliente.DsEstadoCivil = dr["DsEstadoCivil"].ToString();
                    objCliente.Email = dr["Email"].ToString();
                    objCliente.Endereco = dr["Endereco"].ToString();
                    objCliente.DsStatus = dr["DsStatus"].ToString();
                    objCliente.Cidade = dr["Cidade"].ToString();
                    objCliente.RG = dr["RG"].ToString();
                    objCliente.Estado = dr["Estado"].ToString();
                    objCliente.CEP = dr["CEP"].ToString();
                    objCliente.Celular = dr["Celular"].ToString();
                    objCliente.Telefone = dr["Telefone"].ToString();
                    objCliente.Sexo = dr["Sexo"].ToString(); 

                    lista.Add(objCliente);
                }

            }
            conn.Close();
            return lista;
        }
    }
}
