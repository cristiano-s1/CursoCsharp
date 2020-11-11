using System;
using System.Collections.Generic;
using System.Globalization;
using ProdutoPolimorfismo.Entities;

namespace ProdutoPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar uma lista
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            //Percorrer minha lista
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               
                if (ch == 'c')
                {
                    //Add na lista do Product
                    products.Add(new Product(name, price));
                }               
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    //Add na lista do UsedProduct
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Add na lista do ImportedProduct
                    products.Add(new ImportedProduct(name, price, customsFree));
                }

                Console.WriteLine();
                Console.WriteLine("PRICE TAGS: ");

                foreach (Product prod in products)
                {
                    Console.WriteLine(prod.PriceTang());
                }

               
            }
        }
    }
}
