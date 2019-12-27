namespace GirSayFaktoriyelBul
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sayiTB = new System.Windows.Forms.TextBox();
            this.sonucFaktoriyelLB = new System.Windows.Forms.Label();
            this.faktoriyelHesaplaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pozitif Sayı Gir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Girilen Sayının Faktöriyeli";
            // 
            // sayiTB
            // 
            this.sayiTB.Location = new System.Drawing.Point(173, 61);
            this.sayiTB.Name = "sayiTB";
            this.sayiTB.Size = new System.Drawing.Size(160, 20);
            this.sayiTB.TabIndex = 2;
            // 
            // sonucFaktoriyelLB
            // 
            this.sonucFaktoriyelLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sonucFaktoriyelLB.Location = new System.Drawing.Point(173, 113);
            this.sonucFaktoriyelLB.MaximumSize = new System.Drawing.Size(160, 15);
            this.sonucFaktoriyelLB.MinimumSize = new System.Drawing.Size(160, 15);
            this.sonucFaktoriyelLB.Name = "sonucFaktoriyelLB";
            this.sonucFaktoriyelLB.Size = new System.Drawing.Size(160, 15);
            this.sonucFaktoriyelLB.TabIndex = 3;
            // 
            // faktoriyelHesaplaBT
            // 
            this.faktoriyelHesaplaBT.Location = new System.Drawing.Point(173, 153);
            this.faktoriyelHesaplaBT.Name = "faktoriyelHesaplaBT";
            this.faktoriyelHesaplaBT.Size = new System.Drawing.Size(160, 23);
            this.faktoriyelHesaplaBT.TabIndex = 4;
            this.faktoriyelHesaplaBT.Text = "Faktöriyel Hesapla";
            this.faktoriyelHesaplaBT.UseVisualStyleBackColor = true;
            this.faktoriyelHesaplaBT.Click += new System.EventHandler(this.faktoriyelHesaplaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 290);
            this.Controls.Add(this.faktoriyelHesaplaBT);
            this.Controls.Add(this.sonucFaktoriyelLB);
            this.Controls.Add(this.sayiTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sayiTB;
        private System.Windows.Forms.Label sonucFaktoriyelLB;
        private System.Windows.Forms.Button faktoriyelHesaplaBT;
    }
}

