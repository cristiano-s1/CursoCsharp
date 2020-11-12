using FigurasMetodosAbstratos.Entities.Enums;

namespace FigurasMetodosAbstratos.Entities
{
    abstract class Shape
    {
        //Propriedade Enum
        public Color Color { get; set; }


        //Construtor de argumentos
        public Shape(Color color)
        {
            Color = color;
        }


        //Método Abstrato
        public abstract double Area();

    }
}
