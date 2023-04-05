using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuadado6
{
    public partial class Frm3 : Form
    {
        public Frm3()
        {
            InitializeComponent();
        }

        private void bntenquanto_Click(object sender, EventArgs e)
        {
            double x, r;
            int i;
            

            x = Convert.ToDouble(txtx.Text);
            i = 1;


            while (i <= 60)
            {
                r = x * i;
                    i++;
            }

            r = Convert.ToString();
            txtresult.Text = r.ToString();

        }

        private void bntrepita_Click(object sender, EventArgs e)
        {
            double x, r;
            int i;

            x = Convert.ToDouble(txtx.Text);
            i = 1;

            do {  

                r = x * i;
                i++;

            } while (i >= 60);
           

        }

        private void bntpara_Click(object sender, EventArgs e)
        {
            double x, r; 
            int i;

            x = Convert.ToDouble(txtx.Text);
            i = 1;

            for(i=2; i <=60; i++)
            {
                r = x * i;
            }
        }

        private void bntlimpar_Click(object sender, EventArgs e)
        {
            txtx.Clear();
            txtresult.Clear();
        }

        private void bntvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
