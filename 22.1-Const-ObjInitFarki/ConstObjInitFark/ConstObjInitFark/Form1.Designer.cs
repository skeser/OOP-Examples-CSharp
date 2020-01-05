namespace ConstObjInitFark
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
            this.FarkGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FarkGoster
            // 
            this.FarkGoster.Location = new System.Drawing.Point(156, 100);
            this.FarkGoster.Name = "FarkGoster";
            this.FarkGoster.Size = new System.Drawing.Size(185, 23);
            this.FarkGoster.TabIndex = 0;
            this.FarkGoster.Text = "Fark Goster";
            this.FarkGoster.UseVisualStyleBackColor = true;
            this.FarkGoster.Click += new System.EventHandler(this.FarkGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 271);
            this.Controls.Add(this.FarkGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FarkGoster;
    }
}

