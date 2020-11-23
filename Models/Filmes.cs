using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Filmes
    {
        public int Codigo { get; set; }
        public int CodigoBarras { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
        public char Tipo { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataAdquirida { get; set; }
        public decimal ValorCusto { get; set; }
        public char Situacao { get; set; }

        public bool CheckSituacao { get; set; }
        public string Atores { get; set; }
        public string Diretor { get; set; }
        public byte[] CapaFilme { get; set; }

        public string Caminho { get; set; }

    }
}
