using System;

namespace Pedido.Entities
{
    class Client
    {
        //Propriedades
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }


        //Construtor padrão
        public Client()
        {

        }


        //Contrutor com argumentos
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }


        //ToString
        public override string ToString()
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
