using System.Globalization;

namespace LocacaoInterfaces.Entities
{
    class Invoice
    {
        //Propriedades
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        //Construtor padrão
        public Invoice()
        {

        }

        //Construtor com argumentos
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        //Propriedade calculada
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        //ToString
        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
