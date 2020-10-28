namespace Pedido.Entities
{
    class Product
    {
        //Propriedades
        public string Name { get; set; }
        public double Preco { get; set; }


        //Construtor padrão
        public Product()
        {

        }


        //Contrutor com argumentos
        public Product(string name, double preco)
        {
            Name = name;
            Preco = preco;
        }
    }
}
