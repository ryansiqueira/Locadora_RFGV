﻿using System;
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
        public int Preco { get; set; }
        public DateTime DataAdquirida { get; set; }
        public int ValorCusto { get; set; }
        public string Situacao { get; set; }
        public string Atores { get; set; }
        public string Diretor { get; set; }
        public string FotoFilme { get; set; }
    }
}