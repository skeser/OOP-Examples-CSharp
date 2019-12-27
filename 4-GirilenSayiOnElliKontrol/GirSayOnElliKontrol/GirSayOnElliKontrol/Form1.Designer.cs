namespace GirSayOnElliKontrol
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
            this.sayiLabel = new System.Windows.Forms.Label();
            this.girilenSayiTextBox = new System.Windows.Forms.TextBox();
            this.kontrolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sayiLabel
            // 
            this.sayiLabel.AutoSize = true;
            this.sayiLabel.Location = new System.Drawing.Point(30, 61);
            this.sayiLabel.Name = "sayiLabel";
            this.sayiLabel.Size = new System.Drawing.Size(58, 13);
            this.sayiLabel.TabIndex = 0;
            this.sayiLabel.Text = "Bir Sayı Gir";
            // 
            // girilenSayiTextBox
            // 
            this.girilenSayiTextBox.Location = new System.Drawing.Point(99, 58);
            this.girilenSayiTextBox.Name = "girilenSayiTextBox";
            this.girilenSayiTextBox.Size = new System.Drawing.Size(100, 20);
            this.girilenSayiTextBox.TabIndex = 1;
            // 
            // kontrolButton
            // 
            this.kontrolButton.Location = new System.Drawing.Point(99, 105);
            this.kontrolButton.Name = "kontrolButton";
            this.kontrolButton.Size = new System.Drawing.Size(100, 23);
            this.kontrolButton.TabIndex = 2;
            this.kontrolButton.Text = "KONTROL ET";
            this.kontrolButton.UseVisualStyleBackColor = true;
            this.kontrolButton.Click += new System.EventHandler(this.kontrolButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 212);
            this.Controls.Add(this.kontrolButton);
            this.Controls.Add(this.girilenSayiTextBox);
            this.Controls.Add(this.sayiLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayiLabel;
        private System.Windows.Forms.TextBox girilenSayiTextBox;
        private System.Windows.Forms.Button kontrolButton;
    }
}

