using System.Globalization;

namespace LinqComLambda.Entities
{
    class Product
    {
        //Propriedades
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //Propriedades da classe Category
        public Category Category { get; set; }

        //ToString
        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
        }
    }
}
