using System;
using System.Collections.Generic;
using System.IO;
using Conjunto.Entities;

namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciando o conjunto com HashSet
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                //Ler um arquivo
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        //Fazer a leitura, retortar com espaço em branco, guardar no ventor de string
                        string[] line = sr.ReadLine().Split(' ');

                        //Nome ventor 0
                        string name = line[0];

                        //Data ventor 1
                        DateTime instant = DateTime.Parse(line[1]);

                        //Instanciando LogRecord
                        set.Add(new LogRecord { Username = name, Instant = instant });
                        Console.WriteLine(line);
                    }

                    //Contar a quantidade de usuários
                    Console.WriteLine("Total users: " + set.Count);
                }
            }

            //Exceção erro
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
