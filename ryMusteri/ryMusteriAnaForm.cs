using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryMusteri
{
    public partial class ryMusteriAnaForm : Form
    {
        public ryMusteriGirisForm giris;
        public ryMusteriEkleForm yeniMüsteri;
        public ryMusteriIslemForm islemler;
        public ryMusteriUrunTanimiForm urunler;
        public ryMusteriYeniKullaniciForm yeniKullanici;
        public ryMusteriRaporForm rapor;
        public ryMusteriAnaForm()
        {
            InitializeComponent();
            baslat();
        }
        #region Tanımlamalar
       public bool durum = false;
        public bool yonetici = false;

        #endregion
        private void baslat()
        {
            giris = new ryMusteriGirisForm();
            yeniMüsteri = new ryMusteriEkleForm();
            islemler = new ryMusteriIslemForm();
            urunler = new ryMusteriUrunTanimiForm();
            yeniKullanici = new ryMusteriYeniKullaniciForm();
            rapor = new ryMusteriRaporForm();



            giris.musteriAfrm = this;
            yeniMüsteri.musteriAfrm = this;
            islemler.musteriAfrm = this;
            urunler.musteriAfrm = this;
            yeniKullanici.musteriAfrm = this;
            rapor.musteriAfrm = this;

            yonetimMenuItem.Visible = false; // herkese görünmez

           



        }
        private void ryMusteriAnaForm_Load(object sender, EventArgs e)
        {
            giris.ShowDialog(); // girişi çağırdım
            if (durum == false)
            {
                ryMusteriAnaForm_Load(sender, e);
                if (yonetici)
                {
                    yonetimMenuItem.Visible = true; //yöneticiye görünür 

                }
            }

        }

        private void yeniMenuItem_Click(object sender, EventArgs e)
        {
            yeniMüsteri.ShowDialog();
        }

        private void islemlerMenuItem_Click(object sender, EventArgs e)
        {
            islemler.ShowDialog();
        }

        private void urunlerMenuItem_Click(object sender, EventArgs e)
        {
            urunler.ShowDialog();
        }

        private void raporMenuItem_Click(object sender, EventArgs e)
        {
            rapor.ShowDialog();
        }

        private void yeniKullaniciMenuItem_Click(object sender, EventArgs e)
        {
            yeniKullanici.ShowDialog();
        }

        private void kapatMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstiyormusunuz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) Application.Exit();
           
        }
    }
}
