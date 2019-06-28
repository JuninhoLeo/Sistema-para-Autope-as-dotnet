using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.Model
{
    public class Venda
    {
        public int id_Venda { get; set; }
        public string Cliente { get; set; }
        public string Produto { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Qtde { get; set; }
        public float Valor { get; set; }
    }
}
