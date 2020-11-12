using System;
using FigurasMetodosAbstratos.Entities.Enums;

namespace FigurasMetodosAbstratos.Entities
{
    class Circle : Shape
    {

        //Propriedades
        public double Radius { get; set; }


        //Construtor
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }


        //Sobrescrita do Método Abstrato que pertense ao Shape
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
