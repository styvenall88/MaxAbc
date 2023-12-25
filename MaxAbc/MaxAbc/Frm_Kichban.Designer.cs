namespace MaxAbc
{
    partial class Frm_Kichban
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_quanlikichban = new System.Windows.Forms.Button();
            this.Btn_dong = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn kịch bản :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_quanlikichban
            // 
            this.btn_quanlikichban.Location = new System.Drawing.Point(267, 22);
            this.btn_quanlikichban.Name = "btn_quanlikichban";
            this.btn_quanlikichban.Size = new System.Drawing.Size(98, 23);
            this.btn_quanlikichban.TabIndex = 2;
            this.btn_quanlikichban.Text = "Quản lí kịch bản";
            this.btn_quanlikichban.UseVisualStyleBackColor = true;
            this.btn_quanlikichban.Click += new System.EventHandler(this.btn_quanlikichban_Click);
            // 
            // Btn_dong
            // 
            this.Btn_dong.Location = new System.Drawing.Point(366, 111);
            this.Btn_dong.Name = "Btn_dong";
            this.Btn_dong.Size = new System.Drawing.Size(98, 23);
            this.Btn_dong.TabIndex = 3;
            this.Btn_dong.Text = "Đóng";
            this.Btn_dong.UseVisualStyleBackColor = true;
            this.Btn_dong.Click += new System.EventHandler(this.Btn_dong_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(247, 111);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(98, 23);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // Frm_Kichban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 164);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.Btn_dong);
            this.Controls.Add(this.btn_quanlikichban);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Kichban";
            this.Text = "Frm_Kichban";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_quanlikichban;
        private System.Windows.Forms.Button Btn_dong;
        private System.Windows.Forms.Button btn_luu;
    }
}