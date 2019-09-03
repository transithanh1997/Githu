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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            frmCong fc = new frmCong();
            fc.Show();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            frmTru ft = new frmTru();
            ft.Show();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            frmnhan fn = new frmnhan();
            fn.Show();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            frmChia fc = new frmChia();
            fc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
