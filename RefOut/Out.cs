using System;
using System.Collections.Generic;
using System.Text;

namespace RefAndOut
{
    class Out
    {
        static void OutOrnek(out int Deger)
        {
            Deger = 50;
        }
        static void Main(string[] args)
        {
            int x;
            OutOrnek(out x);
            Console.WriteLine(x);
        }
    }