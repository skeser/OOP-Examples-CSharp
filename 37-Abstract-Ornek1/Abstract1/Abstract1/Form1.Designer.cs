namespace Abstract1
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
            this.showAbstractBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showAbstractBT
            // 
            this.showAbstractBT.Location = new System.Drawing.Point(106, 119);
            this.showAbstractBT.Name = "showAbstractBT";
            this.showAbstractBT.Size = new System.Drawing.Size(169, 23);
            this.showAbstractBT.TabIndex = 0;
            this.showAbstractBT.Text = "Abstract Göster";
            this.showAbstractBT.UseVisualStyleBackColor = true;
            this.showAbstractBT.Click += new System.EventHandler(this.showAbstractBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.showAbstractBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showAbstractBT;
    }
}

