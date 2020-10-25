using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaDeFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionario " + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionarios(id, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Digite a identificação do funcionário que terá aumento de salário: ");
            int pesquisaid = int.Parse(Console.ReadLine());

            Funcionarios empresa = list.Find(x => x.Id == pesquisaid);

            if (empresa != null)
            {
                Console.Write("Insira a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empresa.IncrementaSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada: ");

            foreach (Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
