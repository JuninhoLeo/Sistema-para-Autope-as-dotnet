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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            txtCliente.Enabled = false;
            txtDescricao.Enabled = false;
            txtModelo.Enabled = false;
            txtAno.Enabled = false;
            txtQtde.Enabled = false;
            txtValor.Enabled = false;
            cmbQtde.Enabled = false;
            rdbCliTodos.Checked = true;
            rdbProdTodos.Checked = true;
                        
            Camadas.BLL.Clientes clientes = new Camadas.BLL.Clientes();
            Camadas.BLL.Produto produto = new Camadas.BLL.Produto();
            Camadas.BLL.venda venda = new Camadas.BLL.venda();

            dgvCliente.DataSource = "";
            dgvProduto.DataSource = "";
            dgvVenda.DataSource = "";

            dgvCliente.DataSource = clientes.Select();
            dgvProduto.DataSource = produto.Select();
            dgvVenda.DataSource = venda.Select();

            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            txtBusca.DisplayMember = "desc_produto";
            txtBusca.ValueMember = "desc_produto";
            txtBusca.DataSource = bllProd.Select();
            txtBusca.Text = "";

            Camadas.BLL.Clientes dalCli = new Camadas.BLL.Clientes();
            txtNome.DisplayMember = "nome";
            txtNome.ValueMember = "nome";
            txtNome.DataSource = dalCli.Select();
            txtNome.Text = "";

            ColunasCli();
        }

        private void DgvCliente_DoubleClick(object sender, EventArgs e)
        {
            txtCliente.Text = dgvCliente.SelectedRows[0].Cells["Nome"].Value.ToString();
        }

        private void DgvProduto_DoubleClick(object sender, EventArgs e)
        {
            cmbQtde.Enabled = true;
            
            txtDescricao.Text = dgvProduto.SelectedRows[0].Cells["desc_produto"].Value.ToString();
            txtModelo.Text = dgvProduto.SelectedRows[0].Cells["Modelo"].Value.ToString();
            txtAno.Text = dgvProduto.SelectedRows[0].Cells["Ano"].Value.ToString();
            txtQtde.Text = dgvProduto.SelectedRows[0].Cells["Qtde"].Value.ToString();
            txtValor.Text = dgvProduto.SelectedRows[0].Cells["Valor"].Value.ToString();
        }

        private void DgvVenda_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dgvVenda.SelectedRows[0].Cells["id_venda"].Value.ToString();
            txtCliente.Text = dgvVenda.SelectedRows[0].Cells["Cliente"].Value.ToString();
            txtDescricao.Text = dgvVenda.SelectedRows[0].Cells["produto"].Value.ToString();
            txtModelo.Text = dgvVenda.SelectedRows[0].Cells["Modelo"].Value.ToString();
            txtAno.Text = dgvVenda.SelectedRows[0].Cells["Ano"].Value.ToString();
            cmbQtde.Text = dgvVenda.SelectedRows[0].Cells["Qtde"].Value.ToString();
            txtValor.Text = dgvVenda.SelectedRows[0].Cells["Valor"].Value.ToString();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
             Camadas.BLL.Clientes clientes = new Camadas.BLL.Clientes();

            if (rdbCliNome.Checked == true)
            {
                dgvCliente.DataSource = "";
                dgvCliente.DataSource = clientes.SelectNome(txtNome.Text, 0);
            }
            if (rdbCliID.Checked == true)
            {
                dgvCliente.DataSource = "";
                dgvCliente.DataSource = clientes.SelectNome(txtNome.Text, Convert.ToInt32(txtNome.Text));
            }
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.BLL.Clientes clientes = new Camadas.BLL.Clientes();
            dgvCliente.DataSource = "";
            dgvCliente.DataSource = clientes.Select();
            txtNome.Text = "";
            txtNome.Enabled = false;

        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            
        }

        private void RdbCliID_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.Enabled = true;
        }

        private void RdbCliNome_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.Enabled = true;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {           
            if (rdbProdNome.Checked == true)
            {
                Camadas.DAL.Produto produto = new Camadas.DAL.Produto();
                dgvProduto.DataSource = "";
                dgvProduto.DataSource = produto.SelectBusc(txtBusca.Text, 1);
            }
            if(rdbProdID.Checked == true)
            {
                Camadas.DAL.Produto produto = new Camadas.DAL.Produto();
                dgvProduto.DataSource = "";
                dgvProduto.DataSource = produto.SelectbyID(Convert.ToInt32(txtBusca.Text));
            }
        }

        private void RdbProdNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.Enabled = true;
        }

        private void RdbProdID_CheckedChanged(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            txtBusca.Enabled = true;
        }

        private void RdbProdTodos_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();
            txtBusca.Text = "";
            txtBusca.Enabled = false;
        }

        private void Limpacampos()
        {
            txtCliente.Text = "";
            txtDescricao.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
            txtQtde.Text = "";
            txtValor.Text = "";
            cmbQtde.Enabled = false;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Limpacampos();
            txtCliente.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Camadas.Model.Venda venda = new Camadas.Model.Venda();
            Camadas.BLL.venda bllVen = new Camadas.BLL.venda();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            if (cmbQtde.Text != "" && txtCliente.Text != "")
            {
                int QtdeVen = Convert.ToInt32(cmbQtde.Text);
                int QtdeEst = Convert.ToInt32(txtQtde.Text);


                if (cmbQtde.Text == "" || QtdeVen > QtdeEst)
                {
                    MessageBox.Show("Dados informados estao incorretos!!!");
                    cmbQtde.Text = txtQtde.Text;
                }

                if (QtdeVen <= QtdeEst)
                {
                    venda.Cliente = txtCliente.Text;
                    venda.Produto = txtDescricao.Text;
                    venda.Modelo = txtModelo.Text;
                    venda.Ano = Convert.ToInt32(txtAno.Text);
                    venda.Qtde = Convert.ToInt32(cmbQtde.Text);
                    venda.Valor = Convert.ToSingle(txtValor.Text);

                    bllVen.Insert(venda);
                    Limpacampos();
                    cmbQtde.Text = "";
                    dgvVenda.DataSource = "";
                    dgvVenda.DataSource = bllVen.Select();
                    dgvProduto.DataSource = "";
                    dgvProduto.DataSource = bllProd.Select();
                }
            }
            else
            {
                MessageBox.Show("Dado da venda estão incorretos ou inesistentes!!!");
            }
        }

        private void CalcularTotal()
        {
            int Qtde = Convert.ToInt32(cmbQtde.Text);
            float valor = Convert.ToSingle(txtValor.Text);
            float Preço = Qtde * valor;
            string a = Preço.ToString("C");
            lblReal.Text = a;
        }

        private void CmbQtde_Leave(object sender, EventArgs e)
        {
          
        }

        private void DgvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Camadas.BLL.venda bllVenda = new Camadas.BLL.venda();
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                bllVenda.Delete(id);
                Limpacampos();
            }
            else
            {
                MessageBox.Show("ID não localizado!!!");
                txtQtde.Focus();
            }
            dgvVenda.DataSource = "";
            dgvVenda.DataSource = bllVenda.Select();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
            {
                if (Convert.ToSingle(cmbQtde.Text) > Convert.ToInt32(txtQtde.Text))
                {
                    MessageBox.Show("Não há itens suficientes para a venda!!!");
                    cmbQtde.Text = txtQtde.Text;
                }
                CalcularTotal();
            }
        }

        private void ColunasCli()
        {
            dgvCliente.Columns["Telefone"].Visible = false;
            dgvCliente.Columns["CPF"].Visible = false;
            dgvCliente.Columns["Endereco"].Visible = false;
            dgvCliente.Columns["Num"].Visible = false;
            dgvCliente.Columns["CEP"].Visible = false;
            dgvCliente.Columns["Cidade"].Visible = false;
            dgvCliente.Columns["UF"].Visible = false;
            dgvCliente.Columns["Nascimento"].Visible = false;
            dgvCliente.Columns["Email"].Visible = false;
            dgvCliente.Columns["Sexo"].Visible = false;

            foreach(DataGridViewColumn column in dgvCliente.Columns)
            {
                if(column.DataPropertyName == "Nome"){
                    column.Width = 536;
                } 
              column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToString();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }

        private void TxtTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
