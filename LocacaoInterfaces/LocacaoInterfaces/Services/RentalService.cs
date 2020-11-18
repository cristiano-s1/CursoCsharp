using System;
using LocacaoInterfaces.Entities;

namespace LocacaoInterfaces.Services
{
    class RentalService
    {
        //Propriedades
        //private restrição de acesso, só pode obitelos não poderá modeficar os valores
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Construtor padrão
        public RentalService()
        {

        }


        //Interface
        //ITaxService _TaxService -> Serviço de imposto qualquer seja Brazil ou outro Pais.
        private ITaxService _taxService;


        //Contrutor com argumentos
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        //Método
        public void ProcessInvoice(CarRental carRental)
        {
            //Contagem de dias
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            //Calcular o valor do pagamento basico
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0) //Durãção for menor que 12 horas
            {
                //Math.Ceiling -> Aredonda para cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //Calculando o imposto em cima do basicPayment
            double tax = _taxService.Tax(basicPayment);

            //Instanciando a classe invoice
            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
