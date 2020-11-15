using System;
using ReservaHotelExcecoesPersonalizada.Entities;
using ReservaHotelExcecoesPersonalizada.Entities.Exceptions;

namespace ReservaHotelExcecoesPersonalizada
{
    class Program
    {
        static void Main(string[] args)
        {

            //O código tem que estar dentro do bloco 'try'
            try
            {
                //Dados iniciais
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                //Instanciar a Reserva
                Reservation reservation = new Reservation(number, checkIn, checkOut);

                //Mostra a reserva
                Console.WriteLine("Reservation: " + reservation);

                //Dados para atualização da reserva
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                //Atualiza a reserva
                reservation.UpdateDates(checkIn, checkOut);

                //Mostra a reserva atualizada
                Console.WriteLine("Reservation: " + reservation);
            }

            //Tratamento de erros 
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            //catch generico, pega qualquer outro erro de exceção
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
