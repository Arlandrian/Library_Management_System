using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class OgretimUyesi : Insan
    {

        public static int kitapSiniri = 6;// default : 6 kitap
        public static int oduncSuresi = 90;// default : 90 gün 
        

        public OgretimUyesi(string id, string ad, string soyad, AkilliKart kart, string eposta, string password) : base(id, ad, soyad, kart, eposta, password)
        {
            
        }

        public void setKitapSiniri(int newSinir)
        {
            kitapSiniri = newSinir;
        }


        public void increaseMevcutKitapSayisi()
        {
            this.setMevcutKitapSayisi(this.getMevcutKitapSayisi() + 1);
        }

    }
}
