namespace KimlikBilgileriOOP
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
            this.kimlikBilgileriGosterBT = new System.Windows.Forms.Button();
            this.ogrenciGosterBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kimlikBilgileriGosterBT
            // 
            this.kimlikBilgileriGosterBT.Location = new System.Drawing.Point(82, 65);
            this.kimlikBilgileriGosterBT.Name = "kimlikBilgileriGosterBT";
            this.kimlikBilgileriGosterBT.Size = new System.Drawing.Size(279, 23);
            this.kimlikBilgileriGosterBT.TabIndex = 0;
            this.kimlikBilgileriGosterBT.Text = "Kimlik Bilgileri Göster";
            this.kimlikBilgileriGosterBT.UseVisualStyleBackColor = true;
            this.kimlikBilgileriGosterBT.Click += new System.EventHandler(this.kimlikBilgileriGosterBT_Click);
            // 
            // ogrenciGosterBT
            // 
            this.ogrenciGosterBT.Location = new System.Drawing.Point(82, 110);
            this.ogrenciGosterBT.Name = "ogrenciGosterBT";
            this.ogrenciGosterBT.Size = new System.Drawing.Size(279, 23);
            this.ogrenciGosterBT.TabIndex = 1;
            this.ogrenciGosterBT.Text = "Öğrenci Sınıfı Göster (kimlik bilgileri ile birlikte)";
            this.ogrenciGosterBT.UseVisualStyleBackColor = true;
            this.ogrenciGosterBT.Click += new System.EventHandler(this.ogrenciGosterBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 276);
            this.Controls.Add(this.ogrenciGosterBT);
            this.Controls.Add(this.kimlikBilgileriGosterBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kimlikBilgileriGosterBT;
        private System.Windows.Forms.Button ogrenciGosterBT;
    }
}

