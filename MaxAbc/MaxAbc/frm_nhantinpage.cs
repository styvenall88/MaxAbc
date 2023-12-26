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
    public partial class frm_nhantinpage : Form
    {
        private string filePath;
        public frm_nhantinpage()
        {
            InitializeComponent();
        }

        private void btn_layfilelinkpage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Chọn ra file tài khoản fb .txt |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                string[] lines = System.IO.File.ReadAllLines(filePath);
                this.Close();
            }
        }
    }
}
