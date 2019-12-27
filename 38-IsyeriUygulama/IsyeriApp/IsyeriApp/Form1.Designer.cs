namespace IsyeriApp
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
            this.isyeriGosterBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isyeriGosterBT
            // 
            this.isyeriGosterBT.Location = new System.Drawing.Point(174, 133);
            this.isyeriGosterBT.Name = "isyeriGosterBT";
            this.isyeriGosterBT.Size = new System.Drawing.Size(159, 23);
            this.isyeriGosterBT.TabIndex = 0;
            this.isyeriGosterBT.Text = "İs Yeri Goster";
            this.isyeriGosterBT.UseVisualStyleBackColor = true;
            this.isyeriGosterBT.Click += new System.EventHandler(this.isyeriGosterBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 306);
            this.Controls.Add(this.isyeriGosterBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button isyeriGosterBT;
    }
}

