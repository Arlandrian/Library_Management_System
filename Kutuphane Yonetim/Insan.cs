using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class Insan
    {

        private string id;
        private string ad;
        private string soyad;
        private AkilliKart kart;
        private string eposta;

        public Insan(string id,string ad,string soyad,AkilliKart kart,string eposta)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.kart = kart;
            this.eposta = eposta;
        }

    }
}
