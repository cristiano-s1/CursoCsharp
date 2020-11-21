
namespace ContratoInterfaces.Services
{
    class PaypalService : IOnlinePaymentService
    {

        private const double FeePercentage = 0.02;
        private const double MothlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MothlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

    }
}
