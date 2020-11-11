
using System.Globalization;

namespace ProdutoPolimorfismo.Entities
{
    class Product
    {
        //Propriedades
        public string Name { get; set; }
        public double Price { get; set; }


        //Construtor padrão
        public Product()
        {

        }


        //Construtor com argumentos
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        //Método para PriceTang -> Retorna uma string
        //Virtual libera para sobrescrever em outra classe
        public virtual string PriceTang()
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
