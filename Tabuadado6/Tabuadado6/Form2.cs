using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuadado6
{
    public partial class FrmPosto : Form
    {
        public FrmPosto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double quant, preco;
            char gas;

            gas = Convert.ToChar(txtgas.Text);
            quant = Convert.ToDouble(txtquant.Text);

            if (gas == 'A')
            {
                if (quant <= 20)
                    preco = (20 * quant) * 3 / 100;
                else
                    preco = (20 * quant) * 5 / 100;
            }
            else if (gas == 'G')
                if (quant <= 20)
                    preco = (20 * quant) * 4 / 100;
                else
                    preco = (20 * quant) * 6 / 100;

          

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtgas.Clear();
            txtquant.Clear();
            txtpreco.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void FrmPosto_Load(object sender, EventArgs e)
        {

        }
    }
}




