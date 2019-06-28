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
    public partial class frmRelProdutos : Form
    {
        public frmRelProdutos()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtRel.Text != "")
            {
                int Qtde = Convert.ToInt32(txtRel.Text);
                float Valor = Convert.ToSingle(txtRel.Text);

                if (rdbQtde.Checked == true && rdbID.Checked == true)
                {
                    Relatórios.RelProdutos.impRelProdutosQtde(Qtde, 2);
                }
                if (rdbQtde.Checked == true && rdbNome.Checked == true)
                {
                    Relatórios.RelProdutos.impRelProdutosQtde(Qtde, 1);
                }


                if (rdbValor.Checked == true && rdbID.Checked == true)
                {
                    Relatórios.RelProdutos.impRelProdutosValor(Valor, 2);
                }
                if (rdbValor.Checked == true && rdbNome.Checked == true)
                {
                    Relatórios.RelProdutos.impRelProdutosValor(Valor, 1);
                }

            }
            else
            {
                if(rdbTodos.Checked == false)
                {
                     MessageBox.Show("Verifique os dados informados estao corretos!!!");
                }
                
            }

            if(rdbTodos.Checked == true && rdbID.Checked == true)
            {
                Relatórios.RelProdutos.impRelProdutos();
            }
            if(rdbTodos.Checked == true && rdbNome.Checked == true)
            {
                Relatórios.RelProdutos.impRelProdutosNome(1);
            }

            
        }

        private void RdbQtde_CheckedChanged(object sender, EventArgs e)
        {
            txtRel.Enabled = true;
        }

        private void RdbValor_CheckedChanged(object sender, EventArgs e)
        {
            txtRel.Enabled = true;
        }

        private void RdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtRel.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
