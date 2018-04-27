using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    public class Memur : Insan
    {

        private int kitapSiniri;
        private int oduncSuresi;

        public Memur(string id, string ad, string soyad, AkilliKart kart, string eposta,string password, int kitapSiniri, int oduncSuresi) : base(id, ad, soyad, kart, eposta,password)
        {
            this.kitapSiniri = kitapSiniri;
            this.oduncSuresi = oduncSuresi;
        }

    }
}
