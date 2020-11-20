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

    }
}
