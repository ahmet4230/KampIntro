using System;

namespace RefAndOut
{
    class Ref
    {
        static void RefOrnek(ref int Deger)
        {
            Deger = 40;
        }
        static void Main(string[] args)
        {
            int x = 18;
            RefOrnek(ref x);
            Console.WriteLine(x);
        }
    }