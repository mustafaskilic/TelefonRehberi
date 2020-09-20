using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Udemy.Entities;

namespace Udemy.BLL
{
    public class BusinessLogicLayer
    {
        Udemy.Core.DatabaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLayer();
        }
        public int KullaniciKontrol(string KullaniciAdi, string Sifre)
        {
            int Sonuc = 0;
            if (!string.IsNullOrWhiteSpace(KullaniciAdi) && !string.IsNullOrWhiteSpace(Sifre))
            {
                Kullanici kullanici = new Kullanici();
                kullanici.KullaniciAdi = KullaniciAdi;
                kullanici.Sifre = Sifre;
                Sonuc = DLL.KullaniciKontrol(kullanici);
            }
            else
            {
                Sonuc = -100;
            }
            return Sonuc;
        }

        public int YeniKayit(Guid ID, string Isim, string Soyisim, string TelefonI, string TelefonII, string TelefonIII, string Adres, string EmailAdres, string WebSite, string Aciklama)
        {
            int Sonuc = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(TelefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.TelefonI = TelefonI;
                Kayit.TelefonII = TelefonII;
                Kayit.TelefonIII = TelefonIII;
                Kayit.Adres = Adres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Website = WebSite;
                Kayit.Aciklama = Aciklama;

                Sonuc = DLL.YeniKayit(Kayit);
            }
            else
            {
                Sonuc = -100; //Parametre Hatası
            }
            return Sonuc;
        }

        public int KayitGuncelle(Guid ID, string Isim, string Soyisim, string TelefonI, string TelefonII, string TelefonIII, string Adres, string EmailAdres, string WebSite, string Aciklama)
        {
            int Sonuc = 0;

            if (ID != Guid.Empty && !string.IsNullOrWhiteSpace(Isim) && !string.IsNullOrWhiteSpace(Soyisim) && !string.IsNullOrWhiteSpace(TelefonI))
            {
                RehberKayit Kayit = new RehberKayit();
                Kayit.ID = ID;
                Kayit.Isim = Isim;
                Kayit.Soyisim = Soyisim;
                Kayit.TelefonI = TelefonI;
                Kayit.TelefonII = TelefonII;
                Kayit.TelefonIII = TelefonIII;
                Kayit.Adres = Adres;
                Kayit.EmailAdres = EmailAdres;
                Kayit.Website = WebSite;
                Kayit.Aciklama = Aciklama;

                Sonuc = DLL.KayitGuncelle(Kayit);
            }
            else
            {
                Sonuc = -100;
            }
            return Sonuc;

        }
        public int KayitSil(Guid ID)
        {
            return DLL.KayitSil(ID);
        }
        public List<RehberKayit> RehberKayitGetir()
        {
            return DLL.RehberKayitlariGetir();
        }

        public int XmlDataVer()
        {
            int Sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();

                XDocument Doc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("RehberKayitlar",
                Kayitlarim.Select(i =>
                new XElement("Kayit", new XElement("ID", i.ID),
                new XElement("Isim", i.Isim), new XElement("Soyisim", i.Soyisim),
                new XElement("TelefonI", i.TelefonI),
                new XElement("TelefonII", i.TelefonII),
                new XElement("TelefonIII", i.TelefonIII),
                new XElement("EmailAdres", i.EmailAdres),
                new XElement("Adres", i.Adres),
                new XElement("WebSite", i.Website),
                new XElement("Aciklama", i.Aciklama)))));

                Doc.Save(@"c:\TelefonRehberiDB\DataVerXML.xml");
                Sonuc = 1;

            }
            catch (Exception)
            {

                Sonuc = 0;
            }
            return Sonuc;
        }

        public int CsvDataVer()
        {
            int Sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlarim = DLL.RehberKayitlariGetir();
                StreamWriter SW = new StreamWriter(@"c:\TelefonRehberiDB\DataVerCSV.csv");
                CsvConfiguration config = new CsvConfiguration(new CultureInfo("TR"));
                CsvHelper.CsvWriter Write = new CsvHelper.CsvWriter(SW,config);
                Write.WriteHeader(typeof(RehberKayit));
                
              Write.WriteRecords(Kayitlarim);
                
                SW.Close();
                Sonuc = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return Sonuc;
        }
        public int JsonDataVer()
        {
            int Sonuc = 0;
            try
            {
                List<RehberKayit> Kayitlar= DLL.RehberKayitlariGetir();
                string jsonText=Newtonsoft.Json.JsonConvert.SerializeObject(Kayitlar);
                File.WriteAllText(@"c:\TelefonRehberiDB\DataVerJSON.json", jsonText);
                Sonuc = 1;
            }
            catch (Exception)
            {

                throw;
            }
            return Sonuc;
        }
    }
}
