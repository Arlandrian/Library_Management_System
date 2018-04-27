using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class Memur : Insan
    {

        private int kitapSiniri;
        private int oduncSuresi;

        public Memur(string id, string ad, string soyad, AkilliKart kart, string eposta, int kitapSiniri, int oduncSuresi) : base(id, ad, soyad, kart, eposta)
        {
            this.kitapSiniri = kitapSiniri;
            this.oduncSuresi = oduncSuresi;
        }

    }
}
