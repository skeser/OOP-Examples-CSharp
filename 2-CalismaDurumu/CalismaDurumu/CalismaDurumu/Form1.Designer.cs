namespace CalismaDurumu
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
            this.adLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.calisiyorRadioButton = new System.Windows.Forms.RadioButton();
            this.calismiyorRadioButton = new System.Windows.Forms.RadioButton();
            this.aylikGelirLabel = new System.Windows.Forms.Label();
            this.aylikGelirTextBox = new System.Windows.Forms.TextBox();
            this.gosterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(52, 37);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(20, 13);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Ad";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(52, 71);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(37, 13);
            this.soyadLabel.TabIndex = 1;
            this.soyadLabel.Text = "Soyad";
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(119, 30);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(175, 20);
            this.adTextBox.TabIndex = 2;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(119, 64);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(175, 20);
            this.soyadTextBox.TabIndex = 3;
            // 
            // calisiyorRadioButton
            // 
            this.calisiyorRadioButton.AutoSize = true;
            this.calisiyorRadioButton.Location = new System.Drawing.Point(119, 104);
            this.calisiyorRadioButton.Name = "calisiyorRadioButton";
            this.calisiyorRadioButton.Size = new System.Drawing.Size(63, 17);
            this.calisiyorRadioButton.TabIndex = 4;
            this.calisiyorRadioButton.TabStop = true;
            this.calisiyorRadioButton.Text = "Çalışıyor";
            this.calisiyorRadioButton.UseVisualStyleBackColor = true;
            this.calisiyorRadioButton.CheckedChanged += new System.EventHandler(this.calisiyorRadioButton_CheckedChanged);
            // 
            // calismiyorRadioButton
            // 
            this.calismiyorRadioButton.AutoSize = true;
            this.calismiyorRadioButton.Location = new System.Drawing.Point(223, 104);
            this.calismiyorRadioButton.Name = "calismiyorRadioButton";
            this.calismiyorRadioButton.Size = new System.Drawing.Size(71, 17);
            this.calismiyorRadioButton.TabIndex = 5;
            this.calismiyorRadioButton.TabStop = true;
            this.calismiyorRadioButton.Text = "Çalışmıyor";
            this.calismiyorRadioButton.UseVisualStyleBackColor = true;
            this.calismiyorRadioButton.CheckedChanged += new System.EventHandler(this.calismiyorRadioButton_CheckedChanged);
            // 
            // aylikGelirLabel
            // 
            this.aylikGelirLabel.AutoSize = true;
            this.aylikGelirLabel.Location = new System.Drawing.Point(52, 155);
            this.aylikGelirLabel.Name = "aylikGelirLabel";
            this.aylikGelirLabel.Size = new System.Drawing.Size(53, 13);
            this.aylikGelirLabel.TabIndex = 6;
            this.aylikGelirLabel.Text = "Aylık Gelir";
            // 
            // aylikGelirTextBox
            // 
            this.aylikGelirTextBox.Location = new System.Drawing.Point(119, 148);
            this.aylikGelirTextBox.Name = "aylikGelirTextBox";
            this.aylikGelirTextBox.Size = new System.Drawing.Size(175, 20);
            this.aylikGelirTextBox.TabIndex = 7;
            // 
            // gosterButton
            // 
            this.gosterButton.Location = new System.Drawing.Point(119, 186);
            this.gosterButton.Name = "gosterButton";
            this.gosterButton.Size = new System.Drawing.Size(175, 23);
            this.gosterButton.TabIndex = 8;
            this.gosterButton.Text = "Göster";
            this.gosterButton.UseVisualStyleBackColor = true;
            this.gosterButton.Click += new System.EventHandler(this.gosterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 258);
            this.Controls.Add(this.gosterButton);
            this.Controls.Add(this.aylikGelirTextBox);
            this.Controls.Add(this.aylikGelirLabel);
            this.Controls.Add(this.calismiyorRadioButton);
            this.Controls.Add(this.calisiyorRadioButton);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.adLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.RadioButton calisiyorRadioButton;
        private System.Windows.Forms.RadioButton calismiyorRadioButton;
        private System.Windows.Forms.Label aylikGelirLabel;
        private System.Windows.Forms.TextBox aylikGelirTextBox;
        private System.Windows.Forms.Button gosterButton;
    }
}

