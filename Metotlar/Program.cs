using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("**************");
            }

            Console.WriteLine("----------METOTLAR-------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("ahmet", "elma", "asdasd", "44"); // bu kullanım önerilmez
            sepetManager.Ekle2("gg", "gg", "ff", "44");



        }
    }
}


// tekrar tekrar kullanımını sağlayan durumlar.
// dont repat your self.
