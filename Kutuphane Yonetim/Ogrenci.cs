using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class Ogrenci : Insan
    {

        private static int kitapSiniri = 3;// default : 3 kitap
        private static int oduncSuresi = 30;// default : 30 gün 

        public Ogrenci(string id, string ad, string soyad, AkilliKart kart, string eposta) : base(id, ad, soyad, kart, eposta)
        {        

        }

    }
}
