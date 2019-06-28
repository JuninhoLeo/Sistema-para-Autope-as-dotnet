using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Camadas.BLL
{
    public class Clientes
    {
        public List<Model.Clientes> Select()
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.Select();
        }

        public List<Model.Clientes> SelectNome(string text, int cod)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.SelectNome(text, cod);
        }

        public void Insert(Model.Clientes clientes)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            if (clientes.Nome != "")
                dalCli.Insert(clientes);
        }

        public void Update(Model.Clientes clientes)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Update(clientes);
        }

        public void Delete(int id)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            if (id > 0)
                dalCli.Delete(id);
        }


    }
}
