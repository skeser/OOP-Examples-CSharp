namespace Personel
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
            this.personelGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personelGoster
            // 
            this.personelGoster.Location = new System.Drawing.Point(159, 32);
            this.personelGoster.Name = "personelGoster";
            this.personelGoster.Size = new System.Drawing.Size(167, 23);
            this.personelGoster.TabIndex = 0;
            this.personelGoster.Text = "Personelleri Göster";
            this.personelGoster.UseVisualStyleBackColor = true;
            this.personelGoster.Click += new System.EventHandler(this.personelGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 338);
            this.Controls.Add(this.personelGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personelGoster;
    }
}

