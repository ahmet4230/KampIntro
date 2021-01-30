using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;

            double DolarDun = 7.35;
            double DolarBugun = 7.35;

            if (DolarDun > DolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (DolarDun < DolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }





            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
