namespace MaxAbc
{
    partial class frm_themhanhdong
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
            this.btn_docthongbao = new System.Windows.Forms.Button();
            this.btn_luotnewfeed = new System.Windows.Forms.Button();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.btn_avatar = new System.Windows.Forms.Button();
            this.btn_dangxuatthiebicu = new System.Windows.Forms.Button();
            this.btn_nhantinpage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_docthongbao
            // 
            this.btn_docthongbao.Location = new System.Drawing.Point(12, 50);
            this.btn_docthongbao.Name = "btn_docthongbao";
            this.btn_docthongbao.Size = new System.Drawing.Size(121, 28);
            this.btn_docthongbao.TabIndex = 0;
            this.btn_docthongbao.Text = "Đọc thông bác";
            this.btn_docthongbao.UseVisualStyleBackColor = true;
            // 
            // btn_luotnewfeed
            // 
            this.btn_luotnewfeed.Location = new System.Drawing.Point(12, 93);
            this.btn_luotnewfeed.Name = "btn_luotnewfeed";
            this.btn_luotnewfeed.Size = new System.Drawing.Size(121, 28);
            this.btn_luotnewfeed.TabIndex = 1;
            this.btn_luotnewfeed.Text = "Lướt newfeed";
            this.btn_luotnewfeed.UseVisualStyleBackColor = true;
            this.btn_luotnewfeed.Click += new System.EventHandler(this.btn_luotnewfeed_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Location = new System.Drawing.Point(427, 93);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(121, 28);
            this.btn_doimatkhau.TabIndex = 3;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = true;
            // 
            // btn_avatar
            // 
            this.btn_avatar.Location = new System.Drawing.Point(427, 50);
            this.btn_avatar.Name = "btn_avatar";
            this.btn_avatar.Size = new System.Drawing.Size(121, 28);
            this.btn_avatar.TabIndex = 2;
            this.btn_avatar.Text = "Up avatar";
            this.btn_avatar.UseVisualStyleBackColor = true;
            // 
            // btn_dangxuatthiebicu
            // 
            this.btn_dangxuatthiebicu.Location = new System.Drawing.Point(427, 136);
            this.btn_dangxuatthiebicu.Name = "btn_dangxuatthiebicu";
            this.btn_dangxuatthiebicu.Size = new System.Drawing.Size(121, 28);
            this.btn_dangxuatthiebicu.TabIndex = 4;
            this.btn_dangxuatthiebicu.Text = "Đăng xuất thiết bị cũ";
            this.btn_dangxuatthiebicu.UseVisualStyleBackColor = true;
            // 
            // btn_nhantinpage
            // 
            this.btn_nhantinpage.Location = new System.Drawing.Point(223, 50);
            this.btn_nhantinpage.Name = "btn_nhantinpage";
            this.btn_nhantinpage.Size = new System.Drawing.Size(121, 28);
            this.btn_nhantinpage.TabIndex = 5;
            this.btn_nhantinpage.Text = "Nhắn tin cho page";
            this.btn_nhantinpage.UseVisualStyleBackColor = true;
            this.btn_nhantinpage.Click += new System.EventHandler(this.btn_nhantinpage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tương tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đổi thông tin";
            // 
            // frm_themhanhdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nhantinpage);
            this.Controls.Add(this.btn_dangxuatthiebicu);
            this.Controls.Add(this.btn_doimatkhau);
            this.Controls.Add(this.btn_avatar);
            this.Controls.Add(this.btn_luotnewfeed);
            this.Controls.Add(this.btn_docthongbao);
            this.Name = "frm_themhanhdong";
            this.Text = "frm_themhanhdong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_docthongbao;
        private System.Windows.Forms.Button btn_luotnewfeed;
        private System.Windows.Forms.Button btn_doimatkhau;
        private System.Windows.Forms.Button btn_avatar;
        private System.Windows.Forms.Button btn_dangxuatthiebicu;
        private System.Windows.Forms.Button btn_nhantinpage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}