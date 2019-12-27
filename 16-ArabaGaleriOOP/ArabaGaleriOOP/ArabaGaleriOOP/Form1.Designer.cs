namespace ArabaGaleriOOP
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
            this.programInfoLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.markaTB = new System.Windows.Forms.TextBox();
            this.modelTB = new System.Windows.Forms.TextBox();
            this.renkTB = new System.Windows.Forms.TextBox();
            this.arabaEkleBT = new System.Windows.Forms.Button();
            this.listViewLoadBT = new System.Windows.Forms.Button();
            this.arabaLV = new System.Windows.Forms.ListView();
            this.arabaLB = new System.Windows.Forms.ListBox();
            this.listBoxLoadBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // programInfoLB
            // 
            this.programInfoLB.AutoSize = true;
            this.programInfoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programInfoLB.Location = new System.Drawing.Point(102, 25);
            this.programInfoLB.Name = "programInfoLB";
            this.programInfoLB.Size = new System.Drawing.Size(387, 26);
            this.programInfoLB.TabIndex = 0;
            this.programInfoLB.Text = "OOP ile Araba Galerisi Uygulaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varlıklar : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(536, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Araba ve Galeri birbirne bağımlı iki varlık .Galeri varlığı Araba varlıklarını iç" +
    "erir.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Renk";
            // 
            // markaTB
            // 
            this.markaTB.Location = new System.Drawing.Point(175, 130);
            this.markaTB.Name = "markaTB";
            this.markaTB.Size = new System.Drawing.Size(286, 20);
            this.markaTB.TabIndex = 6;
            // 
            // modelTB
            // 
            this.modelTB.Location = new System.Drawing.Point(175, 160);
            this.modelTB.Name = "modelTB";
            this.modelTB.Size = new System.Drawing.Size(286, 20);
            this.modelTB.TabIndex = 7;
            // 
            // renkTB
            // 
            this.renkTB.Location = new System.Drawing.Point(175, 186);
            this.renkTB.Name = "renkTB";
            this.renkTB.Size = new System.Drawing.Size(286, 20);
            this.renkTB.TabIndex = 8;
            // 
            // arabaEkleBT
            // 
            this.arabaEkleBT.Location = new System.Drawing.Point(175, 212);
            this.arabaEkleBT.Name = "arabaEkleBT";
            this.arabaEkleBT.Size = new System.Drawing.Size(286, 23);
            this.arabaEkleBT.TabIndex = 9;
            this.arabaEkleBT.Text = "Galeriye Araba Ekle";
            this.arabaEkleBT.UseVisualStyleBackColor = true;
            this.arabaEkleBT.Click += new System.EventHandler(this.arabaEkleBT_Click);
            // 
            // listViewLoadBT
            // 
            this.listViewLoadBT.Location = new System.Drawing.Point(240, 256);
            this.listViewLoadBT.Name = "listViewLoadBT";
            this.listViewLoadBT.Size = new System.Drawing.Size(221, 23);
            this.listViewLoadBT.TabIndex = 10;
            this.listViewLoadBT.Text = "Galerideki Arabaları Listele - ListView";
            this.listViewLoadBT.UseVisualStyleBackColor = true;
            this.listViewLoadBT.Click += new System.EventHandler(this.listViewLoadBT_Click);
            // 
            // arabaLV
            // 
            this.arabaLV.HideSelection = false;
            this.arabaLV.Location = new System.Drawing.Point(240, 285);
            this.arabaLV.Name = "arabaLV";
            this.arabaLV.Size = new System.Drawing.Size(221, 199);
            this.arabaLV.TabIndex = 11;
            this.arabaLV.UseCompatibleStateImageBehavior = false;
            // 
            // arabaLB
            // 
            this.arabaLB.FormattingEnabled = true;
            this.arabaLB.Location = new System.Drawing.Point(12, 285);
            this.arabaLB.Name = "arabaLB";
            this.arabaLB.Size = new System.Drawing.Size(221, 199);
            this.arabaLB.TabIndex = 12;
            this.arabaLB.SelectedIndexChanged += new System.EventHandler(this.arabaLB_SelectedIndexChanged);
            // 
            // listBoxLoadBT
            // 
            this.listBoxLoadBT.Location = new System.Drawing.Point(12, 256);
            this.listBoxLoadBT.Name = "listBoxLoadBT";
            this.listBoxLoadBT.Size = new System.Drawing.Size(221, 23);
            this.listBoxLoadBT.TabIndex = 13;
            this.listBoxLoadBT.Text = "Galerideki Arabaları Listele ListBox";
            this.listBoxLoadBT.UseVisualStyleBackColor = true;
            this.listBoxLoadBT.Click += new System.EventHandler(this.listBoxLoadBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 528);
            this.Controls.Add(this.listBoxLoadBT);
            this.Controls.Add(this.arabaLB);
            this.Controls.Add(this.arabaLV);
            this.Controls.Add(this.listViewLoadBT);
            this.Controls.Add(this.arabaEkleBT);
            this.Controls.Add(this.renkTB);
            this.Controls.Add(this.modelTB);
            this.Controls.Add(this.markaTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.programInfoLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programInfoLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox markaTB;
        private System.Windows.Forms.TextBox modelTB;
        private System.Windows.Forms.TextBox renkTB;
        private System.Windows.Forms.Button arabaEkleBT;
        private System.Windows.Forms.Button listViewLoadBT;
        private System.Windows.Forms.ListView arabaLV;
        private System.Windows.Forms.ListBox arabaLB;
        private System.Windows.Forms.Button listBoxLoadBT;
    }
}

