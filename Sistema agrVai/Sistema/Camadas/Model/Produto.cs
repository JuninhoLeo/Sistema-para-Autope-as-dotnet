using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.Model
{
    public class Produto
    {
        public int id { get; set; }
        public string desc_produto { get; set; }
        public float Valor { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Qtde { get; set; }
    }
}
