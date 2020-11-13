
namespace TaxMetodosAbstratos.Entities
{
    class Company : TaxPayer //Herdando classe TaxPayer
    {
        //Propriedades
        public int NumberOfEmploys { get; set; }

        //Construtor padrão
        public Company()
        {

        }

        //Construtor com argumentos
        public Company(string name, double annualIncome, int numberOfEmploys)
            : base(name, annualIncome)
        {
            NumberOfEmploys = numberOfEmploys;
        }

        //Método
        public override double Tax()
        {
            if (NumberOfEmploys > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
