﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    class DersKitabı : Kitap
    {
        public DersKitabı(string id, string ad, int anlikAdet, int toplamAdet, int rezerveAdet,string tip) : base(id, ad, anlikAdet, toplamAdet, rezerveAdet,tip)
        {

        }
    }
}
