using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryMusteri
{
    public partial class ryMusteriGirisForm : Form
    {
        public ryMusteriAnaForm musteriAfrm;

        public ryMusteriYeniKullaniciForm yKullan;
        public ryMusteriGirisForm()
        {
            InitializeComponent();
            yKullan = new ryMusteriYeniKullaniciForm();
            

        }

        #region Tanımlamalar
        OleDbConnection musConn = new OleDbConnection
            ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=mert.accdb");
        OleDbDataAdapter musAdp;

        DataTable musTablo = new DataTable();
        string sorgu;

        int kayitSayisi = 0;
        int girisSayisi = 0;
        Random rSayi = new Random();
        int islemSonucu;
        string islemİsareti = "+-"; // karakter dizisi

        #endregion


        private void veriDoldur()
        {
            musTablo.Clear();
            sorgu = "SELECT kAd,kSifre,kYetki FROM KULLAN";
            musAdp = new OleDbDataAdapter(sorgu, musConn);
            musAdp.Fill(musTablo);
            kayitSayisi = musTablo.Rows.Count;

        }

        private void guvenlikKoduUret()
        {
            int sayi1 = rSayi.Next(30, 71);
            int sayi2 = rSayi.Next(1, 31);
            int islemTipi = rSayi.Next(0, 2);
            lblSayi1.Text = sayi1.ToString();
            lblSayi2.Text = sayi2.ToString();
            lblIslemTuru.Text = islemİsareti[islemTipi].ToString();

            if (lblIslemTuru.Text == "+")
                islemSonucu = sayi1 + sayi2;
            else
                islemSonucu = sayi1 - sayi2;
        }

        private void ryMusteriGirisForm_Load(object sender, EventArgs e)
        {
            veriDoldur(); // veri doldurduk datalar geldi
            tbAd.Clear();
            tbSifre.Clear();
            tbSonuc.Clear();
            tbAd.Select();
            if (kayitSayisi<=0) // kayıt yoksa
            {
                yKullan.ShowDialog();
                veriDoldur();
            }
            guvenlikKoduUret();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            girisSayisi++; //giris denemesi arttırma 
            if (girisSayisi < 3)
            {

            }
        }
    }
}
