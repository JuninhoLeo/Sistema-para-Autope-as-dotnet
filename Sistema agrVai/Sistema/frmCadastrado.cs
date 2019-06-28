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
    public partial class frmCadastrado : Form
    {
        public frmCadastrado()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TmRelogio_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastrado_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Clientes clientes = new Camadas.DAL.Clientes();
            dgvListClientes.DataSource = "";
            dgvListClientes.DataSource = clientes.Select();

            Camadas.BLL.Clientes bllCli = new Camadas.BLL.Clientes();
            txtNome.DisplayMember = "Nome";
            txtNome.ValueMember = "Nome";
            txtNome.DataSource = bllCli.Select();
        } 

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if(rdbPrNome.Checked == true)
            {
                Camadas.BLL.Clientes clientes = new Camadas.BLL.Clientes();
                dgvListClientes.DataSource = "";
                dgvListClientes.DataSource = clientes.SelectNome(txtNome.Text,0);
            }
        }

        private void RdbPrNome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdbAlfabetico_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.DAL.Clientes clientes = new Camadas.DAL.Clientes();
            dgvListClientes.DataSource = "";
            dgvListClientes.DataSource = clientes.SelectComfiltro(1);
        }

        private void RdbPorID_CheckedChanged(object sender, EventArgs e)
        {
            Camadas.DAL.Clientes clientes = new Camadas.DAL.Clientes();
            dgvListClientes.DataSource = "";
            dgvListClientes.DataSource = clientes.SelectComfiltro(2);
        }

        private void DgvListClientes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void TxtNome_Leave(object sender, EventArgs e)
        {
            rdbPrNome.Checked = true;
        }
    }
}
