using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();

        public List<Model.Clientes> SelectNome(string text,int cod)
        {
            List<Model.Clientes> listaNome = new List<Model.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "";

            if (cod > 0)
            {
                sql = "  select * from Cliente where id= " + cod + "";
            }
            else
            {
                sql = "  select * from Cliente where nome like'%" + text + "%'";
            }


            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               
                while (dados.Read())
                {
                    Model.Clientes cliente = new Model.Clientes();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.Nome = dados["Nome"].ToString();
                    cliente.Sexo = dados["Sexo"].ToString();
                    cliente.Telefone = dados["Telefone"].ToString();
                    cliente.CPF = dados["CPF"].ToString();
                    cliente.Endereco = dados["Endereco"].ToString();
                    cliente.Num = Convert.ToInt32(dados["Num"].ToString());
                    cliente.CEP = dados["CEP"].ToString();
                    cliente.Cidade = dados["Cidade"].ToString();
                    cliente.UF = dados["UF"].ToString();
                    cliente.Nascimento = Convert.ToDateTime(dados["Nascimento"].ToString());
                    cliente.Email = dados["Email"].ToString();

                    listaNome.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no select dos nomes!!");
            }
            finally
            {
                conexao.Close();
            }
            return listaNome;
        }

        public List<Model.Clientes> SelectComfiltro(int num)
        {
            List<Model.Clientes> listaNome = new List<Model.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "";
            if (num == 1)
            {
                sql = " Select * from Cliente order by nome";
            }
            else
            if(num == 2)
            {
                sql = " Select * from Cliente order by id";
            }
               
            SqlCommand cmd = new SqlCommand(sql,conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               
                while (dados.Read())
                {
                    Model.Clientes cliente = new Model.Clientes();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.Nome = dados["Nome"].ToString();
                    cliente.Sexo = dados["Sexo"].ToString();
                    cliente.Telefone = dados["Telefone"].ToString();
                    cliente.CPF = dados["CPF"].ToString();
                    cliente.Endereco = dados["Endereco"].ToString();
                    cliente.Num = Convert.ToInt32(dados["Num"].ToString());
                    cliente.CEP = dados["CEP"].ToString();
                    cliente.Cidade = dados["Cidade"].ToString();
                    cliente.UF = dados["UF"].ToString();
                    cliente.Nascimento = Convert.ToDateTime(dados["Nascimento"].ToString());
                    cliente.Email = dados["Email"].ToString();

                    listaNome.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no select dos nomes!!");
            }
            finally
            {
                conexao.Close();
            }
            return listaNome;
        }
            
        public List<Model.Clientes> Select()
        {
            List<Model.Clientes> listaCliente = new List<Model.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Select * from Cliente ";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    Model.Clientes cliente = new Model.Clientes();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.Nome = dados["Nome"].ToString();
                    cliente.Sexo = dados["Sexo"].ToString();
                    cliente.Telefone = dados["Telefone"].ToString();
                    cliente.CPF = dados["CPF"].ToString();
                    cliente.Endereco = dados["Endereco"].ToString();                 
                    cliente.Num = Convert.ToInt32(dados["Num"].ToString());
                    cliente.CEP = dados["CEP"].ToString();
                    cliente.Cidade = dados["Cidade"].ToString();
                    cliente.UF = dados["UF"].ToString();
                    cliente.Nascimento = Convert.ToDateTime(dados["Nascimento"].ToString());
                    cliente.Email = dados["Email"].ToString();
                    
                    listaCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro no select do cliente.....");
            }
            finally
            {
                conexao.Close();
            }

            return listaCliente;
        }

        public void Insert(Model.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = " Insert into Cliente values( @Nome, @Telefone, @CPF, @Endereco, @Num, @CEP, @Cidade, @UF, @Nascimento, @Email, @Sexo ) ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome",cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@Num", cliente.Num);
            cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@UF", cliente.UF);
            cmd.Parameters.AddWithValue("@Nascimento", cliente.Nascimento);
            cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
            
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro inserção de clientes......");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Update(Camadas.Model.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set Nome=@Nome, Telefone=@Telefone, CPF=@CPF, Endereco=@Endereco, Num=@Num, CEP=@CEP, Cidade=@Cidade, UF=@UF, Nascimento=@Nascimento, Email=@Email, Sexo=@Sexo where id=@id ";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@Num", cliente.Num);
            cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
            cmd.Parameters.AddWithValue("@Nascimento", cliente.Nascimento);
            cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@Uf", cliente.UF);


            try
            {
            conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na atualização de cliente.....");
            }
            finally
            {
                conexao.Close();
            }
        }
        
        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id",id);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na Remoção de cliente.....");
            }
            finally
            {
                conexao.Close();
            } 
        }



    }
}
