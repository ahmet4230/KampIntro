using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] kurslar = new string[] { "ygk", "pgk", "javak", "python" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("konsol bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");

            Console.ReadLine();



        }
    }
}
