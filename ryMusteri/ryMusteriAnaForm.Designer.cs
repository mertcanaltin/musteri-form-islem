namespace ryMusteri
{
    partial class ryMusteriAnaForm
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
            this.musteriAnaMenu = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.islemlerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunlerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yonetimMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKullaniciMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriAnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriAnaMenu
            // 
            this.musteriAnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.yonetimMenuItem,
            this.kapatMenuItem});
            this.musteriAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.musteriAnaMenu.Name = "musteriAnaMenu";
            this.musteriAnaMenu.Size = new System.Drawing.Size(446, 24);
            this.musteriAnaMenu.TabIndex = 0;
            this.musteriAnaMenu.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMenuItem,
            this.islemlerMenuItem,
            this.urunlerMenuItem,
            this.raporMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.işlemlerToolStripMenuItem.Text = "&Müşteri";
            // 
            // yeniMenuItem
            // 
            this.yeniMenuItem.Name = "yeniMenuItem";
            this.yeniMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniMenuItem.Text = "Yeni";
            this.yeniMenuItem.Click += new System.EventHandler(this.yeniMenuItem_Click);
            // 
            // islemlerMenuItem
            // 
            this.islemlerMenuItem.Name = "islemlerMenuItem";
            this.islemlerMenuItem.Size = new System.Drawing.Size(180, 22);
            this.islemlerMenuItem.Text = "İşlemler";
            this.islemlerMenuItem.Click += new System.EventHandler(this.islemlerMenuItem_Click);
            // 
            // urunlerMenuItem
            // 
            this.urunlerMenuItem.Name = "urunlerMenuItem";
            this.urunlerMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunlerMenuItem.Text = "Ürünler";
            this.urunlerMenuItem.Click += new System.EventHandler(this.urunlerMenuItem_Click);
            // 
            // raporMenuItem
            // 
            this.raporMenuItem.Name = "raporMenuItem";
            this.raporMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raporMenuItem.Text = "Rapor";
            this.raporMenuItem.Click += new System.EventHandler(this.raporMenuItem_Click);
            // 
            // yonetimMenuItem
            // 
            this.yonetimMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKullaniciMenuItem});
            this.yonetimMenuItem.Name = "yonetimMenuItem";
            this.yonetimMenuItem.Size = new System.Drawing.Size(63, 20);
            this.yonetimMenuItem.Text = "Yönetim";
            // 
            // yeniKullaniciMenuItem
            // 
            this.yeniKullaniciMenuItem.Name = "yeniKullaniciMenuItem";
            this.yeniKullaniciMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniKullaniciMenuItem.Text = "Yeni Kullanıcı";
            this.yeniKullaniciMenuItem.Click += new System.EventHandler(this.yeniKullaniciMenuItem_Click);
            // 
            // kapatMenuItem
            // 
            this.kapatMenuItem.Name = "kapatMenuItem";
            this.kapatMenuItem.Size = new System.Drawing.Size(44, 20);
            this.kapatMenuItem.Text = "Çıkış";
            this.kapatMenuItem.Click += new System.EventHandler(this.kapatMenuItem_Click);
            // 
            // ryMusteriAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 344);
            this.ControlBox = false;
            this.Controls.Add(this.musteriAnaMenu);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.musteriAnaMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ryMusteriAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ BİLGİ SİSTEMİ";
            this.Load += new System.EventHandler(this.ryMusteriAnaForm_Load);
            this.musteriAnaMenu.ResumeLayout(false);
            this.musteriAnaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip musteriAnaMenu;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMenuItem;
        private System.Windows.Forms.ToolStripMenuItem islemlerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yonetimMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKullaniciMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunlerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporMenuItem;
    }
}


