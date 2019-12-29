namespace U13Abstract1
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
            this.gosterBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gosterBT
            // 
            this.gosterBT.Location = new System.Drawing.Point(119, 88);
            this.gosterBT.Name = "gosterBT";
            this.gosterBT.Size = new System.Drawing.Size(75, 23);
            this.gosterBT.TabIndex = 0;
            this.gosterBT.Text = "Goster";
            this.gosterBT.UseVisualStyleBackColor = true;
            this.gosterBT.Click += new System.EventHandler(this.gosterBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 219);
            this.Controls.Add(this.gosterBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gosterBT;
    }
}

