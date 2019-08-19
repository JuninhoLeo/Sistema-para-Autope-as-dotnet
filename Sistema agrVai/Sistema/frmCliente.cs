using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            HabilitaCampos(false);
            Camadas.BLL.Clientes bblVen = new Camadas.BLL.Clientes();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bblVen.Select();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            Camadas.Model.Clientes cliente = new Camadas.Model.Clientes();
            Camadas.BLL.Clientes bllCli = new Camadas.BLL.Clientes();

            if (txtNome.Text != "")
            {
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = txtTel.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Num = Convert.ToInt32(txtNumero.Text);
                cliente.CEP = txtCEP.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.UF = txtUF.Text;
                cliente.Nascimento = Convert.ToDateTime(txtNascimento.Text);
                cliente.CPF = txtCPF.Text;

                if (rdbFem.Checked == true)
                    cliente.Sexo = "F";

                if (rdbMasc.Checked == true)
                    cliente.Sexo = "M";

                if (rdbNem.Checked == true)
                    cliente.Sexo = "";


                bllCli.Insert(cliente);

                LimpaCampos();
                txtID.Text = "";
                HabilitaCampos(false);

                dgvClientes.DataSource = "";
                dgvClientes.DataSource = bllCli.Select();
            }else
            {

            }
        }

        private void DgvClientes_DoubleClick(object sender, EventArgs e)
        {
            HabilitaCampos(true);
            btnInserir.Enabled = false;

            txtID.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvClientes.SelectedRows[0].Cells["Nome"].Value.ToString();
            txtEmail.Text = dgvClientes.SelectedRows[0].Cells["Email"].Value.ToString();
            txtTel.Text = dgvClientes.SelectedRows[0].Cells["Telefone"].Value.ToString();
            txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["Endereco"].Value.ToString();
            txtNumero.Text = dgvClientes.SelectedRows[0].Cells["Num"].Value.ToString();
            txtCidade.Text = dgvClientes.SelectedRows[0].Cells["Cidade"].Value.ToString();
            txtUF.Text = dgvClientes.SelectedRows[0].Cells["UF"].Value.ToString();
            txtCEP.Text = dgvClientes.SelectedRows[0].Cells["CEP"].Value.ToString();
            txtNascimento.Text = dgvClientes.SelectedRows[0].Cells["Nascimento"].Value.ToString();
            txtCPF.Text = dgvClientes.SelectedRows[0].Cells["CPF"].Value.ToString();

            Camadas.Model.Clientes check = new Camadas.Model.Clientes(); 
            check.Sexo = dgvClientes.SelectedRows[0].Cells["Sexo"].Value.ToString();


            if (check.Sexo == "F" || check.Sexo == "f")
            {
                rdbFem.Checked = true;
                rdbMasc.Checked = false;
                rdbNem.Checked = false;
            }else
            {
                rdbFem.Checked = false;
                rdbMasc.Checked = true;
                rdbNem.Checked = false;
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Camadas.Model.Clientes cliente = new Camadas.Model.Clientes();
            Camadas.BLL.Clientes bllCli = new Camadas.BLL.Clientes();

            cliente.id = Convert.ToInt32(txtID.Text);
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTel.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Num = Convert.ToInt32(txtNumero.Text);
            cliente.CEP = txtCEP.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.UF = txtUF.Text;
            cliente.Nascimento = Convert.ToDateTime(txtNascimento.Text);
            cliente.CPF = txtCPF.Text;

            if (rdbFem.Checked == true)
                cliente.Sexo = "F";

            if (rdbMasc.Checked == true)
                cliente.Sexo = "M";

            if (rdbNem.Checked == true)
                cliente.Sexo = "";


            bllCli.Update(cliente);

            LimpaCampos();
            txtID.Text = "";
            HabilitaCampos(false);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            HabilitaCampos(false);
            btnModificar.Visible = false;
            btnAtualizar.Visible = true;
            btnNovo.Visible = false;
            btnInserir.Visible = false;
            btnRemover.Visible = true;
            txtID.Text = "-1";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitaCampos(bool status)
        {
            btnInserir.Visible = status;
            btnRemover.Visible = status;
            btnAtualizar.Visible = status;
            btnModificar.Visible = !status;
            btnNovo.Visible = !status;

            txtNome.Enabled = status;
            txtEmail.Enabled = status;
            txtCPF.Enabled = status;
            txtNascimento.Enabled = status;
            txtTel.Enabled = status;
            rdbMasc.Enabled = status;
            rdbFem.Enabled = status;
            rdbNem.Enabled = status;
            txtEndereco.Enabled = status;
            txtNumero.Enabled = status;
            txtCEP.Enabled = status;
            txtCidade.Enabled = status;
            txtUF.Enabled = status;
        }

        private void LimpaCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";
            txtNascimento.Text = "";
            txtTel.Text = "";
            rdbMasc.Checked = false;
            rdbFem.Checked = false;
            rdbNem.Checked = true;
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
        }

        private void GpbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void LblNascimento_Click(object sender, EventArgs e)
        {

        }

        private void GpbLocalização_Enter(object sender, EventArgs e)
        {

        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaCampos(false);
            LimpaCampos();
            txtID.Text = "";
        }

        private void BtnRemover_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Camadas.BLL.Clientes bllCli = new Camadas.BLL.Clientes();
            bllCli.Delete(id);

            LimpaCampos();
            HabilitaCampos(false);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = bllCli.Select();
        }

        private void BtnNovo_Click_2(object sender, EventArgs e)
        {
            HabilitaCampos(true);
            btnAtualizar.Visible = false;
            btnRemover.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
