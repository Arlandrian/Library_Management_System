﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane_Yonetim
{
    public class Memur : Insan
    {

        public static int kitapSiniri=3;
        public static int oduncSuresi=6;
        

        public Memur(string id, string ad, string soyad, AkilliKart kart, string eposta,string password) : base(id, ad, soyad, kart, eposta,password)
        {
            
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
