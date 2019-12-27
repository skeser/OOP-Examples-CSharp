namespace AralikAsalSayiBul
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
            this.minTB = new System.Windows.Forms.TextBox();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.asalSayiBulBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(154, 49);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(204, 20);
            this.minTB.TabIndex = 2;
            // 
            // maxTB
            // 
            this.maxTB.Location = new System.Drawing.Point(154, 79);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(204, 20);
            this.maxTB.TabIndex = 3;
            // 
            // asalSayiBulBT
            // 
            this.asalSayiBulBT.Location = new System.Drawing.Point(154, 117);
            this.asalSayiBulBT.Name = "asalSayiBulBT";
            this.asalSayiBulBT.Size = new System.Drawing.Size(204, 23);
            this.asalSayiBulBT.TabIndex = 4;
            this.asalSayiBulBT.Text = "Min Max Arasi Asal Sayilari Goster";
            this.asalSayiBulBT.UseVisualStyleBackColor = true;
            this.asalSayiBulBT.Click += new System.EventHandler(this.asalSayiBulBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 264);
            this.Controls.Add(this.asalSayiBulBT);
            this.Controls.Add(this.maxTB);
            this.Controls.Add(this.minTB);
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
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.Button asalSayiBulBT;
    }
}

