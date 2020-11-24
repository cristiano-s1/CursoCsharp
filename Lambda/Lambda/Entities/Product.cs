
namespace Lambda.Entities
{
    class Product
    {
        //Propriedades
        public string Name { get; set; }
        public double Price { get; set; }


        //Construtor com argumentos
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
