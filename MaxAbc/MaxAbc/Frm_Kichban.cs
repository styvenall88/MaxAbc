using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxAbc
{
    public partial class Frm_Kichban : Form
    {
        public Frm_Kichban()
        {
            InitializeComponent();
        }

        private void btn_quanlikichban_Click(object sender, EventArgs e)
        {
            frm_quanlikichban f = new frm_quanlikichban();
            f.ShowDialog();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
