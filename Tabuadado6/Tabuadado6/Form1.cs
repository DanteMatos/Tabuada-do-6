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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercícioTabuada6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPosto frm = new FrmPosto();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercícioTabuada6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm3 frm = new Frm3();
            frm.Show();
        }
    }
}
