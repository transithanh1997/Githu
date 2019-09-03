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
    public partial class frmCong : Form
    {
        public frmCong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bienA = double.Parse(textBox1.Text);
            double bienB = double.Parse(textBox2.Text);
            double kq = bienA + bienB;
            textBox3.Text = kq.ToString();
        }
    }
}
