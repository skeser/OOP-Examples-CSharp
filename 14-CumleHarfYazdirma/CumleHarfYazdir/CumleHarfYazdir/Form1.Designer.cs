namespace CumleHarfYazdir
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
            this.cumleTB1 = new System.Windows.Forms.TextBox();
            this.harfYazdirBT = new System.Windows.Forms.Button();
            this.cumleYazdirBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cumleTB1
            // 
            this.cumleTB1.Location = new System.Drawing.Point(12, 46);
            this.cumleTB1.MaxLength = 50;
            this.cumleTB1.Name = "cumleTB1";
            this.cumleTB1.Size = new System.Drawing.Size(430, 20);
            this.cumleTB1.TabIndex = 0;
            this.cumleTB1.Text = "Cümleyi Giriniz ... (Max 50 Karakater)";
            // 
            // harfYazdirBT
            // 
            this.harfYazdirBT.Location = new System.Drawing.Point(12, 72);
            this.harfYazdirBT.Name = "harfYazdirBT";
            this.harfYazdirBT.Size = new System.Drawing.Size(430, 23);
            this.harfYazdirBT.TabIndex = 1;
            this.harfYazdirBT.Text = "Harf Harf Yazdir";
            this.harfYazdirBT.UseVisualStyleBackColor = true;
            this.harfYazdirBT.Click += new System.EventHandler(this.harfYazdirBT_Click);
            // 
            // cumleYazdirBT
            // 
            this.cumleYazdirBT.Location = new System.Drawing.Point(12, 101);
            this.cumleYazdirBT.Name = "cumleYazdirBT";
            this.cumleYazdirBT.Size = new System.Drawing.Size(430, 23);
            this.cumleYazdirBT.TabIndex = 2;
            this.cumleYazdirBT.Text = "Tumunu Yazdir";
            this.cumleYazdirBT.UseVisualStyleBackColor = true;
            this.cumleYazdirBT.Click += new System.EventHandler(this.cumleYazdirBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 146);
            this.Controls.Add(this.cumleYazdirBT);
            this.Controls.Add(this.harfYazdirBT);
            this.Controls.Add(this.cumleTB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cumleTB1;
        private System.Windows.Forms.Button harfYazdirBT;
        private System.Windows.Forms.Button cumleYazdirBT;
    }
}

