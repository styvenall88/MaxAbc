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
        // KHÁI BÁO PHỤ
        private ContextMenuStrip subContextMenuStrip;
        public Form1()
        {
            InitializeComponent();

            // Thêm sự kiện cho dataGridView1
            dataGridView1.MouseDown += dataGridView1_MouseDown;

            // Khởi tạo contextMenuStrip1
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            // Khai báo và khởi tạo ContextMenuStrip
            contextMenuStrip1 = new ContextMenuStrip();

            // Thêm các mục menu
            contextMenuStrip1.Items.Add("Chọn", null,Chon_Click);
            contextMenuStrip1.Items.Add("Xoá", null, Xoa_Click);
            contextMenuStrip1.Items.Add("Bỏ chọn tất cả", null, BoChonTatCa_Click);
            contextMenuStrip1.Items.Add("Coppy", null, Xoa_Click);
            // Tạo ContextMenuStrip phụ (cho Option 1)
            subContextMenuStrip = new ContextMenuStrip();
            subContextMenuStrip.Items.Add("Tất cả", null, SubOption1_1_Click);
            subContextMenuStrip.Items.Add("Bôi đen", null, SubOption1_2_Click);
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

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Sử dụng phương thức HitTest để xác định vị trí của chuột
                DataGridView.HitTestInfo hitTestInfo = dataGridView1.HitTest(e.X, e.Y);

                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                    // Chọn dòng được click
                    dataGridView1.CurrentCell = dataGridView1.Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex];

                    // Lấy tọa độ màn hình của chuột
                    Point screenPoint = dataGridView1.PointToScreen(new Point(e.X, e.Y));

                    // Hiển thị menu ngữ cảnh tại vị trí chuột
                    contextMenuStrip1.Show(screenPoint);
                }
            }
        }


        private void Chon_Click(object sender, EventArgs e)
        {
            // Lấy tọa độ màn hình của chuột
            Point screenPoint = dataGridView1.PointToScreen(dataGridView1.GetCellDisplayRectangle(dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex, false).Location);

            subContextMenuStrip.Show(screenPoint);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 2");
        }

        private void BoChonTatCa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 2");
        }

        private void btn_nhap_tai_khoan_Click(object sender, EventArgs e)
        {

        }

        private void SubOption1_1_Click(object sender, EventArgs e)
        {
            // Xử lý cho SubOption 1.1
            MessageBox.Show("SubOption 1.1 selected");
        }

        private void SubOption1_2_Click(object sender, EventArgs e)
        {
            // Xử lý cho SubOption 1.2
            MessageBox.Show("SubOption 1.2 selected");
        }
        private void Option1MenuItem_MouseEnter(object sender, EventArgs e)
        {
            // Hiển thị ContextMenuStrip phụ khi chuột hover vào Option 1
            Point screenPoint = contextMenuStrip1.PointToScreen(((ToolStripItem)sender).ContentRectangle.Location);
            subContextMenuStrip.Show(screenPoint);
        }

    }
}
