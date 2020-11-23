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
        public int CodigoBarrasFilmes { get; set; }
        public DateTime DatadeEntrega { get; set; }
        public decimal ValorTotal { get; set; }
        public char Pagamento { get; set; }
        public int CdItem { get; set; }
        public int CdLocacao { get; set; }
        public bool Recebido { get; set; }
    }
}
