namespace OverridePolymorphism2
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
            this.showOverrideBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showOverrideBT
            // 
            this.showOverrideBT.Location = new System.Drawing.Point(122, 111);
            this.showOverrideBT.Name = "showOverrideBT";
            this.showOverrideBT.Size = new System.Drawing.Size(75, 23);
            this.showOverrideBT.TabIndex = 0;
            this.showOverrideBT.Text = "Goster";
            this.showOverrideBT.UseVisualStyleBackColor = true;
            this.showOverrideBT.Click += new System.EventHandler(this.showOverrideBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 288);
            this.Controls.Add(this.showOverrideBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showOverrideBT;
    }
}

