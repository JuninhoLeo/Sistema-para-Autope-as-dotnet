using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.DAL
{
    public class Movimento
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Movimento> Select()
        {
            List<Model.Movimento> lstVenda = new List<Model.Movimento>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " select ";
            sql += " Vendas_Rendimento.Vendedor, ";
            sql += " sum(Vendas_Rendimento.QtdeProduto) as'Qtde', ";
            sql += " sum(Vendas_Rendimento.QtdeProduto) as'Vendido', ";
            sql += " sum(Vendas_Rendimento.QtdeProduto) as 'Rendimento porc', ";
            sql += " sum(Vendas_Rendimento.Rendimento) as 'lucro' ";
            sql += " from Venda ";
            sql += " inner join Vendas_Rendimento on (Vendas_Rendimento.vendedor = Venda.Cliente) ";
            sql += " group by Vendas_Rendimento.vendedor ";

            SqlCommand cmd = new SqlCommand(sql,conexao);

           // try
            //{
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Movimento Realizadas = new Model.Movimento();
                    //Realizadas.id = Convert.ToInt32(dados["id"]);
                    Realizadas.Vendedor = dados["Vendedor"].ToString();
                    Realizadas.QtdeProduto = Convert.ToInt32(dados["Qtde"].ToString());
                    Realizadas.Vendido = Convert.ToInt32(dados["Vendido"].ToString());
                    Realizadas.RedimentoPorc = Convert.ToSingle(dados["Rendimento porc"].ToString());
                    Realizadas.lucro = Convert.ToSingle(dados["lucro"].ToString());

                    lstVenda.Add(Realizadas);
                }
           // }
          //  catch
           // {
                Console.WriteLine("Deu erro No select da Venda!!!");
           // }
          //  finally
           // {
                conexao.Close();
          //  }
            return lstVenda;
        }

        public List<Model.Movimento> SelectNome()
        {
            List<Model.Movimento> lstVenda = new List<Model.Movimento>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " select ";
            sql += " Vendas_Rendimento.Vendedor, ";
            sql += " sum(Vendas_Rendimento.QtdeProduto) as'Qtde', ";
            sql += " sum(Vendas_Rendimento.QtdeProduto) as'Vendido', ";
            sql += " sum(Vendas_Rendimento.QtdeProduto) as 'Rendimento porc', ";
            sql += " sum(Vendas_Rendimento.Rendimento) as 'lucro' ";
            sql += " from Venda ";
            sql += " inner join Vendas_Rendimento on (Vendas_Rendimento.vendedor = Venda.Cliente) ";
            sql += " group by Vendas_Rendimento.vendedor order by Vendedor ";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            // try
            //{
            conexao.Open();
            SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dados.Read())
            {
                Model.Movimento Realizadas = new Model.Movimento();
                //Realizadas.id = Convert.ToInt32(dados["id"]);
                Realizadas.Vendedor = dados["Vendedor"].ToString();
                Realizadas.QtdeProduto = Convert.ToInt32(dados["Qtde"].ToString());
                Realizadas.Vendido = Convert.ToInt32(dados["Vendido"].ToString());
                Realizadas.RedimentoPorc = Convert.ToSingle(dados["Rendimento porc"].ToString());
                Realizadas.lucro = Convert.ToSingle(dados["lucro"].ToString());

                lstVenda.Add(Realizadas);
            }
            // }
            //  catch
            // {
            Console.WriteLine("Deu erro No select da Venda!!!");
            // }
            //  finally
            // {
            conexao.Close();
            //  }
            return lstVenda;
        }


        public int SelectQuantidade()
        {
            int Qtde = 0;
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " select Qtde from Venda ";

            SqlCommand cmd = new SqlCommand(sql, conexao);

            // try
            //{
            conexao.Open();
            SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dados.Read())
            {
                 Qtde = Qtde + Convert.ToInt32(dados["Qtde"].ToString());
            }
           
            // }
            //  catch
            // {
            Console.WriteLine("Deu erro No select da Venda!!!");
            // }
            //  finally
            // {
            conexao.Close();
            //  }
            return Qtde;

        }
    }
}
