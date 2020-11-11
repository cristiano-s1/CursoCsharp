using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProdutoPolimorfismo.Entities
{
    class UsedProduct : Product //Herdando a classe Product
    {
        //Propriedades
        public DateTime ManufactureDate { get; set; }


        //Construtor padrão
        public UsedProduct()
        {

        }


        //Construtor com argumentos
        //Product + UsedProduct
        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price) //Reaproveitando os argumentos da classe Product
        {
            ManufactureDate = manufactureDate;
        }


        //Método para PriceTang -> Retorna uma string
        public override string PriceTang()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }




    }
}
