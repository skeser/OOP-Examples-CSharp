namespace WindowsFormsApp1
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
            this.say1textBox = new System.Windows.Forms.TextBox();
            this.say2textBox = new System.Windows.Forms.TextBox();
            this.say1Label = new System.Windows.Forms.Label();
            this.say2Label = new System.Windows.Forms.Label();
            this.sonucViewLabel = new System.Windows.Forms.Label();
            this.sonucResultLabel = new System.Windows.Forms.Label();
            this.toplaButton = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // say1textBox
            // 
            this.say1textBox.Location = new System.Drawing.Point(150, 74);
            this.say1textBox.Name = "say1textBox";
            this.say1textBox.Size = new System.Drawing.Size(378, 20);
            this.say1textBox.TabIndex = 0;
            // 
            // say2textBox
            // 
            this.say2textBox.Location = new System.Drawing.Point(150, 124);
            this.say2textBox.Name = "say2textBox";
            this.say2textBox.Size = new System.Drawing.Size(378, 20);
            this.say2textBox.TabIndex = 1;
            // 
            // say1Label
            // 
            this.say1Label.AutoSize = true;
            this.say1Label.Location = new System.Drawing.Point(98, 81);
            this.say1Label.Name = "say1Label";
            this.say1Label.Size = new System.Drawing.Size(36, 13);
            this.say1Label.TabIndex = 2;
            this.say1Label.Text = "Sayı 1";
            // 
            // say2Label
            // 
            this.say2Label.AutoSize = true;
            this.say2Label.Location = new System.Drawing.Point(98, 124);
            this.say2Label.Name = "say2Label";
            this.say2Label.Size = new System.Drawing.Size(36, 13);
            this.say2Label.TabIndex = 3;
            this.say2Label.Text = "Sayi 2";
            // 
            // sonucViewLabel
            // 
            this.sonucViewLabel.AutoSize = true;
            this.sonucViewLabel.Location = new System.Drawing.Point(98, 163);
            this.sonucViewLabel.Name = "sonucViewLabel";
            this.sonucViewLabel.Size = new System.Drawing.Size(38, 13);
            this.sonucViewLabel.TabIndex = 4;
            this.sonucViewLabel.Text = "Sonuc";
            // 
            // sonucResultLabel
            // 
            this.sonucResultLabel.AutoSize = true;
            this.sonucResultLabel.Location = new System.Drawing.Point(147, 163);
            this.sonucResultLabel.Name = "sonucResultLabel";
            this.sonucResultLabel.Size = new System.Drawing.Size(102, 13);
            this.sonucResultLabel.TabIndex = 5;
            this.sonucResultLabel.Text = "sayıları gir btona bas";
            // 
            // toplaButton
            // 
            this.toplaButton.Location = new System.Drawing.Point(150, 189);
            this.toplaButton.Name = "toplaButton";
            this.toplaButton.Size = new System.Drawing.Size(232, 23);
            this.toplaButton.TabIndex = 6;
            this.toplaButton.Text = "TOPLA";
            this.toplaButton.UseVisualStyleBackColor = true;
            this.toplaButton.Click += new System.EventHandler(this.toplaButton_Click);
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(388, 189);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(140, 23);
            this.clearFormButton.TabIndex = 7;
            this.clearFormButton.Text = "Temizle";
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 314);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.toplaButton);
            this.Controls.Add(this.sonucResultLabel);
            this.Controls.Add(this.sonucViewLabel);
            this.Controls.Add(this.say2Label);
            this.Controls.Add(this.say1Label);
            this.Controls.Add(this.say2textBox);
            this.Controls.Add(this.say1textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox say1textBox;
        private System.Windows.Forms.TextBox say2textBox;
        private System.Windows.Forms.Label say1Label;
        private System.Windows.Forms.Label say2Label;
        private System.Windows.Forms.Label sonucViewLabel;
        private System.Windows.Forms.Label sonucResultLabel;
        private System.Windows.Forms.Button toplaButton;
        private System.Windows.Forms.Button clearFormButton;
    }
}

