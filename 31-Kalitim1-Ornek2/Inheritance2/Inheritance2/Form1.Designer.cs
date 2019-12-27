namespace Inheritance2
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
            this.showObjectsBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showObjectsBT
            // 
            this.showObjectsBT.Location = new System.Drawing.Point(89, 121);
            this.showObjectsBT.Name = "showObjectsBT";
            this.showObjectsBT.Size = new System.Drawing.Size(162, 23);
            this.showObjectsBT.TabIndex = 0;
            this.showObjectsBT.Text = "kalıtılmış nesneleri goster";
            this.showObjectsBT.UseVisualStyleBackColor = true;
            this.showObjectsBT.Click += new System.EventHandler(this.showObjectsBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 308);
            this.Controls.Add(this.showObjectsBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showObjectsBT;
    }
}

