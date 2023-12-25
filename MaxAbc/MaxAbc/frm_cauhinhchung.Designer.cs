namespace MaxAbc
{
    partial class frm_cauhinhchung
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soluongchay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_cauhinhproxy = new System.Windows.Forms.ComboBox();
            this.Btn_Luu = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số luồng chạy";
            // 
            // txt_soluongchay
            // 
            this.txt_soluongchay.Location = new System.Drawing.Point(93, 40);
            this.txt_soluongchay.Name = "txt_soluongchay";
            this.txt_soluongchay.Size = new System.Drawing.Size(41, 20);
            this.txt_soluongchay.TabIndex = 1;
            this.txt_soluongchay.Text = "3";
            this.txt_soluongchay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cấu hình player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đường dẫn :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "3";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cấu hình ip :";
            // 
            // cbb_cauhinhproxy
            // 
            this.cbb_cauhinhproxy.FormattingEnabled = true;
            this.cbb_cauhinhproxy.Location = new System.Drawing.Point(550, 39);
            this.cbb_cauhinhproxy.Name = "cbb_cauhinhproxy";
            this.cbb_cauhinhproxy.Size = new System.Drawing.Size(121, 21);
            this.cbb_cauhinhproxy.TabIndex = 6;
            // 
            // Btn_Luu
            // 
            this.Btn_Luu.Location = new System.Drawing.Point(272, 197);
            this.Btn_Luu.Name = "Btn_Luu";
            this.Btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.Btn_Luu.TabIndex = 7;
            this.Btn_Luu.Text = "Lưu";
            this.Btn_Luu.UseVisualStyleBackColor = true;
            this.Btn_Luu.Click += new System.EventHandler(this.Btn_Luu_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(370, 197);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 8;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // frm_cauhinhchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.Btn_Luu);
            this.Controls.Add(this.cbb_cauhinhproxy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_soluongchay);
            this.Controls.Add(this.label1);
            this.Name = "frm_cauhinhchung";
            this.Text = "frm_cauhinhchung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soluongchay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_cauhinhproxy;
        private System.Windows.Forms.Button Btn_Luu;
        private System.Windows.Forms.Button btn_dong;
    }
}