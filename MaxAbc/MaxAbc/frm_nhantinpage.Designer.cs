namespace MaxAbc
{
    partial class frm_nhantinpage
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
            this.btn_layfilelinkpage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_layfilelinkpage
            // 
            this.btn_layfilelinkpage.Location = new System.Drawing.Point(183, 29);
            this.btn_layfilelinkpage.Name = "btn_layfilelinkpage";
            this.btn_layfilelinkpage.Size = new System.Drawing.Size(110, 28);
            this.btn_layfilelinkpage.TabIndex = 0;
            this.btn_layfilelinkpage.Text = "Chọn file link page";
            this.btn_layfilelinkpage.UseVisualStyleBackColor = true;
            this.btn_layfilelinkpage.Click += new System.EventHandler(this.btn_layfilelinkpage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mỗi dòng 1 link, và dùng file txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_nhantinpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_layfilelinkpage);
            this.Name = "frm_nhantinpage";
            this.Text = "frm_nhantinpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_layfilelinkpage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}