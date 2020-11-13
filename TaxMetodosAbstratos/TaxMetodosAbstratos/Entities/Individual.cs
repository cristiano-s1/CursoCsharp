
namespace TaxMetodosAbstratos.Entities
{
    class Individual : TaxPayer //Herdando classe TaxPayer
    {
        //Propriedades
        public double HealthExpenditures { get; set; } //Despesas com saude

        //Construtor padrão
        public Individual()
        {

        }

        //Construtor com argumentos
        public Individual(string name, double annualIncome, double healthExpenditures)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        //Método
        public override double Tax()
        {
            if (AnnualIncome < 20000.0)
            {
                return AnnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
