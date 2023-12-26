namespace MaxAbc
{
    partial class frm_themkichban
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
            this.txt_tenkichban = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kịch bả";
            // 
            // txt_tenkichban
            // 
            this.txt_tenkichban.Location = new System.Drawing.Point(170, 47);
            this.txt_tenkichban.Name = "txt_tenkichban";
            this.txt_tenkichban.Size = new System.Drawing.Size(166, 20);
            this.txt_tenkichban.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(170, 94);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(277, 94);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 3;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // frm_themkichban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 166);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tenkichban);
            this.Controls.Add(this.label1);
            this.Name = "frm_themkichban";
            this.Text = "frm_themkichban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenkichban;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_dong;
    }
}