﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class UsuárioDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["BDLocadoraConnectionString"].ConnectionString;

        public bool AutenticarUsuario(string usuario, string senha)
        {
            bool autenticado = false;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT COUNT(*) FROM Usuarios WHERE DsLogin = @login AND DsSenha = @senha";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@login", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            autenticado = Convert.ToInt32(cmd.ExecuteScalar()) == 1;

            conn.Close();

            return autenticado;

        }

        public void CadastroUsuario(Usuario objUsuario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Usuarios VALUES (@usuario, @senha)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@usuario", objUsuario.DsLogin);
            cmd.Parameters.AddWithValue("@senha", objUsuario.DsSenha);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
}
