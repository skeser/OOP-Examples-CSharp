namespace CokluInterafce2
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
            this.showArabaOzellikBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showArabaOzellikBT
            // 
            this.showArabaOzellikBT.Location = new System.Drawing.Point(55, 107);
            this.showArabaOzellikBT.Name = "showArabaOzellikBT";
            this.showArabaOzellikBT.Size = new System.Drawing.Size(167, 23);
            this.showArabaOzellikBT.TabIndex = 0;
            this.showArabaOzellikBT.Text = "Araba Ozelliklerini Goster";
            this.showArabaOzellikBT.UseVisualStyleBackColor = true;
            this.showArabaOzellikBT.Click += new System.EventHandler(this.showArabaOzellikBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 239);
            this.Controls.Add(this.showArabaOzellikBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showArabaOzellikBT;
    }
}

