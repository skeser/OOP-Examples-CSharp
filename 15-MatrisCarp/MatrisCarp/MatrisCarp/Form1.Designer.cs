namespace MatrisCarp
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
            this.matrisCarpBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matrisCarpBT
            // 
            this.matrisCarpBT.Location = new System.Drawing.Point(144, 82);
            this.matrisCarpBT.Name = "matrisCarpBT";
            this.matrisCarpBT.Size = new System.Drawing.Size(75, 23);
            this.matrisCarpBT.TabIndex = 0;
            this.matrisCarpBT.Text = "Matris Carp";
            this.matrisCarpBT.UseVisualStyleBackColor = true;
            this.matrisCarpBT.Click += new System.EventHandler(this.matrisCarpBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 188);
            this.Controls.Add(this.matrisCarpBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button matrisCarpBT;
    }
}

