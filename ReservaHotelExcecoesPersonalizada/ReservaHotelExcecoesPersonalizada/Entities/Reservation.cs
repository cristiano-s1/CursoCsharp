using System;
using ReservaHotelExcecoesPersonalizada.Entities.Exceptions;

namespace ReservaHotelExcecoesPersonalizada.Entities
{
    class Reservation
    {

        //Propriedades
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        //Construtor padrão
        public Reservation()
        {
        }

        //Construtor com argumentos
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {

            if (checkOut <= checkIn)
            {
                //Lançar uma exceção utilizamos 'throw'
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        //Método duração da reserva em dias
        public double Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        //Método para atualizar a reservar
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            //Lógica para exceção
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                //Lançar uma exceção
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
                //Lançar uma exceção
                throw new DomainException("Check-out date must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        //ToString
        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
