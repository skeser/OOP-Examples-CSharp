namespace HaliHesapOOP
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
            this.uzunlukTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genislikTB = new System.Windows.Forms.TextBox();
            this.sonucLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uzunlukTB
            // 
            this.uzunlukTB.Location = new System.Drawing.Point(101, 60);
            this.uzunlukTB.Name = "uzunlukTB";
            this.uzunlukTB.Size = new System.Drawing.Size(175, 20);
            this.uzunlukTB.TabIndex = 0;
            this.uzunlukTB.TextChanged += new System.EventHandler(this.uzunlukTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uzunluk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genişlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sonuc : ";
            // 
            // genislikTB
            // 
            this.genislikTB.Location = new System.Drawing.Point(101, 94);
            this.genislikTB.Name = "genislikTB";
            this.genislikTB.Size = new System.Drawing.Size(175, 20);
            this.genislikTB.TabIndex = 4;
            this.genislikTB.TextChanged += new System.EventHandler(this.genislikTB_TextChanged);
            // 
            // sonucLB
            // 
            this.sonucLB.AutoSize = true;
            this.sonucLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sonucLB.Location = new System.Drawing.Point(101, 128);
            this.sonucLB.MaximumSize = new System.Drawing.Size(175, 20);
            this.sonucLB.MinimumSize = new System.Drawing.Size(175, 20);
            this.sonucLB.Name = "sonucLB";
            this.sonucLB.Size = new System.Drawing.Size(175, 20);
            this.sonucLB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 240);
            this.Controls.Add(this.sonucLB);
            this.Controls.Add(this.genislikTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uzunlukTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uzunlukTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox genislikTB;
        private System.Windows.Forms.Label sonucLB;
    }
}

