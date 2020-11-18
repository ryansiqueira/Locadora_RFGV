using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Artista
    {
        public int CdArtista { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string PaisNascimento { get; set; }
        public byte[] FotodoArtista { get; set; }
    }
}
