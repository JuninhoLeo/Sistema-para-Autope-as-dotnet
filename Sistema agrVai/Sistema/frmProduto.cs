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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            Camadas.Model.Produto produto = new Camadas.Model.Produto();
            Camadas.DAL.Produto consulta = new Camadas.DAL.Produto();

            produto.id = Convert.ToInt32(txtID.Text);
            produto.desc_produto = txtDescricao.Text;
            produto.Valor = Convert.ToSingle(txtValor.Text);
            produto.Modelo = txtModelo.Text;
            produto.Ano = Convert.ToInt32(txtAno.Text);
            produto.Qtde = Convert.ToInt32(cmbQtde.SelectedItem);

            bllProd.Insert(produto);

            limpaCampos();
            habilitaCampos(false);

            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            habilitaCampos(false);
            limpaCampos();

            Camadas.BLL.Produto produto = new Camadas.BLL.Produto();

            dgvProduto.DataSource = "";
            dgvProduto.DataSource = produto.Select(); 

        }

        private void habilitaCampos(bool status)
        {
            btnSalvar.Enabled = status;
            btnNovo.Enabled = !status;
           
            cmbQtde.Enabled = status;
            txtDescricao.Enabled = status;
            txtModelo.Enabled = status;
            txtAno.Enabled = status;
            txtValor.Enabled = status;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            txtID.Text = "-1";
            txtDescricao.Focus();
        }

        private void BtnCancalar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            cmbQtde.Text = "< Selecione >";
            habilitaCampos(false);
        }

        private void limpaCampos()
        {
            txtID.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
