namespace IlPlaka
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
            this.plakaCB = new System.Windows.Forms.ComboBox();
            this.gosterBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka Kodu Seç";
            // 
            // plakaCB
            // 
            this.plakaCB.FormattingEnabled = true;
            this.plakaCB.Items.AddRange(new object[] {
            "45",
            "35",
            "06"});
            this.plakaCB.Location = new System.Drawing.Point(136, 81);
            this.plakaCB.Name = "plakaCB";
            this.plakaCB.Size = new System.Drawing.Size(175, 21);
            this.plakaCB.TabIndex = 1;
            // 
            // gosterBT
            // 
            this.gosterBT.Location = new System.Drawing.Point(136, 129);
            this.gosterBT.Name = "gosterBT";
            this.gosterBT.Size = new System.Drawing.Size(175, 23);
            this.gosterBT.TabIndex = 2;
            this.gosterBT.Text = "Göster";
            this.gosterBT.UseVisualStyleBackColor = true;
            this.gosterBT.Click += new System.EventHandler(this.gosterBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 304);
            this.Controls.Add(this.gosterBT);
            this.Controls.Add(this.plakaCB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox plakaCB;
        private System.Windows.Forms.Button gosterBT;
    }
}

