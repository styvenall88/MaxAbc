namespace MaxAbc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_chay_tuong_tac = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_nhap_tai_khoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_cauhinhchung = new System.Windows.Forms.Button();
            this.btn_cauhinhtuongtac = new System.Windows.Forms.Button();
            this.chon_colum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stt_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uid_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_chay_tuong_tac
            // 
            this.btn_chay_tuong_tac.Location = new System.Drawing.Point(0, 29);
            this.btn_chay_tuong_tac.Name = "btn_chay_tuong_tac";
            this.btn_chay_tuong_tac.Size = new System.Drawing.Size(96, 35);
            this.btn_chay_tuong_tac.TabIndex = 0;
            this.btn_chay_tuong_tac.Text = "Chạy tương tác ";
            this.btn_chay_tuong_tac.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon_colum,
            this.stt_colum,
            this.Uid_colum,
            this.pass_colum,
            this.tinhtrang_colum,
            this.trangthai_colum});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1075, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_nhap_tai_khoan
            // 
            this.btn_nhap_tai_khoan.Location = new System.Drawing.Point(927, 12);
            this.btn_nhap_tai_khoan.Name = "btn_nhap_tai_khoan";
            this.btn_nhap_tai_khoan.Size = new System.Drawing.Size(96, 35);
            this.btn_nhap_tai_khoan.TabIndex = 2;
            this.btn_nhap_tai_khoan.Text = "Nhập tài khoản ";
            this.btn_nhap_tai_khoan.UseVisualStyleBackColor = true;
            this.btn_nhap_tai_khoan.Click += new System.EventHandler(this.btn_nhap_tai_khoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thư mục";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(681, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_cauhinhchung
            // 
            this.btn_cauhinhchung.Location = new System.Drawing.Point(0, 2);
            this.btn_cauhinhchung.Name = "btn_cauhinhchung";
            this.btn_cauhinhchung.Size = new System.Drawing.Size(96, 28);
            this.btn_cauhinhchung.TabIndex = 5;
            this.btn_cauhinhchung.Text = "Cấu hình chung";
            this.btn_cauhinhchung.UseVisualStyleBackColor = true;
            this.btn_cauhinhchung.Click += new System.EventHandler(this.btn_cauhinhchung_Click);
            // 
            // btn_cauhinhtuongtac
            // 
            this.btn_cauhinhtuongtac.Location = new System.Drawing.Point(102, 2);
            this.btn_cauhinhtuongtac.Name = "btn_cauhinhtuongtac";
            this.btn_cauhinhtuongtac.Size = new System.Drawing.Size(111, 28);
            this.btn_cauhinhtuongtac.TabIndex = 6;
            this.btn_cauhinhtuongtac.Text = "Cấu hình tương tác";
            this.btn_cauhinhtuongtac.UseVisualStyleBackColor = true;
            this.btn_cauhinhtuongtac.Click += new System.EventHandler(this.btn_cauhinhtuongtac_Click);
            // 
            // chon_colum
            // 
            this.chon_colum.HeaderText = "Chọn";
            this.chon_colum.Name = "chon_colum";
            this.chon_colum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chon_colum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chon_colum.Width = 50;
            // 
            // stt_colum
            // 
            this.stt_colum.HeaderText = "Stt";
            this.stt_colum.Name = "stt_colum";
            this.stt_colum.Width = 60;
            // 
            // Uid_colum
            // 
            this.Uid_colum.HeaderText = "UID";
            this.Uid_colum.Name = "Uid_colum";
            this.Uid_colum.Width = 150;
            // 
            // pass_colum
            // 
            this.pass_colum.HeaderText = "Pass";
            this.pass_colum.Name = "pass_colum";
            this.pass_colum.Width = 120;
            // 
            // tinhtrang_colum
            // 
            this.tinhtrang_colum.HeaderText = "Tình trạng";
            this.tinhtrang_colum.Name = "tinhtrang_colum";
            this.tinhtrang_colum.Width = 160;
            // 
            // trangthai_colum
            // 
            this.trangthai_colum.HeaderText = "Trạng thái";
            this.trangthai_colum.Name = "trangthai_colum";
            this.trangthai_colum.Width = 190;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 463);
            this.Controls.Add(this.btn_cauhinhtuongtac);
            this.Controls.Add(this.btn_cauhinhchung);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nhap_tai_khoan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_chay_tuong_tac);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_chay_tuong_tac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_nhap_tai_khoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_cauhinhchung;
        private System.Windows.Forms.Button btn_cauhinhtuongtac;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon_colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt_colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid_colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang_colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai_colum;
    }
}

