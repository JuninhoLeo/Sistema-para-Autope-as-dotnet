using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Relatórios
{
    public class RelProdutos
    {
        public static void impRelProdutos()
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> lsProdutos = new List<Camadas.Model.Produto>();
            lsProdutos = bllProd.Select();
            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelProduto.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html;charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<h1>Relatório de Produtos</h1>");

                sw.WriteLine("<hr align='left' border: '5px' />");

                sw.WriteLine("<table class='table table-striped'>");

                sw.WriteLine("<tr class='bg-info'>");
                sw.WriteLine("<th scope = 'col'> ID</th>");
                sw.WriteLine("<th scope = 'col'>Descrição</td>");
                sw.WriteLine("<th scope = 'col'>Modelo</td>");
                sw.WriteLine("<th scope = 'col'>Ano</td>");
                sw.WriteLine("<th scope = 'col'>Quantidade</td>");
                sw.WriteLine("<th scope = 'col'>Valor</td>");
                sw.WriteLine("<th scope = 'col'>Total</td>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float somaGeral = 0, Total;
                foreach (Camadas.Model.Produto Produto in lsProdutos)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-light'>");
                    else sw.WriteLine("<tr class='table-secondary'>");

                    sw.WriteLine("<td>" + Produto.id + "</td>");
                    sw.WriteLine("<td>" + Produto.desc_produto + "</td>");
                    sw.WriteLine("<td>" + Produto.Modelo + "</td>");
                    sw.WriteLine("<td>" + Produto.Ano + "</td>");
                    sw.WriteLine("<td>" + Produto.Qtde + "</td>");
                    sw.WriteLine("<td>" + Produto.Valor.ToString("C") + "</th>");
                    Total = Produto.Qtde * Produto.Valor;
                    somaGeral += Total;
                    sw.WriteLine("<td>" + Total.ToString("C") + "</td>");

                    sw.WriteLine("</tr>");
                    cont++;
                }

                sw.WriteLine("<td class='table-dark' colspan ='7' align='right'>Tota Geral:  " + somaGeral.ToString("C") + " </td>");
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border: '5px' />");
                sw.WriteLine("<h2 h>Total de Registros impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }

        public static void impRelProdutosNome(int num)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> lsProdutos = new List<Camadas.Model.Produto>();
            lsProdutos = bllProd.Selectordenando(1);
            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelProdutoOrdenadoPeloNome.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html;charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<h1>Relatório de Produtos</h1>");

                sw.WriteLine("<hr align='left' border: '5px' />");

                sw.WriteLine("<table class='table table-striped'>");

                sw.WriteLine("<tr class='bg-info'>");
                sw.WriteLine("<th scope = 'col'> ID</th>");
                sw.WriteLine("<th scope = 'col'>Descrição</td>");
                sw.WriteLine("<th scope = 'col'>Modelo</td>");
                sw.WriteLine("<th scope = 'col'>Ano</td>");
                sw.WriteLine("<th scope = 'col'>Quantidade</td>");
                sw.WriteLine("<th scope = 'col'>Valor</td>");
                sw.WriteLine("<th scope = 'col'>Total</td>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float somaGeral = 0, Total;
                foreach (Camadas.Model.Produto Produto in lsProdutos)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-light'>");
                    else sw.WriteLine("<tr class='table-secondary'>");

                    sw.WriteLine("<td>" + Produto.id + "</td>");
                    sw.WriteLine("<td>" + Produto.desc_produto + "</td>");
                    sw.WriteLine("<td>" + Produto.Modelo + "</td>");
                    sw.WriteLine("<td>" + Produto.Ano + "</td>");
                    sw.WriteLine("<td>" + Produto.Qtde + "</td>");
                    sw.WriteLine("<td>" + Produto.Valor.ToString("C") + "</th>");
                    Total = Produto.Qtde * Produto.Valor;
                    somaGeral += Total;
                    sw.WriteLine("<td>" + Total.ToString("C") + "</td>");

                    sw.WriteLine("</tr>");
                    cont++;
                }

                sw.WriteLine("<td class='table-dark' colspan ='7' align='right'>Tota Geral:  " + somaGeral.ToString("C") + " </td>");
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border: '5px' />");
                sw.WriteLine("<h2 h>Total de Registros impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }


        public static void impRelProdutosQtde(int Qtde,int tipo)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> lstProdutos = new List<Camadas.Model.Produto>();
            lstProdutos = bllProd.Selectordenando(tipo);

            lstProdutos = lstProdutos.Where(p => p.Qtde <= Qtde).ToList();
            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelProdutoOrdenadoPelaQuantidade.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html;charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<h1>Relatório de Produtos</h1>");

                sw.WriteLine("<hr align='left' border: '5px' />");

                sw.WriteLine("<table class='table table-striped'>");

                sw.WriteLine("<tr class='bg-info'>");
                sw.WriteLine("<th scope = 'col'> ID</th>");
                sw.WriteLine("<th scope = 'col'>Descrição</td>");
                sw.WriteLine("<th scope = 'col'>Modelo</td>");
                sw.WriteLine("<th scope = 'col'>Ano</td>");
                sw.WriteLine("<th scope = 'col'>Quantidade</td>");
                sw.WriteLine("<th scope = 'col'>Valor</td>");
                sw.WriteLine("<th scope = 'col'>Total</td>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float somaGeral = 0, Total;
                foreach (Camadas.Model.Produto Produto in lstProdutos)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-light'>");
                    else sw.WriteLine("<tr class='table-secondary'>");

                    sw.WriteLine("<td>" + Produto.id + "</td>");
                    sw.WriteLine("<td>" + Produto.desc_produto + "</td>");
                    sw.WriteLine("<td>" + Produto.Modelo + "</td>");
                    sw.WriteLine("<td>" + Produto.Ano + "</td>");
                    sw.WriteLine("<td>" + Produto.Qtde + "</td>");
                    sw.WriteLine("<td>" + Produto.Valor.ToString("C") + "</th>");
                    Total = Produto.Qtde * Produto.Valor;
                    somaGeral += Total;
                    sw.WriteLine("<td>" + Total.ToString("C") + "</td>");

                    sw.WriteLine("</tr>");
                    cont++;
                }

                sw.WriteLine("<td class='table-dark' colspan ='7' align='right'>Tota Geral:  " + somaGeral.ToString("C") + " </td>");
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border: '5px' />");
                sw.WriteLine("<h2 h>Total de Registros impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }


        public static void impRelProdutosValor(float vlr,int tipo)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            List<Camadas.Model.Produto> lstProdutos = new List<Camadas.Model.Produto>();
            lstProdutos = bllProd.Selectordenando(tipo);

            lstProdutos = lstProdutos.Where(p => p.Valor <= vlr).ToList();
            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\RelProdutoOrdenadoPorValor_Ate.html";
            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html;charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<h1>Relatório de Produtos</h1>");

                sw.WriteLine("<hr align='left' border: '5px' />");

                sw.WriteLine("<table class='table table-striped'>");

                sw.WriteLine("<tr class='bg-info'>");
                sw.WriteLine("<th scope = 'col'> ID</th>");
                sw.WriteLine("<th scope = 'col'>Descrição</td>");
                sw.WriteLine("<th scope = 'col'>Modelo</td>");
                sw.WriteLine("<th scope = 'col'>Ano</td>");
                sw.WriteLine("<th scope = 'col'>Quantidade</td>");
                sw.WriteLine("<th scope = 'col'>Valor</td>");
                sw.WriteLine("<th scope = 'col'>Total</td>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float somaGeral = 0, Total;
                foreach (Camadas.Model.Produto Produto in lstProdutos)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-light'>");
                    else sw.WriteLine("<tr class='table-secondary'>");

                    sw.WriteLine("<td>" + Produto.id + "</td>");
                    sw.WriteLine("<td>" + Produto.desc_produto + "</td>");
                    sw.WriteLine("<td>" + Produto.Modelo + "</td>");
                    sw.WriteLine("<td>" + Produto.Ano + "</td>");
                    sw.WriteLine("<td>" + Produto.Qtde + "</td>");
                    sw.WriteLine("<td>" + Produto.Valor.ToString("C") + "</th>");
                    Total = Produto.Qtde * Produto.Valor;
                    somaGeral += Total;
                    sw.WriteLine("<td>" + Total.ToString("C") + "</td>");

                    sw.WriteLine("</tr>");
                    cont++;
                }

                sw.WriteLine("<td class='table-dark' colspan ='7' align='right'>Tota Geral:  " + somaGeral.ToString("C") + " </td>");
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align='left' border: '5px' />");
                sw.WriteLine("<h2 h>Total de Registros impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }


    }
}
