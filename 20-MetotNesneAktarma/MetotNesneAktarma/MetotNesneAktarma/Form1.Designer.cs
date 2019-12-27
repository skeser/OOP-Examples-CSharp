namespace MetotNesneAktarma
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
            this.adTB = new System.Windows.Forms.TextBox();
            this.soyadTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adTB
            // 
            this.adTB.Location = new System.Drawing.Point(90, 45);
            this.adTB.Name = "adTB";
            this.adTB.Size = new System.Drawing.Size(234, 20);
            this.adTB.TabIndex = 0;
            // 
            // soyadTB
            // 
            this.soyadTB.Location = new System.Drawing.Point(90, 75);
            this.soyadTB.Name = "soyadTB";
            this.soyadTB.Size = new System.Drawing.Size(234, 20);
            this.soyadTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad :";
            // 
            // testBT
            // 
            this.testBT.Location = new System.Drawing.Point(90, 102);
            this.testBT.Name = "testBT";
            this.testBT.Size = new System.Drawing.Size(234, 23);
            this.testBT.TabIndex = 4;
            this.testBT.Text = "TEST";
            this.testBT.UseVisualStyleBackColor = true;
            this.testBT.Click += new System.EventHandler(this.testBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 168);
            this.Controls.Add(this.testBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soyadTB);
            this.Controls.Add(this.adTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adTB;
        private System.Windows.Forms.TextBox soyadTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testBT;
    }
}

