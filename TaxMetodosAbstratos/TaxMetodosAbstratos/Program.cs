using System;
using System.Collections.Generic;
using System.Globalization;
using TaxMetodosAbstratos.Entities;

namespace TaxMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarando uma lista
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmploys = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, annualIncome, numberOfEmploys));
                }           
            }

            double sum = 0.0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (TaxPayer taxpayer in list)
            {
                double tax = taxpayer.Tax();

                Console.WriteLine(taxpayer.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));

                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
