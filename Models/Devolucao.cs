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
        public decimal Multa { get; set; }
        public decimal ValorTotal { get; set; }
        public string Pagamento { get; set; }
    }
}
