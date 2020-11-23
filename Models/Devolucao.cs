using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Devolucao
    {
        public int CdDevolucao { get; set; }
        public DateTime DatadeEntrega { get; set; }
        public DateTime DataPrevista { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }
        public char Pagamento { get; set; }
        public int CdLocacao { get; set; }
        public bool Recebido { get; set; }
    }
}
