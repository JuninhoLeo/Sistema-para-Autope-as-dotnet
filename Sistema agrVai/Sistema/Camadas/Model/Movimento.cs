using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.Model
{
    public class Movimento
    {
        public int id { get; set; }
        public string Vendedor { get; set; }
        public int QtdeProduto { get; set; }
        public  int Vendido { get; set; }
        public float lucro { get; set; }
        public float RedimentoPorc { get; set; }
    }
}
