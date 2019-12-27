namespace OverridePolymorphism1
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
            this.showOverridedBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showOverridedBT
            // 
            this.showOverridedBT.Location = new System.Drawing.Point(129, 101);
            this.showOverridedBT.Name = "showOverridedBT";
            this.showOverridedBT.Size = new System.Drawing.Size(75, 23);
            this.showOverridedBT.TabIndex = 0;
            this.showOverridedBT.Text = "Goster";
            this.showOverridedBT.UseVisualStyleBackColor = true;
            this.showOverridedBT.Click += new System.EventHandler(this.showOverridedBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 239);
            this.Controls.Add(this.showOverridedBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showOverridedBT;
    }
}

