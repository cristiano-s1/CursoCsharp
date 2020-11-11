
using System.Globalization;

namespace ProdutoPolimorfismo.Entities
{

    class ImportedProduct : Product //Herdando a classe Product
    {
        //Propriedades
        public double CustomFree { get; set; }


        //Construtor padrão
        public ImportedProduct()
        {

        }


        //Construtor com argumentos
        //Product + ImportedProduct
        public ImportedProduct(string name, double price, double customFree)
            :base(name, price) //Reaproveitando os argumentos da classe Product
        {
            CustomFree = customFree;
        }


        //Metodo para soma total
        public double TotalPrice()
        {
            return Price + CustomFree;
        }


        //Método para PriceTang -> Retorna uma string
        public override string PriceTang()
        {
            return Name
                 + " $ "
                 + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                 + " (Customs fee: $ "
                 + CustomFree.ToString("F2", CultureInfo.InvariantCulture)
                 + ")";
        }
    }


}
