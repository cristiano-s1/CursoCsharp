using System;
using System.Globalization;

namespace CadastroContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char pergunta = char.Parse(Console.ReadLine());

            if (pergunta == 's' || pergunta == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Dados da conta:");
                conta = new ContaBancaria(numero, titular);
                Console.WriteLine(conta);
            }

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine("Taxa para saque: - R$ 5.00");
        }
    }
}
