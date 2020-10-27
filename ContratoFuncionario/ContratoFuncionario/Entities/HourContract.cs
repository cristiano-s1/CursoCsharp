using System;

namespace ContratoFuncionario.Entities
{
    class HourContract
    {
        //Propriedade
        public DateTime Date { get; set; } //Data do contrato 
        public double ValuePerHour { get; set; } //Valor por hora 
        public int Hours { get; set; } //Duração em horas do contrato

        //Construtor padrão
        public HourContract()
        {

        }

        //Construtor com argumentos
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Método
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

        



    }
}
