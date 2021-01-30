using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            product pro1 = new product();
            pro1.ProductName = "Produckt name: monster";
            pro1.ProductModel = "Product Model: Huma H5 V2.1.1 15,6";
            pro1.ProductPrice = "Product price: 2000$";
            pro1.StockStatus = "Stock status: Avaılable";



            product pro2 = new product();
            pro2.ProductName = "Produckt name: monster";
            pro2.ProductModel = "Product Model: Abra A7 V11.3.2 17,3";
            pro2.ProductPrice = "Product price: 1850$";
            pro2.StockStatus = "Stock status: pre order";


            product pro3 = new product();
            pro3.ProductName = "Produckt name: monster";
            pro3.ProductModel = "Product Model: Semruk S7 V7.2.3 17,3";
            pro3.ProductPrice = "Product price: 12000$";
            pro3.StockStatus = "Stock status: out of stock";

            product[] products = new product[] { pro1, pro2, pro3, };


            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName);
                Console.WriteLine(products[i].ProductPrice);
                Console.WriteLine(products[i].ProductModel);
                Console.WriteLine(products[i].StockStatus);
                Console.WriteLine("******");

            }
            Console.WriteLine("****");
            Console.WriteLine("for bitti");


            foreach (var i in products)
            {
                Console.WriteLine(i.ProductName);
                Console.WriteLine(i.ProductPrice);
                Console.WriteLine(i.ProductModel);
                Console.WriteLine(i.StockStatus);
                Console.WriteLine("******");
            }

            Console.WriteLine("foreach döngüsü bitti");



            int sayac = 0;
            while (sayac < products.Length)
            {
                Console.WriteLine(products[sayac].ProductName);
                Console.WriteLine(products[sayac].ProductPrice);
                Console.WriteLine(products[sayac].ProductModel);
                Console.WriteLine(products[sayac].StockStatus);
                Console.WriteLine("******");
                sayac++;
            }

            Console.WriteLine("while döngüsü bitti");


        }
    }
    class product
    {
        public string ProductName { get; set; }
        public string ProductModel { get; set; }
        public string ProductPrice { get; set; }
        public string StockStatus { get; set; }



    }
}
