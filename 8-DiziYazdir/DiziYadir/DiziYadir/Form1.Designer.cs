namespace DiziYadir
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
            this.diziGosterBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diziGosterBT
            // 
            this.diziGosterBT.Location = new System.Drawing.Point(156, 101);
            this.diziGosterBT.Name = "diziGosterBT";
            this.diziGosterBT.Size = new System.Drawing.Size(75, 23);
            this.diziGosterBT.TabIndex = 0;
            this.diziGosterBT.Text = "Dizi Goster";
            this.diziGosterBT.UseVisualStyleBackColor = true;
            this.diziGosterBT.Click += new System.EventHandler(this.diziGosterBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.diziGosterBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button diziGosterBT;
    }
}

