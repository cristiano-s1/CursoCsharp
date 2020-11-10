
namespace SalarioFuncionarioPlimorfismo.Entities
{
    class Employee
    {

        //Propriedades
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }


        //Construtor padrão
        public Employee()
        {

        }

        //Construtor com argumentos
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //Metodo
        //virtual libera a opção de payment para sobrescrever na classe OutsourcedEmployee
        public virtual double Payment() 
        {
            return Hours * ValuePerHour;
        }

    }
}
