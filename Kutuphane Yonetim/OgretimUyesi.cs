using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class OgretimUyesi : Insan
    {

        private static int kitapSiniri = 6;// default : 6 kitap
        private static int oduncSuresi = 90;// default : 90 gün 

        public OgretimUyesi(string id, string ad, string soyad, AkilliKart kart, string eposta) : base(id, ad, soyad, kart, eposta)
        {

        }

    }
}
