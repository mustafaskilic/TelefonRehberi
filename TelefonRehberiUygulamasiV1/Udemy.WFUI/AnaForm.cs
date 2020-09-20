using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Entities;

namespace Udemy.WFUI
{
    public partial class AnaForm : Form
    {
        Udemy.BLL.BusinessLogicLayer BLL;
        public AnaForm()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.YeniKayit(Guid.NewGuid(), txtIsim.Text, txtSoyisim.Text, txtTelefonI.Text, txtTelefonII.Text, txtTelefonIII.Text, txtAdres.Text, txtEmailAdres.Text, txtWebSitesi.Text, txtAciklama.Text);

            if (sonuc > 0)
            {
                MessageBox.Show("Kaydınız eklendi");
                Doldur();
            }
            else if (sonuc == -100)
            {
                MessageBox.Show("Eksik parametre hatası.\nLütfen isim,soyisim,telefon1 alanlarını doldurunuz.");
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata oluştu.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        void Doldur()
        {
            List<RehberKayit> RehberKayitlarim = BLL.RehberKayitGetir();
            if (RehberKayitlarim != null && RehberKayitlarim.Count > 0)
            {
                lstListe.DataSource = RehberKayitlarim;
            }
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void lstListe_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox)sender;
            RehberKayit secilenDeger = (RehberKayit)L.SelectedItem;
            txtIsim.Text = secilenDeger.Isim;
            txtSoyisim.Text = secilenDeger.Soyisim;
            txtTelefonI.Text = secilenDeger.TelefonI;
            txtTelefonII.Text = secilenDeger.TelefonII;
            txtTelefonIII.Text = secilenDeger.TelefonIII;
            txtEmailAdres.Text = secilenDeger.EmailAdres;
            txtAdres.Text = secilenDeger.Adres;
            txtWebSitesi.Text = secilenDeger.Website;
            txtAciklama.Text = secilenDeger.Aciklama;
            grpboxKayit.Text = "Rehber Kayıt Güncelle";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem != null)
            {
                RehberKayit K = (RehberKayit)lstListe.SelectedItem;
                int sonuc = BLL.KayitGuncelle(K.ID, txtIsim.Text, txtSoyisim.Text, txtTelefonI.Text, txtTelefonII.Text, txtTelefonIII.Text, txtAdres.Text, txtEmailAdres.Text, txtWebSitesi.Text, txtAciklama.Text);
                if (sonuc > 0)
                {
                    MessageBox.Show("Kaydınız başarılı şekilde güncellendi");
                    Doldur();
                }
                else if (sonuc==-100)
                {
                    MessageBox.Show("Eksik parametre hatası");
                }
                else
                {
                    MessageBox.Show("Kayıt güncelleme işleminde Hata oluştu");
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kişiyi seçiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sonuc=BLL.KayitSil(((RehberKayit)lstListe.SelectedItem).ID);
            if (sonuc>0)
            {
                MessageBox.Show("Kaydınız silinmiştir.");
                Doldur();
            }
            else
            {
                MessageBox.Show("Kayıt silme işleminde Hata oluştu");
            }
        }

        private void btnXmlVer_Click(object sender, EventArgs e)
        {
            int sonuc=BLL.XmlDataVer();
            if (sonuc>0)
            {
                lblData_alver_durum.Text = "Durum Açıklaması: XML Data verme işlemi tamamlandı.";
            }
            else
            {
                lblData_alver_durum.Text = "Durum Açıklaması: XML Data verme işleminde hata oluştu.";
            }
        }

        private void btnCsvVer_Click(object sender, EventArgs e)
        {
            int sonuc = BLL.CsvDataVer();
            if (sonuc>0)
            {
                lblData_alver_durum.Text = "Durum Açıklaması: CSV Data verme işlemi tamamlandı.";
            }
            else
            {
                lblData_alver_durum.Text = "Durum Açıklaması: CSV Data verme işleminde hata oluştu.";
            }
        }

        private void btnJsonVer_Click(object sender, EventArgs e)
        {
            int Sonuc = BLL.JsonDataVer();
            if (Sonuc > 0)
            {
                lblData_alver_durum.Text = "Durum Açıklaması: Json Data verme işlemi tamamlandı.";
            }
            else
            {
                lblData_alver_durum.Text = "Durum Açıklaması: Json Data verme işleminde hata oluştu.";
            }
        }
    }
}
