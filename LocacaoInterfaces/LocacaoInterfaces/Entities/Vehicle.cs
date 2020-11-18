
namespace LocacaoInterfaces.Entities
{
    class Vehicle
    {
        //Propriedades
        public string Model { get; set; }

        //Construtor padrão
        public Vehicle()
        {

        }

        //Construtor com argumentos
        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
