using System;
using System.Collections.Generic; //Importar list
using System.ComponentModel.Design;
using System.Globalization;
using SalarioFuncionarioPlimorfismo.Entities; //Importando Entities

namespace SalarioFuncionarioPlimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar uma lista
            List<Employee> list = new List<Employee>();


            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            //For para leitura dos dados de n funcionários
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Add na lista do OutsourcedEmployee 
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } 
                else
                {
                    //Add na lista do Employee
                    list.Add(new Employee(name, hours, valuePerHour));
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS:");

                //Percorrer a lista
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }

            }

            


        }
    }
}
