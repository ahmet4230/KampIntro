using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product x)
        {
            Console.WriteLine("TEBRİKLER. SEPETE EKLENDİ: " + x.Adi);
            //
            // örnek kod
            //
        }

        public void Ekle2(string Productname, string Productfiyat, string aciklama, string Id)
        {
            Console.WriteLine("TEBRİKLER. SEPETE EKLENDİ: " + Productname);
        }
    }
}
