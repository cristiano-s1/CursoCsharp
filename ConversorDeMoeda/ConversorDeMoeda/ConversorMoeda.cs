
namespace ConversorDeMoeda
{
    class ConversorMoeda
    {
        public static double iof = 6.0;

        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total + total * iof / 100.0;
        }
    }
}
