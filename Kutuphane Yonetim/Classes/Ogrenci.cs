using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    public class Ogrenci : Insan
    {

        public static int kitapSiniri = 3;// default : 3 kitap
        public static int oduncSuresi = 30;// default : 30 gün 
        

        public Ogrenci(string id, string ad, string soyad, AkilliKart kart, string eposta, string password) : base(id, ad, soyad, kart, eposta,password)
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
