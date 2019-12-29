namespace Interface1
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
            this.interfaceGosterBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // interfaceGosterBT
            // 
            this.interfaceGosterBT.Location = new System.Drawing.Point(114, 105);
            this.interfaceGosterBT.Name = "interfaceGosterBT";
            this.interfaceGosterBT.Size = new System.Drawing.Size(140, 23);
            this.interfaceGosterBT.TabIndex = 0;
            this.interfaceGosterBT.Text = "Interface Goster";
            this.interfaceGosterBT.UseVisualStyleBackColor = true;
            this.interfaceGosterBT.Click += new System.EventHandler(this.interfaceGosterBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 253);
            this.Controls.Add(this.interfaceGosterBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button interfaceGosterBT;
    }
}

