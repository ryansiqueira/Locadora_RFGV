using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Funcionarios
    {
        public int CdFuncionario { get; set; }
        public string NmFuncionario { get; set; }
        public string CPF { get; set; }
        public DateTime DtNascimento { get; set; }
        public char EstadoCivil { get; set; }
        public char Sexo { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Celular { get; set; }
        public bool DsStatus { get; set; }        
    }
}
