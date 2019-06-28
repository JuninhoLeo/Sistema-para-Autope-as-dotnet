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
    public partial class frmRelVendas : Form
    {
        public frmRelVendas()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtRel.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtRel.Text == "" && rdbTodos.Checked == true)
            {
                Relatórios.RelVendas.impRelVendas();
            }

            if (txtRel.Text != "" && rdbMaior.Checked == true)
            {
                int Qtde = Convert.ToInt32(txtRel.Text);
                Relatórios.RelVendas.impRelVendasMaior(Qtde);
            }

            if (txtRel.Text != "" && rdbMenor.Checked == true)
            {
                int Qtde = Convert.ToInt32(txtRel.Text);
                Relatórios.RelVendas.impRelVendasMenor(Qtde);
            }

        }

        private void RdbQtde_CheckedChanged(object sender, EventArgs e)
        {
            txtRel.Enabled = true;
        }
    }
}
