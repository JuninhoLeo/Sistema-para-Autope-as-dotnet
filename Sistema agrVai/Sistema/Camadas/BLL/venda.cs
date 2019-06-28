using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.BLL
{
    public class venda
    {
        public List<Model.Venda> Select()
        {
            DAL.Venda dalVen = new DAL.Venda();
            return dalVen.Select();
        }

        public void Insert(Model.Venda itemvenda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            Model.Produto produto = new Model.Produto();
            BLL.Produto bllProd = new BLL.Produto();
            Model.Produto modelProd = new Model.Produto();

            produto = bllProd.SelectbyName(itemvenda.Produto,0)[0];
            produto.Qtde -= itemvenda.Qtde;

            bllProd.Update(produto);
            dalVenda.Insert(itemvenda);
        }

        public void Update(Model.Venda venda)
        {
            DAL.Venda dalVen = new DAL.Venda();
            if (venda.Cliente != string.Empty)
                dalVen.Update(venda);
        }

        public void Delete(int id)
        {
            DAL.Venda dalVen = new DAL.Venda();
            if (id > 0)
                dalVen.Delete(id);
        }
    }
}
