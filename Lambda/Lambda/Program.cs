using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Lambda.Entities;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();


            //Lista de produtos
            List<Product> list = new List<Product>();


            //Bloco using para ler o arquivo txt
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }


            //Encontrar Média
            //DefaultIfEmpty(0.0) -> Se a lista for vazia mostra valor 0.0
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));


            //Filtrar e Order a lista em ordem decrescente
            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            
            //Percorer a lista de nomes
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
