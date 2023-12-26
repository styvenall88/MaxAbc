namespace MaxAbc
{
    partial class frm_nhaptaikhoan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_thumuc = new System.Windows.Forms.ComboBox();
            this.cbb_dinhdang = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(260, 236);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn thư mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Định dạng";
            // 
            // cbb_thumuc
            // 
            this.cbb_thumuc.FormattingEnabled = true;
            this.cbb_thumuc.Location = new System.Drawing.Point(88, 237);
            this.cbb_thumuc.Name = "cbb_thumuc";
            this.cbb_thumuc.Size = new System.Drawing.Size(150, 21);
            this.cbb_thumuc.TabIndex = 6;
            // 
            // cbb_dinhdang
            // 
            this.cbb_dinhdang.FormattingEnabled = true;
            this.cbb_dinhdang.Location = new System.Drawing.Point(88, 268);
            this.cbb_dinhdang.Name = "cbb_dinhdang";
            this.cbb_dinhdang.Size = new System.Drawing.Size(150, 21);
            this.cbb_dinhdang.TabIndex = 7;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(303, 297);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_nhaptaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cbb_dinhdang);
            this.Controls.Add(this.cbb_thumuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_nhaptaikhoan";
            this.Text = "frm_nhaptaikhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_thumuc;
        private System.Windows.Forms.ComboBox cbb_dinhdang;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button button1;
    }
}