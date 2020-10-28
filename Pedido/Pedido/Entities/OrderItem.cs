using System.Globalization;//CultureInfo

namespace Pedido.Entities
{
    class OrderItem
    {
        //Propriedades
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }//Associando a classe Product, e que é do tipo Product


        //Construtor padrão
        public OrderItem()
        {

        }


        //Contrutor com argumentos
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }


        //Método subtotal com o return
        public double SubTotal()
        {
            return Price * Quantity;
        }


        //ToString
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
