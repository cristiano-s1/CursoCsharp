namespace ContratoFuncionario.Entities
{
    class Department
    {
        //Propriedade
        public string Name { set; get; }

        //Construtor padrão
        public Department()
        {

        }

        //Construtor com argumento
        public Department(string name)
        {
            Name = name;
        }
    }
}
