using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Produto> SelectbyID(int cod)
        {
            List<Model.Produto> listaProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from produto where id = " + cod + " ";
                 
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Produto produto = new Model.Produto();

                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.desc_produto = dados["desc_produto"].ToString();
                    produto.Modelo = dados["Modelo"].ToString();
                    produto.Ano = Convert.ToInt32(dados["Ano"].ToString());
                    produto.Qtde = Convert.ToInt32(dados["Qtde"].ToString());
                    produto.Valor = Convert.ToSingle(dados["Valor"].ToString());

                    listaProduto.Add(produto);   
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no select dos produtos!!!");
            }
            finally
            {
                conexao.Close();
            }
            return listaProduto;
        }

        public List<Model.Produto> SelectBusc(string busc,int cod)
        {
            List<Model.Produto> listaProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "";
            if (cod == 1)
            {
                sql = " Select * from produto where desc_produto like '%"+busc+"%' order by desc_produto";
            }
            else
            {
                sql = " Select * from produto where desc_produto like '%" + busc + "%' order by id ";
            }
      
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Produto produto = new Model.Produto();

                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.desc_produto = dados["desc_produto"].ToString();
                    produto.Modelo = dados["Modelo"].ToString();
                    produto.Ano = Convert.ToInt32(dados["Ano"].ToString());
                    produto.Qtde = Convert.ToInt32(dados["Qtde"].ToString());
                    produto.Valor = Convert.ToSingle(dados["Valor"].ToString());

                    listaProduto.Add(produto);   
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no select dos produtos!!!");
            }
            finally
            {
                conexao.Close();
            }
            return listaProduto;
        }
        public List<Model.Produto> SelectConsulta(int tipo)
        {
            List<Model.Produto> listaProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "";
            if (tipo == 1)
            {
                sql = " Select * from produto order by desc_produto";
            }else
                if(tipo == 2)
            {
                sql = " select * from produto order by id ";
            }
      
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Produto produto = new Model.Produto();

                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.desc_produto = dados["desc_produto"].ToString();
                    produto.Modelo = dados["Modelo"].ToString();
                    produto.Ano = Convert.ToInt32(dados["Ano"].ToString());
                    produto.Qtde = Convert.ToInt32(dados["Qtde"].ToString());
                    produto.Valor = Convert.ToSingle(dados["Valor"].ToString());

                    listaProduto.Add(produto);   
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no select dos produtos!!!");
            }
            finally
            {
                conexao.Close();
            }
            return listaProduto;
        }

        public int SelectQtde(int id)
        {
            List<Model.Produto> listaProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Produto where id="+id+"";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            Model.Produto produto = new Model.Produto();
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
                while (dados.Read())
                {
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.desc_produto = dados["desc_produto"].ToString();
                    produto.Modelo = dados["Modelo"].ToString();
                    produto.Ano = Convert.ToInt32(dados["Ano"].ToString());
                    produto.Qtde = Convert.ToInt32(dados["Qtde"].ToString());
                    produto.Valor = Convert.ToSingle(dados["Valor"].ToString());

                    listaProduto.Add(produto);   
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no select dos produtos!!!");
            }
            finally
            {
                conexao.Close();
            }
            return produto.Qtde;
        }

        public List<Model.Produto> Select()
        {
            List<Model.Produto> listaProduto = new List<Model.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Produto ";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Produto produto = new Model.Produto();

                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.desc_produto = dados["desc_produto"].ToString();
                    produto.Modelo = dados["Modelo"].ToString();
                    produto.Ano = Convert.ToInt32(dados["Ano"].ToString());
                    produto.Qtde = Convert.ToInt32(dados["Qtde"].ToString());
                    produto.Valor = Convert.ToSingle(dados["Valor"].ToString());

                    listaProduto.Add(produto);   
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no select dos produtos!!!");
            }
            finally
            {
                conexao.Close();
            }
            return listaProduto;
        }

        public void Insert(Camadas.Model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Insert into Produto values (@desc_produto,@Modelo,@Ano,@Qtde,@Valor) ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@desc_produto", produto.desc_produto);
            cmd.Parameters.AddWithValue("@Valor", produto.Valor);
            cmd.Parameters.AddWithValue("@Modelo", produto.Modelo);
            cmd.Parameters.AddWithValue("@Ano", produto.Ano);
            cmd.Parameters.AddWithValue("@Qtde", produto.Qtde);
            
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("deu erro no insert dos produtos!!!!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.Model.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set desc_produto=@desc_produto, Valor=@Valor, Modelo=@Modelo , Ano=@Ano, Qtde=@Qtde where id=@id" ;
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@desc_produto", produto.desc_produto);
            cmd.Parameters.AddWithValue("@Valor", produto.Valor);
            cmd.Parameters.AddWithValue("@Modelo", produto.Modelo);
            cmd.Parameters.AddWithValue("@Ano", produto.Ano);
            cmd.Parameters.AddWithValue("@Qtde", produto.Qtde);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização do produto!!!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produto where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro no delete do produto!!!");
            }
            finally
            {
                conexao.Close();
            }
        }



    }
}
