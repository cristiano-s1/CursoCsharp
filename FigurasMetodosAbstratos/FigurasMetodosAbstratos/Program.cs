using FigurasMetodosAbstratos.Entities;
using FigurasMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

namespace FigurasMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar uma list
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or Circle (r/c)?");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                //Enum
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Adicionar na lista do Rectangle
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Adicionar na lista do Circle
                    list.Add(new Circle(radius, color));
                }
            }


            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
