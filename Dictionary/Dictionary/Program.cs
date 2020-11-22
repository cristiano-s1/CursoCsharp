using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando 
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            //Definindo chave e valor
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";
            //Vai sobrescrever o valor phone acima, não é permitido repetições na mesma chave
            cookies["phone"] = "99771133";
            Console.WriteLine(cookies["email"]);

            //Remover a chave
            cookies.Remove("email");
            Console.WriteLine("Phone number: " + cookies["phone"]);

            //Tratando exceção
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }

            //Verificar o tamanho das chaves
            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES:");

            //Percorrer o Dictionary
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
