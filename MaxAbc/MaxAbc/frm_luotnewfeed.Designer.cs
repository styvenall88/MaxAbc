namespace MaxAbc
{
    partial class frm_luotnewfeed
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
            this.num_min = new System.Windows.Forms.NumericUpDown();
            this.num_max = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_them = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian xem :";
            // 
            // num_min
            // 
            this.num_min.Location = new System.Drawing.Point(129, 23);
            this.num_min.Name = "num_min";
            this.num_min.Size = new System.Drawing.Size(51, 20);
            this.num_min.TabIndex = 1;
            this.num_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_min.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // num_max
            // 
            this.num_max.Location = new System.Drawing.Point(229, 23);
            this.num_max.Name = "num_max";
            this.num_max.Size = new System.Drawing.Size(51, 20);
            this.num_max.TabIndex = 3;
            this.num_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_max.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giây";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(129, 131);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_luotnewfeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 180);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_max);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_min);
            this.Controls.Add(this.label1);
            this.Name = "frm_luotnewfeed";
            this.Text = "frm_luotnewfeed";
            ((System.ComponentModel.ISupportInitialize)(this.num_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_min;
        private System.Windows.Forms.NumericUpDown num_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button button2;
    }
}