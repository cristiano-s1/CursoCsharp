using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioFuncionarioPlimorfismo.Entities
{
    //O funcionario tercerizado tem o pagamento diferente do funcionario comum
    class OutsourcedEmployee : Employee //Herda a classe Employee
    {

        //Propriedades
        public double AdditionalCharge { get; set; }


        //Construtor padrão
        public OutsourcedEmployee()
        {

        }


        //Construtor com argumentos
        //Construtor com os argumentos das classes Employee e OutsourcedEmployee
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base(name, hours, valuePerHour)//Reaproveitando os argumentos já declarado classe Employee
        {
            AdditionalCharge = additionalCharge;
        }


        //Sobrescrever o método payment
        public override double Payment()
        {
            //base -> reaproveitando a logica do pyment comum
            return base.Payment() + 1.1 * AdditionalCharge; // + 110% * dispesa adicional
        }
    }
}
