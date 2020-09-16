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

                string JsonKullaniciText= JsonConvert.SerializeObject(Demo);
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
            }
            catch (Exception)
            {
                Sonuc = 0;
                //Log
            }
            return Sonuc;
        }

        public List<RehberKayit> RehberKayitlariGetir()
        {
            if (File.Exists(@"c:\TelefonRehberiDB\kullanici.json"))
            {
              string JsonDBText=  File.ReadAllText(@"c:\TelefonRehberiDB\kullanici.json");
                kayitlarim = JsonConvert.DeserializeObject<List<RehberKayit>>(JsonDBText);
            }
            return kayitlarim;
        }

        #region Yardımcı Metotlar
        private void JsonDBGuncelle()
        {
            if (kayitlarim!=null && kayitlarim.Count>0)
            {
                string JsonDB = JsonConvert.SerializeObject(kayitlarim);
                File.WriteAllText(@"c:\TelefonRehberiDB\kullanici.json", JsonDB);
            }
        }
        #endregion
    }
}
