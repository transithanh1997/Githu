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
    public partial class frmChia : Form
    {
        public frmChia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double kq = a / b;
            if(b == 0)
            {
                MessageBox.Show("Error");
            }
            textBox3.Text = kq.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void frmChia_Load(object sender, EventArgs e)
        {

        }
    }
}
