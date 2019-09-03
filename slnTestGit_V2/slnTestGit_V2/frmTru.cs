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
    public partial class frmTru : Form
    {
        public frmTru()
        {
            InitializeComponent();
        }

        private void btnkq_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double kq = a - b;
            txtKq.Text = kq.ToString();
        }
    }
}
