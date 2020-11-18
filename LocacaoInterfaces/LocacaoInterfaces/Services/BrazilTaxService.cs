
namespace LocacaoInterfaces.Services
{
    class BrazilTaxService : ITaxService //Subtitulo da Interface
    {

        //Método
        public double Tax(double amount)
        {
            if (amount <= 200)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
