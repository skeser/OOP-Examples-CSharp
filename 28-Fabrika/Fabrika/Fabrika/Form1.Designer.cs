namespace Fabrika
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.perNoTB = new System.Windows.Forms.TextBox();
            this.tcNoTB = new System.Windows.Forms.TextBox();
            this.adTB = new System.Windows.Forms.TextBox();
            this.soyadTB = new System.Windows.Forms.TextBox();
            this.birimTB = new System.Windows.Forms.TextBox();
            this.perListTB = new System.Windows.Forms.TextBox();
            this.perEkleBT = new System.Windows.Forms.Button();
            this.perListBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birim";
            // 
            // perNoTB
            // 
            this.perNoTB.Location = new System.Drawing.Point(159, 50);
            this.perNoTB.Name = "perNoTB";
            this.perNoTB.Size = new System.Drawing.Size(138, 20);
            this.perNoTB.TabIndex = 5;
            // 
            // tcNoTB
            // 
            this.tcNoTB.Location = new System.Drawing.Point(159, 76);
            this.tcNoTB.Name = "tcNoTB";
            this.tcNoTB.Size = new System.Drawing.Size(138, 20);
            this.tcNoTB.TabIndex = 6;
            // 
            // adTB
            // 
            this.adTB.Location = new System.Drawing.Point(159, 103);
            this.adTB.Name = "adTB";
            this.adTB.Size = new System.Drawing.Size(138, 20);
            this.adTB.TabIndex = 7;
            // 
            // soyadTB
            // 
            this.soyadTB.Location = new System.Drawing.Point(159, 126);
            this.soyadTB.Name = "soyadTB";
            this.soyadTB.Size = new System.Drawing.Size(138, 20);
            this.soyadTB.TabIndex = 8;
            // 
            // birimTB
            // 
            this.birimTB.Location = new System.Drawing.Point(159, 153);
            this.birimTB.Name = "birimTB";
            this.birimTB.Size = new System.Drawing.Size(138, 20);
            this.birimTB.TabIndex = 9;
            // 
            // perListTB
            // 
            this.perListTB.Location = new System.Drawing.Point(76, 248);
            this.perListTB.Multiline = true;
            this.perListTB.Name = "perListTB";
            this.perListTB.Size = new System.Drawing.Size(221, 132);
            this.perListTB.TabIndex = 10;
            // 
            // perEkleBT
            // 
            this.perEkleBT.Location = new System.Drawing.Point(159, 180);
            this.perEkleBT.Name = "perEkleBT";
            this.perEkleBT.Size = new System.Drawing.Size(138, 23);
            this.perEkleBT.TabIndex = 11;
            this.perEkleBT.Text = "Personel Ekle";
            this.perEkleBT.UseVisualStyleBackColor = true;
            this.perEkleBT.Click += new System.EventHandler(this.perEkleBT_Click);
            // 
            // perListBT
            // 
            this.perListBT.Location = new System.Drawing.Point(76, 219);
            this.perListBT.Name = "perListBT";
            this.perListBT.Size = new System.Drawing.Size(221, 23);
            this.perListBT.TabIndex = 12;
            this.perListBT.Text = "Personel Listele";
            this.perListBT.UseVisualStyleBackColor = true;
            this.perListBT.Click += new System.EventHandler(this.perListBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.perListBT);
            this.Controls.Add(this.perEkleBT);
            this.Controls.Add(this.perListTB);
            this.Controls.Add(this.birimTB);
            this.Controls.Add(this.soyadTB);
            this.Controls.Add(this.adTB);
            this.Controls.Add(this.tcNoTB);
            this.Controls.Add(this.perNoTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox perNoTB;
        private System.Windows.Forms.TextBox tcNoTB;
        private System.Windows.Forms.TextBox adTB;
        private System.Windows.Forms.TextBox soyadTB;
        private System.Windows.Forms.TextBox birimTB;
        private System.Windows.Forms.TextBox perListTB;
        private System.Windows.Forms.Button perEkleBT;
        private System.Windows.Forms.Button perListBT;
    }
}

