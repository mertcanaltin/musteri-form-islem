namespace ryMusteri
{
    partial class ryMusteriYeniKullaniciForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.dgvKullanListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::ryMusteri.Properties.Resources.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(188, 92);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(28, 28);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.BackgroundImage = global::ryMusteri.Properties.Resources.anaform;
            this.btnAnaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaForm.Location = new System.Drawing.Point(188, 21);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(28, 28);
            this.btnAnaForm.TabIndex = 5;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(73, 58);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(100, 24);
            this.tbSifre.TabIndex = 1;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(73, 21);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(100, 24);
            this.tbAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yetki :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbYetki
            // 
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Items.AddRange(new object[] {
            "Yönetici",
            "Kullanıcı"});
            this.cmbYetki.Location = new System.Drawing.Point(73, 94);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(100, 24);
            this.cmbYetki.TabIndex = 2;
            // 
            // dgvKullanListe
            // 
            this.dgvKullanListe.ColumnHeadersHeight = 25;
            this.dgvKullanListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKullanListe.Location = new System.Drawing.Point(222, 12);
            this.dgvKullanListe.Name = "dgvKullanListe";
            this.dgvKullanListe.RowHeadersWidth = 20;
            this.dgvKullanListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvKullanListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKullanListe.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvKullanListe.RowTemplate.Height = 25;
            this.dgvKullanListe.Size = new System.Drawing.Size(344, 125);
            this.dgvKullanListe.TabIndex = 4;
            // 
            // ryMusteriYeniKullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 149);
            this.ControlBox = false;
            this.Controls.Add(this.dgvKullanListe);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAnaForm);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ryMusteriYeniKullaniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - YENİ KULLANICI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYetki;
        private System.Windows.Forms.DataGridView dgvKullanListe;
    }
}