using System;

//Exceções personalizadas
namespace ReservaHotelExcecoesPersonalizada.Entities.Exceptions
{
    //DomainException é uma subclasse de ApplicationException
    class DomainException : ApplicationException //ApplicationException é do sistema 
    {
        //Construtor para repassar a mensagem ao ApplicationException
        public DomainException(string message) : base(message)
        {

        }
    }
}
