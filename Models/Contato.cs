using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contato
    {
        public int CdContato { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataMensagem { get; set; }
    }
}
