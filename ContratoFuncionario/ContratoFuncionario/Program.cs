using System;
using System.Globalization;
using ContratoFuncionario.Entities; //Importando Entities
using ContratoFuncionario.Entities.Enums; //Importando Enums

namespace ContratoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            //Converter de string para enumeração
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); //string que o usuario digitar converter para WorkerLevel

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Instanciar os objetos
            //Objeto Departamento
            Department dept = new Department(deptName);
            //Objeto Trabalhador
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            //Executar n vezes
            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //Instanciar o contrato
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //Add o contrato ao Trabalhador
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            //Criar uma variavel string para ler o mês e ano no formato MM/YYYY
            string monthAndYear = Console.ReadLine();

            //Substring - Recortar 
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.Write("Name: " + worker.Name);
            Console.Write("Department: " + worker.Department.Name);
            Console.Write("Income for: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
