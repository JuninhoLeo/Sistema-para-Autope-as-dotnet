using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Relatórios
{
    class RelVendas
    {
        public static void impRelVendas()
        {
            Camadas.DAL.Movimento vendasRealizadas = new Camadas.DAL.Movimento();
            List<Camadas.Model.Movimento> lsVenda = new List<Camadas.Model.Movimento>();
            lsVenda = vendasRealizadas.Select();
            string folder = Funcoes.diretorioPastaVendas();
            string arquivo = folder + @"\RelTodasVendasRealizadas.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using(sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html;charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<h1>Relatório de Vendas</h1>");

                sw.WriteLine("<hr align='left' border: '5px' />");

                sw.WriteLine("<table class='table table-striped'>");

                sw.WriteLine("<tr class='bg-info'>");
                sw.WriteLine("<th scope = 'col'> </th>");
                sw.WriteLine("<th scope = 'col'>Vendedor</td>");
                sw.WriteLine("<th scope = 'col'>Quantidade Vendidos Por Vendedor</td>");
                sw.WriteLine("<th scope = 'col'> Meta Alcançada</td>");
                sw.WriteLine("<th scope = 'col'>Lucro</td>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float somaGeral = 0, Total;
                Camadas.DAL.Movimento movimento = new Camadas.DAL.Movimento();

                foreach (Camadas.Model.Movimento VndRelalizada in lsVenda)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-light'>");
                    else sw.WriteLine("<tr class='table-secondary'>");

                    
                    

                    float QtdeVendido = movimento.SelectQuantidade();
                    float Rendimento = VndRelalizada.Vendido;

                    float Resultado = Rendimento/QtdeVendido * 100;

                    sw.WriteLine("<td></td>");
                    sw.WriteLine("<td>" + VndRelalizada.Vendedor + "</td>");
                    sw.WriteLine("<td>" + VndRelalizada.Vendido +"</td>");
                    sw.WriteLine("<td>" + Resultado + "%</td>");
                    sw.WriteLine("<td>" + VndRelalizada.lucro.ToString("C") + "</td>");

                    Total = VndRelalizada.lucro + VndRelalizada.lucro;
                    somaGeral += Total;
                    sw.WriteLine("</tr>");
                    cont++;
                }
              
                sw.WriteLine("<td class='table-dark' colspan ='10' align='right'>Tota Geral:  " + somaGeral.ToString("C") + " </td>");
                sw.WriteLine("</table>");

                sw.WriteLine("<table>");
                sw.WriteLine("<th scope = 'col'>Total De Produtos Vendidos em Geral:  " + movimento.SelectQuantidade() + " </td>");
                sw.WriteLine("</table>");

                sw.WriteLine("<hr align='left' border: '5px' />");
                sw.WriteLine("<h2 h>Total de Vendedores impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }

        public static void impRelVendasMaior(int Qtde)
        {
            Camadas.DAL.Movimento vendasRealizadas = new Camadas.DAL.Movimento();
            List<Camadas.Model.Movimento> lsVenda = new List<Camadas.Model.Movimento>();
            lsVenda = vendasRealizadas.Select();

            lsVenda = lsVenda.Where(v => v.Vendido >= Qtde).ToList();

            string folder = Funcoes.diretorioPastaVendas();
            string arquivo = folder + @"\RelTodasVendasRealizadas.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html;charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<h1>Relatório de Vendas</h1>");

                sw.WriteLine("<hr align='left' border: '5px' />");

                sw.WriteLine("<table class='table table-striped'>");

                sw.WriteLine("<tr class='bg-info'>");
                sw.WriteLine("<th scope = 'col'> </th>");
                sw.WriteLine("<th scope = 'col'>Vendedor</td>");
                sw.WriteLine("<th scope = 'col'>Quantidade Vendidos Por Vendedor</td>");
                sw.WriteLine("<th scope = 'col'> Meta Alcançada</td>");
                sw.WriteLine("<th scope = 'col'>Lucro</td>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float somaGeral = 0, Total;
                Camadas.DAL.Movimento movimento = new Camadas.DAL.Movimento();

                foreach (Camadas.Model.Movimento VndRelalizada in lsVenda)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-light'>");
                    else sw.WriteLine("<tr class='table-secondary'>");




                    float QtdeVendido = movimento.SelectQuantidade();
                    float Rendimento = VndRelalizada.Vendido;

                    float Resultado = Rendimento / QtdeVendido * 100;

                    sw.WriteLine("<td></td>");
                    sw.WriteLine("<td>" + VndRelalizada.Vendedor + "</td>");
                    sw.WriteLine("<td>" + VndRelalizada.Vendido + "</td>");
                    sw.WriteLine("<td>" + Resultado + "%</td>");
                    sw.WriteLine("<td>" + VndRelalizada.lucro.ToString("C") + "</td>");

                    Total = VndRelalizada.lucro + VndRelalizada.lucro;
                    somaGeral += Total;
                    sw.WriteLine("</tr>");
                    cont++;
                }

                sw.WriteLine("<td class='table-dark' colspan ='10' align='right'>Tota Geral:  " + somaGeral.ToString("C") + " </td>");
                sw.WriteLine("</table>");

                sw.WriteLine("<table>");
                sw.WriteLine("<th scope = 'col'>Total De Produtos Vendidos em Geral:  " + movimento.SelectQuantidade() + " </td>");
                sw.WriteLine("</table>");

                sw.WriteLine("<hr align='left' border: '5px' />");
                sw.WriteLine("<h2 h>Total de Vendedores impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }

        public static void impRelVendasMenor(int Qtde)
        {
            Camadas.DAL.Movimento vendasRealizadas = new Camadas.DAL.Movimento();
            List<Camadas.Model.Movimento> lsVenda = new List<Camadas.Model.Movimento>();
            lsVenda = vendasRealizadas.Select();

            lsVenda = lsVenda.Where(v => v.Vendido <= Qtde).ToList();

            string folder = Funcoes.diretorioPastaVendas();
            string arquivo = folder + @"\RelTodasVendasRealizadas.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html;charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<h1>Relatório de Vendas</h1>");

                sw.WriteLine("<hr align='left' border: '5px' />");

                sw.WriteLine("<table class='table table-striped'>");

                sw.WriteLine("<tr class='bg-info'>");
                sw.WriteLine("<th scope = 'col'> </th>");
                sw.WriteLine("<th scope = 'col'>Vendedor</td>");
                sw.WriteLine("<th scope = 'col'>Quantidade Vendidos Por Vendedor</td>");
                sw.WriteLine("<th scope = 'col'> Meta Alcançada</td>");
                sw.WriteLine("<th scope = 'col'>Lucro</td>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float somaGeral = 0, Total;
                Camadas.DAL.Movimento movimento = new Camadas.DAL.Movimento();

                foreach (Camadas.Model.Movimento VndRelalizada in lsVenda)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-light'>");
                    else sw.WriteLine("<tr class='table-secondary'>");




                    float QtdeVendido = movimento.SelectQuantidade();
                    float Rendimento = VndRelalizada.Vendido;

                    float Resultado = Rendimento / QtdeVendido * 100;

                    sw.WriteLine("<td></td>");
                    sw.WriteLine("<td>" + VndRelalizada.Vendedor + "</td>");
                    sw.WriteLine("<td>" + VndRelalizada.Vendido + "</td>");
                    sw.WriteLine("<td>" + Resultado + "%</td>");
                    sw.WriteLine("<td>" + VndRelalizada.lucro.ToString("C") + "</td>");

                    Total = VndRelalizada.lucro + VndRelalizada.lucro;
                    somaGeral += Total;
                    sw.WriteLine("</tr>");
                    cont++;
                }

                sw.WriteLine("<td class='table-dark' colspan ='10' align='right'>Tota Geral:  " + somaGeral.ToString("C") + " </td>");
                sw.WriteLine("</table>");

                sw.WriteLine("<table>");
                sw.WriteLine("<th scope = 'col'>Total De Produtos Vendidos em Geral:  " + movimento.SelectQuantidade() + " </td>");
                sw.WriteLine("</table>");

                sw.WriteLine("<hr align='left' border: '5px' />");
                sw.WriteLine("<h2 h>Total de Vendedores impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }



    }
}
