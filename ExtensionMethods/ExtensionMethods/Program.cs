using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando 
            DateTime dt = new DateTime(2020, 11, 22, 8, 10, 45);

            //Imprimindo a função ElapsedTime()
            Console.WriteLine(dt.ElapsedTime());

            //StringExtensions
            string s1 = "Good morning dear students!";

            //Cortar 10 letras da string
            Console.WriteLine(s1.Cut(10));

        }
    }
}
