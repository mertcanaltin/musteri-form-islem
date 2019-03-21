namespace ryMusteri
{
    partial class ryMusteriGirisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(73, 20);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(128, 24);
            this.tbAd.TabIndex = 0;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(73, 57);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.PasswordChar = '*';
            this.tbSifre.Size = new System.Drawing.Size(128, 24);
            this.tbSifre.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::ryMusteri.Properties.Resources.kapat;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Location = new System.Drawing.Point(207, 18);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 28);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnGiris
            // 
            this.btnGiris.BackgroundImage = global::ryMusteri.Properties.Resources.onay;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Location = new System.Drawing.Point(207, 54);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(28, 28);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güvenlik Kodu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi1
            // 
            this.lblSayi1.BackColor = System.Drawing.SystemColors.Window;
            this.lblSayi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSayi1.Location = new System.Drawing.Point(12, 135);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(42, 24);
            this.lblSayi1.TabIndex = 3;
            this.lblSayi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIslemTuru.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemTuru.Location = new System.Drawing.Point(59, 136);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(30, 24);
            this.lblIslemTuru.TabIndex = 6;
            this.lblIslemTuru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSayi2
            // 
            this.lblSayi2.BackColor = System.Drawing.SystemColors.Window;
            this.lblSayi2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSayi2.Location = new System.Drawing.Point(95, 136);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(42, 24);
            this.lblSayi2.TabIndex = 9;
            this.lblSayi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(143, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(179, 136);
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(56, 24);
            this.tbSonuc.TabIndex = 2;
            this.tbSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ryMusteriGirisForm
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(245, 174);
            this.ControlBox = false;
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblIslemTuru);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ryMusteriGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - GİRİŞ";
            this.Load += new System.EventHandler(this.ryMusteriGirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSonuc;
    }
}