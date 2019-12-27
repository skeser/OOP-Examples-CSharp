namespace SifirGirSayTopla
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
            this.girSayiTB = new System.Windows.Forms.TextBox();
            this.toplaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0 girilene kadarki girilen sayıların toplamini ekrana yazdıran program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı Gir";
            // 
            // girSayiTB
            // 
            this.girSayiTB.Location = new System.Drawing.Point(125, 94);
            this.girSayiTB.Name = "girSayiTB";
            this.girSayiTB.Size = new System.Drawing.Size(172, 20);
            this.girSayiTB.TabIndex = 2;
            // 
            // toplaBT
            // 
            this.toplaBT.Location = new System.Drawing.Point(125, 129);
            this.toplaBT.Name = "toplaBT";
            this.toplaBT.Size = new System.Drawing.Size(172, 23);
            this.toplaBT.TabIndex = 3;
            this.toplaBT.Text = "TOPLA";
            this.toplaBT.UseVisualStyleBackColor = true;
            this.toplaBT.Click += new System.EventHandler(this.toplaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 258);
            this.Controls.Add(this.toplaBT);
            this.Controls.Add(this.girSayiTB);
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
        private System.Windows.Forms.TextBox girSayiTB;
        private System.Windows.Forms.Button toplaBT;
    }
}

