using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    public class Urun
    {

        public string id;
        public string ad;
        public int anlikAdet;
        public int toplamAdet;
        public int rezerveAdet;
        public string tip;

        public Urun(string id, string ad, int anlikAdet, int toplamAdet, int rezerveAdet,string tip)
        {
            this.id = id;
            this.ad = ad;
            this.toplamAdet = toplamAdet;
            this.anlikAdet = anlikAdet;//BAŞLANGIÇTA toplamAdet'e eşitlenebilir
            this.rezerveAdet = rezerveAdet;//BAŞLANGIÇTA 0'a eşitlenebilir
            this.tip = tip;
        }
        

    }
}
