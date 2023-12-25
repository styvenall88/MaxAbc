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
    public partial class frm_quanlikichban : Form
    {     // Thêm khai báo cho contextMenuStrip1
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        public frm_quanlikichban()
        {
            InitializeComponent();
            // Thêm sự kiện cho dataGridView1
            dataGridView2.MouseDown += dataGridView2_MouseDown;

            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // Khởi tạo contextMenuStrip1
            InitializeContextMenu();
        }
        private void InitializeContextMenu()
        {
            // Khai báo và khởi tạo ContextMenuStrip
            contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip2 = new ContextMenuStrip();
            // Thêm các mục menu
            contextMenuStrip1.Items.Add("Thêm hành động", null, Them_Click);
            contextMenuStrip1.Items.Add("Xoá hành động", null, Xoa_Click);
            contextMenuStrip1.Items.Add("Sửa hành động", null, Sua_Click);
            contextMenuStrip1.Items.Add("Nhân bản hành động", null, Nhanban_Click);
            // data gird 1
            contextMenuStrip2.Items.Add("Thêm kịch bản", null, Themkichban_Click);
            contextMenuStrip2.Items.Add("Xoá kịch bản", null, Xoa_Click);
            contextMenuStrip2.Items.Add("Sửa kịch bản", null, Sua_Click);
            contextMenuStrip2.Items.Add("Nhân bản kịch bản", null, Nhanban_Click);
        }
        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Sử dụng phương thức HitTest để xác định vị trí của chuột
                DataGridView.HitTestInfo hitTestInfo = dataGridView2.HitTest(e.X, e.Y);

                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                    // Chọn dòng được click
                    dataGridView2.CurrentCell = dataGridView2.Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex];

                    // Lấy tọa độ màn hình của chuột
                    Point screenPoint = dataGridView2.PointToScreen(new Point(e.X, e.Y));

                    // Hiển thị menu ngữ cảnh tại vị trí chuột
                    contextMenuStrip1.Show(screenPoint);
                }
            }
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
                    contextMenuStrip2.Show(screenPoint);
                }
            }
        }



        private void Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 1");
        }
        private void Themkichban_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 1");
        }
        private void Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 2");
        }
        private void Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 1");
        }

        private void Nhanban_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected Option 2");
        }
    }
}
