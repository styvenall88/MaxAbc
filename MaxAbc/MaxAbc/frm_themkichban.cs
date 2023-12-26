using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxAbc
{
    public partial class frm_themkichban : Form
    {
        public frm_themkichban()
        {
            InitializeComponent();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public delegate void KichBanAddedEventHandler(object sender, KichBanAddedEventArgs e);
        public event KichBanAddedEventHandler KichBanAdded;

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tenKichBan = txt_tenkichban.Text;
            if(tenKichBan==null || tenKichBan.Length==0)
            {
                MessageBox.Show("Vui lòng nhập tên");
            }
            else
            {
                string _fullPatch = System.Reflection.Assembly.GetEntryAssembly().Location.ToString();
                // Kích hoạt sự kiện KichBanAdded để thông báo cho form khác
                string _patch = System.IO.Path.GetDirectoryName(_fullPatch);
                string _patch1 = _patch+ "\\Data\\danhsachkichban\\"+txt_tenkichban.Text+".txt";
                if (!File.Exists(_patch1))
                {
                    File.Create(_patch1).Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã có kjch bản tên tương tự");
                }
                
            }
            // Thêm dữ liệu vào cơ sở dữ liệu

        
        }

        protected virtual void OnKichBanAdded(KichBanAddedEventArgs e)
        {
            KichBanAdded?.Invoke(this, e);
        }
        public class KichBanAddedEventArgs : EventArgs
        {
            public string TenKichBan { get; }

            public KichBanAddedEventArgs(string tenKichBan)
            {
                TenKichBan = tenKichBan;
            }
        }
    }
}
