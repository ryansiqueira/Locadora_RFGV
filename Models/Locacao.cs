using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Locacao
    {
        public int CdLocacao { get; set; }
        public int CdItens { get; set; }
        public int FKCliente { get; set; }
        public DateTime DtAtual { get; set; }
        public DateTime DtPrevista { get; set; }
        public decimal ValorTotal { get; set; }
        public char DsStatusPg { get; set; }
        public decimal ValorRecebido { get; set; }
        public bool DsRecebido { get; set; }
    }    
}
