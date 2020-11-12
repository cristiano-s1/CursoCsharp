using FigurasMetodosAbstratos.Entities.Enums;

namespace FigurasMetodosAbstratos.Entities
{
    class Rectangle : Shape
    {

        //Propriedades
        public double Width { get; set; }
        public double Height { get; set; }


        //Construtor com argumentos
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }


        //Sobrescrita do Método Abstrato que pertense ao Shape
        public override double Area()
        {
            return Width * Height;
        }

    }
}
