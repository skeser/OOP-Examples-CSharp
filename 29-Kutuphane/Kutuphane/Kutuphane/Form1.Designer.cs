namespace Kutuphane
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
            this.isbnTB = new System.Windows.Forms.TextBox();
            this.kitapAdiTB = new System.Windows.Forms.TextBox();
            this.yazarTB = new System.Windows.Forms.TextBox();
            this.alisTarhiTB = new System.Windows.Forms.TextBox();
            this.iadeTarihTB = new System.Windows.Forms.TextBox();
            this.kitapEkleBT = new System.Windows.Forms.Button();
            this.litapListeBT = new System.Windows.Forms.Button();
            this.kutuphaneBosaltBT = new System.Windows.Forms.Button();
            this.kitapListesiTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alis Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "İade Tarih";
            // 
            // isbnTB
            // 
            this.isbnTB.Location = new System.Drawing.Point(115, 29);
            this.isbnTB.Name = "isbnTB";
            this.isbnTB.Size = new System.Drawing.Size(476, 20);
            this.isbnTB.TabIndex = 5;
            // 
            // kitapAdiTB
            // 
            this.kitapAdiTB.Location = new System.Drawing.Point(115, 61);
            this.kitapAdiTB.Name = "kitapAdiTB";
            this.kitapAdiTB.Size = new System.Drawing.Size(476, 20);
            this.kitapAdiTB.TabIndex = 6;
            // 
            // yazarTB
            // 
            this.yazarTB.Location = new System.Drawing.Point(115, 93);
            this.yazarTB.Name = "yazarTB";
            this.yazarTB.Size = new System.Drawing.Size(476, 20);
            this.yazarTB.TabIndex = 7;
            // 
            // alisTarhiTB
            // 
            this.alisTarhiTB.Location = new System.Drawing.Point(115, 123);
            this.alisTarhiTB.Name = "alisTarhiTB";
            this.alisTarhiTB.Size = new System.Drawing.Size(476, 20);
            this.alisTarhiTB.TabIndex = 8;
            // 
            // iadeTarihTB
            // 
            this.iadeTarihTB.Location = new System.Drawing.Point(115, 149);
            this.iadeTarihTB.Name = "iadeTarihTB";
            this.iadeTarihTB.Size = new System.Drawing.Size(476, 20);
            this.iadeTarihTB.TabIndex = 9;
            // 
            // kitapEkleBT
            // 
            this.kitapEkleBT.Location = new System.Drawing.Point(115, 176);
            this.kitapEkleBT.Name = "kitapEkleBT";
            this.kitapEkleBT.Size = new System.Drawing.Size(476, 23);
            this.kitapEkleBT.TabIndex = 10;
            this.kitapEkleBT.Text = "Kitap Ekle";
            this.kitapEkleBT.UseVisualStyleBackColor = true;
            this.kitapEkleBT.Click += new System.EventHandler(this.kitapEkleBT_Click);
            // 
            // litapListeBT
            // 
            this.litapListeBT.Location = new System.Drawing.Point(62, 210);
            this.litapListeBT.Name = "litapListeBT";
            this.litapListeBT.Size = new System.Drawing.Size(415, 23);
            this.litapListeBT.TabIndex = 11;
            this.litapListeBT.Text = "Kitap Listele";
            this.litapListeBT.UseVisualStyleBackColor = true;
            this.litapListeBT.Click += new System.EventHandler(this.litapListeBT_Click);
            // 
            // kutuphaneBosaltBT
            // 
            this.kutuphaneBosaltBT.Location = new System.Drawing.Point(483, 211);
            this.kutuphaneBosaltBT.Name = "kutuphaneBosaltBT";
            this.kutuphaneBosaltBT.Size = new System.Drawing.Size(108, 23);
            this.kutuphaneBosaltBT.TabIndex = 12;
            this.kutuphaneBosaltBT.Text = "Kutuphane Boşalt";
            this.kutuphaneBosaltBT.UseVisualStyleBackColor = true;
            this.kutuphaneBosaltBT.Click += new System.EventHandler(this.kutuphaneBosaltBT_Click);
            // 
            // kitapListesiTB
            // 
            this.kitapListesiTB.Location = new System.Drawing.Point(62, 240);
            this.kitapListesiTB.Multiline = true;
            this.kitapListesiTB.Name = "kitapListesiTB";
            this.kitapListesiTB.Size = new System.Drawing.Size(529, 140);
            this.kitapListesiTB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 396);
            this.Controls.Add(this.kitapListesiTB);
            this.Controls.Add(this.kutuphaneBosaltBT);
            this.Controls.Add(this.litapListeBT);
            this.Controls.Add(this.kitapEkleBT);
            this.Controls.Add(this.iadeTarihTB);
            this.Controls.Add(this.alisTarhiTB);
            this.Controls.Add(this.yazarTB);
            this.Controls.Add(this.kitapAdiTB);
            this.Controls.Add(this.isbnTB);
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
        private System.Windows.Forms.TextBox isbnTB;
        private System.Windows.Forms.TextBox kitapAdiTB;
        private System.Windows.Forms.TextBox yazarTB;
        private System.Windows.Forms.TextBox alisTarhiTB;
        private System.Windows.Forms.TextBox iadeTarihTB;
        private System.Windows.Forms.Button kitapEkleBT;
        private System.Windows.Forms.Button litapListeBT;
        private System.Windows.Forms.Button kutuphaneBosaltBT;
        private System.Windows.Forms.TextBox kitapListesiTB;
    }
}

