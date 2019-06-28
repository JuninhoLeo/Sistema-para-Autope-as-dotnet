using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void NovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void IncluirNovoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProd = new frmProduto();
            frmProd.MdiParent = this;
            frmProd.Show();
        }

        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frmVen = new frmVenda();
            frmVen.MdiParent = this;
            frmVen.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void CadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrado frmCadastro = new frmCadastrado();
            frmCadastro.MdiParent = this;
            frmCadastro.Show();
        }

        private void ListaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProd frmListProd = new frmListProd();
            frmListProd.MdiParent = this;
            frmListProd.Show();
        }

        private void RelatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             
        }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatórios.RelProdutos.impRelProdutos();
        }

        private void ComFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelProdutos frmRelProdutos = new frmRelProdutos();
            frmRelProdutos.MdiParent = this;
            frmRelProdutos.Show();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelVendas frmRelVendas = new frmRelVendas();
            frmRelVendas.MdiParent = this;
            frmRelVendas.Show();
        }

    }
}
