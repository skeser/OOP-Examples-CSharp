namespace NoktaKenar
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
            this.kenarGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kenarGoster
            // 
            this.kenarGoster.Location = new System.Drawing.Point(141, 65);
            this.kenarGoster.Name = "kenarGoster";
            this.kenarGoster.Size = new System.Drawing.Size(183, 23);
            this.kenarGoster.TabIndex = 0;
            this.kenarGoster.Text = "Kenar Göster";
            this.kenarGoster.UseVisualStyleBackColor = true;
            this.kenarGoster.Click += new System.EventHandler(this.kenarGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 270);
            this.Controls.Add(this.kenarGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kenarGoster;
    }
}

