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
    public partial class frmListProd : Form
    {
        public frmListProd()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListProd_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Produto produto = new Camadas.DAL.Produto();

            Habilitacampos(false);

            dgvListaProd.DataSource = "";
            dgvListaProd.DataSource = produto.Select();
        }

        private void Habilitacampos(bool status)
        {
            cmbQtde.Enabled = status;
            txtAno.Enabled = status;
            txtBusca.Enabled = status;
            txtDescricao.Enabled = status;
            txtID.Enabled = status;
            txtModelo.Enabled = status;
            txtValor.Enabled = status;

        }

        private void RdbBus_CheckedChanged(object sender, EventArgs e)
        {
            LimpaCampos();
            Habilitacampos(false);
            txtBusca.Enabled = true;
        }

        private void RdbAlfabetico_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.DAL.Produto produto = new Camadas.DAL.Produto();
            dgvListaProd.DataSource = "";
            dgvListaProd.DataSource = produto.SelectConsulta(1);
            LimpaCampos();
            Habilitacampos(false);
            rdbBus.Checked = false;
            txtBusca.Enabled = false;
        }

        private void RdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimpaCampos();
            Habilitacampos(false); 
            Camadas.DAL.Produto produto = new Camadas.DAL.Produto();
            dgvListaProd.DataSource = "";
            dgvListaProd.DataSource = produto.SelectConsulta(2);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            rdbAlfabetico.Checked = false;
            rdbCodigo.Checked = false;

            if (rdbAlfabetico.Checked)
            {
                Camadas.DAL.Produto produto = new Camadas.DAL.Produto();
                dgvListaProd.DataSource = "";
                dgvListaProd.DataSource = produto.SelectBusc(txtBusca.Text,1);
            }
            else
            {
                Camadas.DAL.Produto produto = new Camadas.DAL.Produto();
                dgvListaProd.DataSource = "";
                dgvListaProd.DataSource = produto.SelectBusc(txtBusca.Text,2);
            }
        }

        private void LimpaCampos()
        {
            txtAno.Text = "";
            txtBusca.Text = "";
            txtDescricao.Text = "";
            txtID.Text = "";
            txtModelo.Text = "";
            txtValor.Text = "";
            cmbQtde.Text = "< Selecione >";
        }

        private void DgvListaProd_DoubleClick(object sender, EventArgs e)
        {
            Habilitacampos(true);
            txtBusca.Enabled = false;
            rdbAlfabetico.Checked = false;
            rdbBus.Checked = false;
            rdbCodigo.Checked = false;
            cmbQtde.Text = "0";

            txtID.Text = dgvListaProd.SelectedRows[0].Cells["id"].Value.ToString();
            txtDescricao.Text = dgvListaProd.SelectedRows[0].Cells["desc_produto"].Value.ToString();
            txtModelo.Text = dgvListaProd.SelectedRows[0].Cells["Modelo"].Value.ToString();
            txtAno.Text = dgvListaProd.SelectedRows[0].Cells["Ano"].Value.ToString();
            cmbQtde.Text = dgvListaProd.SelectedRows[0].Cells["Qtde"].Value.ToString();
            txtValor.Text = dgvListaProd.SelectedRows[0].Cells["Valor"].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Camadas.Model.Produto produto = new Camadas.Model.Produto();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            Camadas.DAL.Produto qtde = new Camadas.DAL.Produto();
            int num1 = qtde.SelectQtde(Convert.ToInt32(txtID.Text));
            int num2 = Convert.ToInt32(cmbQtde.Text);
            int num3 = Atualiza(num1, num2);

            produto.id = Convert.ToInt32(txtID.Text);
            produto.desc_produto = txtDescricao.Text;
            produto.Modelo = txtModelo.Text;
            produto.Ano = Convert.ToInt32(txtAno.Text);
            produto.Qtde = num3;
            produto.Valor = Convert.ToSingle(txtValor.Text);

            bllProd.Update(produto);

            dgvListaProd.DataSource = "";
            dgvListaProd.DataSource = bllProd.Select();
        }

        private int Atualiza(int num1,int num2)
        {
            int valor = 0;
            valor = num1 + num2;
            return valor;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            bllProd.Delete(id);

            LimpaCampos();

            dgvListaProd.DataSource = "";
            dgvListaProd.DataSource = bllProd.Select();

        }
    }
}
