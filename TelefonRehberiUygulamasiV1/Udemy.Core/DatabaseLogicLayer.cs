using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Udemy.Entities;
using Newtonsoft.Json;

namespace Udemy.Core
{
    public class DatabaseLogicLayer
    {
        List<RehberKayit> kayitlarim;
        public DatabaseLogicLayer()
        {

            kayitlarim = new List<RehberKayit>();
            VeriTabaniKontrol();
        }

        private void VeriTabaniKontrol()
        {
            bool KlasorKontrol = Directory.Exists(@"c:\TelefonRehberiDB\");
            if (!KlasorKontrol)
            {
                Directory.CreateDirectory(@"c:\TelefonRehberiDB\");
                Kullanici Demo = new Kullanici();
                Demo.ID = Guid.NewGuid();
                Demo.KullaniciAdi = "Demo";
                Demo.Sifre = "Demo";

                string JsonKullaniciText = JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"c:\TelefonRehberiDB\kullanici.json", JsonKullaniciText);
            }
        }

        public int YeniKayit(RehberKayit K)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir(); //Class seviyesinde oluşturmuş olduğum koleksiyonum içerisine datamı doldurdum(varsa) yoksa zaten bellekte hiçbir değeri yoktu o şekilde yeni değer eklenmek üzere bekliyor.
                kayitlarim.Add(K);
                JsonDBGuncelle();//var ise üzerine yazdı, yoksa yeni json oluşturdu.
                Sonuc = 1;
            }
            catch (Exception)
            {
                Sonuc = 0;
                //Log
            }
            return Sonuc;
        }

        public int KayitGuncelle(RehberKayit K)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                int Index = kayitlarim.FindIndex(i => i.ID == K.ID);
                if (Index > -1)
                {
                    kayitlarim[Index].Isim = K.Isim;
                    kayitlarim[Index].Soyisim = K.Soyisim;
                    kayitlarim[Index].TelefonI = K.TelefonI;
                    kayitlarim[Index].TelefonII = K.TelefonII;
                    kayitlarim[Index].TelefonIII = K.TelefonIII;
                    kayitlarim[Index].EmailAdres = K.EmailAdres;
                    kayitlarim[Index].Website = K.Website;
                    kayitlarim[Index].Adres = K.Adres;
                    kayitlarim[Index].Aciklama = K.Aciklama;
                }
                JsonDBGuncelle();
                Sonuc = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return Sonuc;
        }
        public int KayitSil(Guid ID)
        {
            int Sonuc = 0;
            try
            {
                RehberKayitlariGetir();
                RehberKayit silinecekDeger=kayitlarim.Find(i => i.ID == ID);
                if (silinecekDeger!=null)
                {
                    kayitlarim.Remove(silinecekDeger);
                }
                JsonDBGuncelle();
                Sonuc = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return Sonuc;
        }
        public List<RehberKayit> RehberKayitlariGetir()
        {
            if (File.Exists(@"c:\TelefonRehberiDB\Rehber.json"))
            {
                string JsonDBText = File.ReadAllText(@"c:\TelefonRehberiDB\Rehber.json");
                kayitlarim = JsonConvert.DeserializeObject<List<RehberKayit>>(JsonDBText);
            }
            return kayitlarim;
        }
        public int KullaniciKontrol(Kullanici kullanici)
        {
            int KullaniciSonuc = 0;
            if (File.Exists(@"c:\TelefonRehberiDB\kullanici.json"))
            {
                string JsonKullaniciText = File.ReadAllText(@"c:\TelefonRehberiDB\kullanici.json");

                List<Kullanici> kullanicilar = JsonConvert.DeserializeObject<List<Kullanici>>(JsonKullaniciText);
                KullaniciSonuc = kullanicilar.FindAll(i => i.KullaniciAdi == kullanici.KullaniciAdi && i.Sifre == kullanici.Sifre).Count();
            }
            return KullaniciSonuc;
        }
        #region Yardımcı Metotlar
        private void JsonDBGuncelle()
        {
            if (kayitlarim != null && kayitlarim.Count > 0)
            {
                string JsonDB = JsonConvert.SerializeObject(kayitlarim);
                File.WriteAllText(@"c:\TelefonRehberiDB\Rehber.json", JsonDB);
            }
        }
        #endregion
    }
}
