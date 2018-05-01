using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    public class Insan
    {

        public string id;
        public string ad;
        public string soyad;
        public AkilliKart kart;
        public string eposta;
        public string password;
        public int mevcutKitapSayisi;

        public Insan(string id,string ad,string soyad,AkilliKart kart,string eposta, string password)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.kart = kart;
            this.eposta = eposta;
            this.password = password;
        }

        public int getMevcutKitapSayisi()
        {
            return mevcutKitapSayisi;
        }
        public void setMevcutKitapSayisi(int mevcutKitapSayisi)
        {
            this.mevcutKitapSayisi = mevcutKitapSayisi;
        }

        //public int süreKontrol();

        public void iadeEt()  //başarı durumuna göre int döndürülebilir? ( 1-başarılı 0-başarısız)
        {
            /*
            if (süreKontol()) // süre geçerli ise 1 değil ise 0 döndürür
            {
                kart.setBakiye(kart.getBakiye() - 1);
            }*/
        }

    }

}
