﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " Sepetinize Eklendi");
        }

        public void yeniEkle(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine(urunAdi + " Sepetinize Eklendi");
        }
    }
}
