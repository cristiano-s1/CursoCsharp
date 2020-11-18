using System;

namespace LocacaoInterfaces.Entities
{
    class CarRental
    {
        //Propriedades
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        //Propriedade com vinculo
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }


        //Construtor padrão
        public CarRental()
        {

        }

        //Construtor com argumentos
        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
