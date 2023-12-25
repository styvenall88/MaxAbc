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
    public partial class Form1 : Form
    {
        // Thêm khai báo cho contextMenuStrip1
        private ContextMenuStrip contextMenuStrip1;

        public Form1()
        {
            InitializeComponent();

            // Thêm sự kiện cho dataGridView1
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;

            // Khởi tạo contextMenuStrip1
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            // Khai báo và khởi tạo ContextMenuStrip
            contextMenuStrip1 = new ContextMenuStrip();

            // Thêm các mục menu
            contextMenuStrip1.Items.Add("Option 1", null, Option1_Click);
            contextMenuStrip1.Items.Add("Option 2", null, Option2_Click);
        }

        private void btn_cauhinhchung_Click(object sender, EventArgs e)
        {
            frm_cauhinhchung f = new frm_cauhinhchung();
            f.ShowDialog();
        }

        private void btn_cauhinhtuongtac_Click(object sender, EventArgs e)
        {
            Frm_Kichban f = new Frm_Kichban();
            f.ShowDialog();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Chọn dòng được click
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                    // Lấy tọa độ màn hình của chuột
                    Point screenPoint = dataGridView1.PointToScreen(e.Location);
                    MessageBox.Show(screenPoint.ToString());
                    // Hiển thị menu ngữ cảnh tại vị trí chuột
                    contextMenuStrip1.Show(screenPoint);
                }
            }
        }


        private void Option1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 1");
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 2");
        }
    }
}
