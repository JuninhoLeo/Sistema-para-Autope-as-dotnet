using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.DAL
{
    public class Venda
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Venda> Select()
        {      
            List<Model.Venda> listaVenda = new List<Model.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Venda ";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Venda venda = new Model.Venda();
                    venda.id_Venda = Convert.ToInt32(dados["id_Venda"].ToString());
                    venda.Cliente = dados["Cliente"].ToString();
                    venda.Produto = dados["Produto"].ToString();
                    venda.Modelo = dados["Modelo"].ToString();
                    venda.Ano = Convert.ToInt32(dados["Ano"].ToString());
                    venda.Qtde = Convert.ToInt32(dados["Qtde"].ToString());
                    venda.Valor = Convert.ToSingle(dados["Valor"].ToString());

                    listaVenda.Add(venda);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no Select da venda");
            }
            finally
            {
                conexao.Close();
            }

            return listaVenda;
        }

        public void Insert(Model.Venda venda)
        {


            SqlConnection conexao = new SqlConnection(strCon);
            string sql1 = "Insert into Venda values (@Cliente, @Produto, @Modelo, @Ano, @Qtde, @Valor)";
            string sql2 = "Insert into Vendas_Rendimento values (@Cliente, @Qtde, (@Qtde * @Valor))";
            SqlCommand cmd1 = new SqlCommand(sql1, conexao);
            SqlCommand cmd2 = new SqlCommand(sql2, conexao);

            cmd1.Parameters.AddWithValue("@Cliente", venda.Cliente);
            cmd2.Parameters.AddWithValue("@Cliente", venda.Cliente);

            cmd1.Parameters.AddWithValue("@Produto", venda.Produto);

            cmd1.Parameters.AddWithValue("@Qtde",venda.Qtde);
            cmd2.Parameters.AddWithValue("@Qtde",venda.Qtde);

            cmd1.Parameters.AddWithValue("@Valor", venda.Valor);
            cmd2.Parameters.AddWithValue("@Valor", venda.Valor);

            cmd1.Parameters.AddWithValue("@Modelo", venda.Modelo);
            cmd1.Parameters.AddWithValue("@Ano", venda.Ano);

           // try
           // {
                conexao.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
          //  }
           // catch
          //  {
                Console.WriteLine("Deu erro no Insert da Venda!!!");
          //  }
          //  finally
           // {
                conexao.Close();
          //  }
        }

        public void Update(Model.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Venda set Cliente=@Cliente, Produto=@Produto, Modelo=@Modelo, Ano=@Ano, Qtde=@Qtde, Valor=@Valor";
            sql += "where id_Venda=@id_Venda";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_Venda", venda.id_Venda);
            cmd.Parameters.AddWithValue("@Cliente", venda.Cliente);
            cmd.Parameters.AddWithValue("@Produto", venda.Produto);
            cmd.Parameters.AddWithValue("@Modelo", venda.Modelo);
            cmd.Parameters.AddWithValue("@Ano", venda.Ano);
            cmd.Parameters.AddWithValue("@Qtde", venda.Produto);
            cmd.Parameters.AddWithValue("@Valor", venda.Valor);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na Atualização da Venda!!!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete From Venda Where id_Venda=@id_Venda";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_Venda", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na Exclusão da Venda!!!");
            }
            finally
            {
                conexao.Close();
            }
        }

        

    }
}
