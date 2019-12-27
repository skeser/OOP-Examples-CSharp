namespace AraliktakiTekCiftToplam
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
            this.baslangicLabel = new System.Windows.Forms.Label();
            this.bitisLabel = new System.Windows.Forms.Label();
            this.baslangicTextBox = new System.Windows.Forms.TextBox();
            this.bitisTextBox = new System.Windows.Forms.TextBox();
            this.tekLabel = new System.Windows.Forms.Label();
            this.ciftLabel = new System.Windows.Forms.Label();
            this.tekToplamShowLabel = new System.Windows.Forms.Label();
            this.ciftToplamResultLabel = new System.Windows.Forms.Label();
            this.hesaplaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baslangicLabel
            // 
            this.baslangicLabel.AutoSize = true;
            this.baslangicLabel.Location = new System.Drawing.Point(35, 47);
            this.baslangicLabel.Name = "baslangicLabel";
            this.baslangicLabel.Size = new System.Drawing.Size(116, 13);
            this.baslangicLabel.TabIndex = 0;
            this.baslangicLabel.Text = "Aralık Başlangıc Değeri";
            // 
            // bitisLabel
            // 
            this.bitisLabel.AutoSize = true;
            this.bitisLabel.Location = new System.Drawing.Point(35, 94);
            this.bitisLabel.Name = "bitisLabel";
            this.bitisLabel.Size = new System.Drawing.Size(89, 13);
            this.bitisLabel.TabIndex = 1;
            this.bitisLabel.Text = "Aralık Bitiş Değeri";
            // 
            // baslangicTextBox
            // 
            this.baslangicTextBox.Location = new System.Drawing.Point(222, 44);
            this.baslangicTextBox.Name = "baslangicTextBox";
            this.baslangicTextBox.Size = new System.Drawing.Size(166, 20);
            this.baslangicTextBox.TabIndex = 2;
            // 
            // bitisTextBox
            // 
            this.bitisTextBox.Location = new System.Drawing.Point(222, 94);
            this.bitisTextBox.Name = "bitisTextBox";
            this.bitisTextBox.Size = new System.Drawing.Size(166, 20);
            this.bitisTextBox.TabIndex = 3;
            // 
            // tekLabel
            // 
            this.tekLabel.AutoSize = true;
            this.tekLabel.Location = new System.Drawing.Point(35, 145);
            this.tekLabel.Name = "tekLabel";
            this.tekLabel.Size = new System.Drawing.Size(157, 13);
            this.tekLabel.TabIndex = 4;
            this.tekLabel.Text = "Aralıktaki  Sayıların Tek Toplamı";
            // 
            // ciftLabel
            // 
            this.ciftLabel.AutoSize = true;
            this.ciftLabel.Location = new System.Drawing.Point(35, 173);
            this.ciftLabel.Name = "ciftLabel";
            this.ciftLabel.Size = new System.Drawing.Size(150, 13);
            this.ciftLabel.TabIndex = 5;
            this.ciftLabel.Text = "Aralıktaki Sayıların Çift Toplamı";
            // 
            // tekToplamShowLabel
            // 
            this.tekToplamShowLabel.BackColor = System.Drawing.SystemColors.Info;
            this.tekToplamShowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tekToplamShowLabel.Location = new System.Drawing.Point(222, 145);
            this.tekToplamShowLabel.MaximumSize = new System.Drawing.Size(166, 15);
            this.tekToplamShowLabel.MinimumSize = new System.Drawing.Size(166, 15);
            this.tekToplamShowLabel.Name = "tekToplamShowLabel";
            this.tekToplamShowLabel.Size = new System.Drawing.Size(166, 15);
            this.tekToplamShowLabel.TabIndex = 6;
            // 
            // ciftToplamResultLabel
            // 
            this.ciftToplamResultLabel.BackColor = System.Drawing.SystemColors.Info;
            this.ciftToplamResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ciftToplamResultLabel.Location = new System.Drawing.Point(222, 173);
            this.ciftToplamResultLabel.MaximumSize = new System.Drawing.Size(166, 15);
            this.ciftToplamResultLabel.MinimumSize = new System.Drawing.Size(166, 15);
            this.ciftToplamResultLabel.Name = "ciftToplamResultLabel";
            this.ciftToplamResultLabel.Size = new System.Drawing.Size(166, 15);
            this.ciftToplamResultLabel.TabIndex = 7;
            // 
            // hesaplaButton
            // 
            this.hesaplaButton.Location = new System.Drawing.Point(225, 211);
            this.hesaplaButton.Name = "hesaplaButton";
            this.hesaplaButton.Size = new System.Drawing.Size(163, 23);
            this.hesaplaButton.TabIndex = 8;
            this.hesaplaButton.Text = "HESAPLA";
            this.hesaplaButton.UseVisualStyleBackColor = true;
            this.hesaplaButton.Click += new System.EventHandler(this.hesaplaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 316);
            this.Controls.Add(this.hesaplaButton);
            this.Controls.Add(this.ciftToplamResultLabel);
            this.Controls.Add(this.tekToplamShowLabel);
            this.Controls.Add(this.ciftLabel);
            this.Controls.Add(this.tekLabel);
            this.Controls.Add(this.bitisTextBox);
            this.Controls.Add(this.baslangicTextBox);
            this.Controls.Add(this.bitisLabel);
            this.Controls.Add(this.baslangicLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baslangicLabel;
        private System.Windows.Forms.Label bitisLabel;
        private System.Windows.Forms.TextBox baslangicTextBox;
        private System.Windows.Forms.TextBox bitisTextBox;
        private System.Windows.Forms.Label tekLabel;
        private System.Windows.Forms.Label ciftLabel;
        private System.Windows.Forms.Label tekToplamShowLabel;
        private System.Windows.Forms.Label ciftToplamResultLabel;
        private System.Windows.Forms.Button hesaplaButton;
    }
}

