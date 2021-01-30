using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product();
            pro1.Id = 1;
            pro1.ProductName = "Masa";
            pro1.UnitPrice = 500;
            pro1.UnitİnStocks = 3;

            Product pro2 = new Product { Id = 2, CategoryId = 5, UnitİnStocks = 5, ProductName = "kalem", UnitPrice = 35 }; // farlı yazım şekilleri.

            // PASCAL CASE    //CAMEL CASE   YAZIM TÜRÜ.
            ProductManager productManager = new ProductManager();
            productManager.Add(pro1);
            Console.WriteLine(pro1.ProductName);
            productManager.Update(pro2);




        }
    }
}
