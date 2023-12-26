using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MaxAbc.frm_themkichban;

namespace MaxAbc
{
    public partial class frm_quanlikichban : Form
    {     // Thêm khai báo cho contextMenuStrip1
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        public frm_quanlikichban()
        {
            this.Load += frm_quanlikichban_Load;
            InitializeComponent();
            // Thêm sự kiện cho dataGridView1
            dataGridView2.MouseDown += dataGridView2_MouseDown;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;

            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // Khởi tạo contextMenuStrip1
            InitializeContextMenu();
       
        }
        private void frm_quanlikichban_Load(object sender, EventArgs e)
        {
            getDataKichBan();
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
        private void getDataKichBan()
        {
            string _fullPatch = System.Reflection.Assembly.GetEntryAssembly().Location.ToString();
            string _patch = System.IO.Path.GetDirectoryName(_fullPatch);
            string _patch1 = _patch + "\\Data\\danhsachkichban\\";
            string[] files = Directory.GetFiles(_patch1, "*.txt");

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Tenkichban");

            for (int i = 0; i < files.Length; i++)
            {
                string tenFile = Path.GetFileNameWithoutExtension(files[i]);
                DataRow row = dt.NewRow();
                row["STT"] = i + 1;
                row["Tenkichban"] = tenFile;
                dt.Rows.Add(row);
            }
            DataView dv = null;
            dv = dt.DefaultView;
          
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["STT"].Width = 60;
            dataGridView1.Columns["Tenkichban"].Width = 240;
            dataGridView1.Columns["Tenkichban"].HeaderText = "Tên kịch bản";
        }
        private void getDataHanhDong(string Tenkichban)
        {
            DataView dv = null;
            string _fullPatch = System.Reflection.Assembly.GetEntryAssembly().Location.ToString();
            string _patch = System.IO.Path.GetDirectoryName(_fullPatch);
            string _patch1 = _patch + "\\Data\\danhsachkichban\\" + Tenkichban + ".txt";
            string[] lines = System.IO.File.ReadAllLines(_patch1);
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Tai_khoan");
            int i = 0;
            foreach (string line in lines)
            {
                i++;
                string[] ACC = line.Split('|');
                DataRow row = dt.NewRow();
                row[0] = i;
                row[1] = ACC[0];
                //row[2] = ACC[1];
                dt.Rows.Add(row);
            
            ////

            }
            dv = dt.DefaultView;
            dataGridView1.Columns["STT"].Width = 60;
            dataGridView1.Columns["Tenkichban"].Width = 240;
            dataGridView1.Columns["Tenkichban"].HeaderText = "Tên hành đông ";
            dataGridView2.DataSource = dv;
        }
        public class FileInfo
        {
            public int STT { get; set; }
            public string TenKichBan { get; set; }
        }
        private void OpenThemKichBanForm()
        {
            frm_themkichban themKichBanForm = new frm_themkichban();
            themKichBanForm.KichBanAdded += ThemKichBanForm_KichBanAdded;
            themKichBanForm.Show();
        }

        private void ThemKichBanForm_KichBanAdded(object sender, KichBanAddedEventArgs e)

        { 
            MessageBox.Show($"Added KichBan: {e.TenKichBan}");
            // Xử lý cập nhật datagridview1 ở đây
            // Dữ liệu bạn muốn truyền nằm trong e.TenKichBan
            // Cập nhật dữ liệu vào cột "tenkichban_colum" của DataGridView
            dataGridView1.Rows.Add(e.TenKichBan);
        }


        private void Them_Click(object sender, EventArgs e)
        {
            frm_themhanhdong f = new frm_themhanhdong();
            f.ShowDialog();
        }
        private void Themkichban_Click(object sender, EventArgs e)
        {
            frm_themkichban f = new frm_themkichban();
            f.ShowDialog();
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào cột "Tenkichban"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Tenkichban" && e.RowIndex >= 0)
            {
                // Lấy giá trị của ô "Tenkichban" trong dòng được chọn
                string tenKichBanValue = dataGridView1.Rows[e.RowIndex].Cells["Tenkichban"].Value.ToString();
                getDataHanhDong(tenKichBanValue);

            }
        }
    }
}
