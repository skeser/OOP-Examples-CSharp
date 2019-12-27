namespace OverridePolymorphism3
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
            this.showOverridedObjectsBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showOverridedObjectsBT
            // 
            this.showOverridedObjectsBT.Location = new System.Drawing.Point(142, 110);
            this.showOverridedObjectsBT.Name = "showOverridedObjectsBT";
            this.showOverridedObjectsBT.Size = new System.Drawing.Size(75, 23);
            this.showOverridedObjectsBT.TabIndex = 0;
            this.showOverridedObjectsBT.Text = "Goster";
            this.showOverridedObjectsBT.UseVisualStyleBackColor = true;
            this.showOverridedObjectsBT.Click += new System.EventHandler(this.showOverridedObjectsBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.showOverridedObjectsBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showOverridedObjectsBT;
    }
}

