using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        public int CdCliente { get; set; }

        public string NmCliente { get; set; }

        public DateTime DtNascimento { get; set; }

        public string CPF { get; set; }

        public string Sexo { get; set; }

        public string DsEstadoCivil { get; set; }

        public string RG { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public string DsStatus { get; set; }
    }
}
