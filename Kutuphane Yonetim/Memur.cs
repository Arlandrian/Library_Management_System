using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    public class Memur : Insan
    {

        private static int kitapSiniri=3;
        private static int oduncSuresi=6;
        

        public Memur(string id, string ad, string soyad, AkilliKart kart, string eposta,string password, int kitapSiniri, int oduncSuresi) : base(id, ad, soyad, kart, eposta,password)
        {
            
            //this.kitapSiniri = kitapSiniri;
            //this.oduncSuresi = oduncSuresi;
        }

        public void setKitapSiniri(int newSinir) {
            kitapSiniri = newSinir;
        }


        public void increaseMevcutKitapSayisi()
        {
            this.setMevcutKitapSayisi(this.getMevcutKitapSayisi() + 1);
        }



    }
}
