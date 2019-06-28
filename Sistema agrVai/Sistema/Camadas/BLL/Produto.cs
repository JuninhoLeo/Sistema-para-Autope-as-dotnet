using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.BLL
{
    public class Produto
    {
        public List<Model.Produto> SelectbyName(string nome , int tipo)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectBusc(nome,tipo);
        }
        public List<Model.Produto> Selectordenando(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectConsulta(id);
        }
        public List<Model.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select();
        }

        public void Insert(Model.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if(produto.desc_produto != string.Empty)
               dalProd.Insert(produto);
        }

        public void Update(Model.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (produto.desc_produto != string.Empty)
                dalProd.Update(produto);
        }

        public void Delete(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (id > 0)
                dalProd.Delete(id);
        }

    }
}
