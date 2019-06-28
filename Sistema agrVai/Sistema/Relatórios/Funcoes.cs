using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Relatórios
{
    public class Funcoes
    {
        public static string diretorioPasta()
        {
            string folder = @"c:\RelAutoPecas";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

        public static string diretorioPastaVendas()
        {
            string folder = @"c:\RelAutoPecasVendas";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }


        
    }
}
