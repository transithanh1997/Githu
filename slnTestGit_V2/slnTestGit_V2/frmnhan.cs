using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnTestGit_V2
{
    public partial class frmnhan : Form
    {
        public frmnhan()
        {
            InitializeComponent();
        }

        private void frmnhan_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double kq = a * b;
            txtkq.Text = kq.ToString();
        }
    }
}
