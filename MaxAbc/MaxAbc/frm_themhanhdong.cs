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
    public partial class frm_themhanhdong : Form
    {
        public frm_themhanhdong()
        {
            InitializeComponent();
        }

        private void btn_nhantinpage_Click(object sender, EventArgs e)
        {
            frm_nhantinpage f = new frm_nhantinpage();
            f.ShowDialog();
        }

        private void btn_luotnewfeed_Click(object sender, EventArgs e)
        {

        }
    }
}
