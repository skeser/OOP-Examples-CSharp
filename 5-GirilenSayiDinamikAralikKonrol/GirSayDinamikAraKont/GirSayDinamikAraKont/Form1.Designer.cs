namespace GirSayDinamikAraKont
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
            this.minTB = new System.Windows.Forms.TextBox();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.kontBT = new System.Windows.Forms.Button();
            this.kontrolTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min Deger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Deger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontrol Sayısı";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(130, 63);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(166, 20);
            this.minTB.TabIndex = 3;
            // 
            // maxTB
            // 
            this.maxTB.Location = new System.Drawing.Point(130, 102);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(166, 20);
            this.maxTB.TabIndex = 4;
            // 
            // kontBT
            // 
            this.kontBT.Location = new System.Drawing.Point(130, 173);
            this.kontBT.Name = "kontBT";
            this.kontBT.Size = new System.Drawing.Size(166, 23);
            this.kontBT.TabIndex = 5;
            this.kontBT.Text = "KONTROL ET";
            this.kontBT.UseVisualStyleBackColor = true;
            this.kontBT.Click += new System.EventHandler(this.kontBT_Click);
            // 
            // kontrolTB
            // 
            this.kontrolTB.Location = new System.Drawing.Point(130, 138);
            this.kontrolTB.Name = "kontrolTB";
            this.kontrolTB.Size = new System.Drawing.Size(166, 20);
            this.kontrolTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 284);
            this.Controls.Add(this.kontrolTB);
            this.Controls.Add(this.kontBT);
            this.Controls.Add(this.maxTB);
            this.Controls.Add(this.minTB);
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
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.Button kontBT;
        private System.Windows.Forms.TextBox kontrolTB;
    }
}

