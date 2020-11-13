
namespace TaxMetodosAbstratos.Entities
{
    abstract class TaxPayer //Classe abstract
    {
        //Propriedades
        public string Name { get; set; }
        public double AnnualIncome { get; set; } //Rendimento Anul

        //Construtor padrão
        public TaxPayer()
        {

        }

        //Construtor com argumentos
        public TaxPayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        //Método abstract
        public abstract double Tax();
      
    }
}
