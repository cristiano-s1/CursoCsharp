using ContratoFuncionario.Entities.Enums; //Importando Enuns
using System.Collections.Generic;

namespace ContratoFuncionario.Entities
{
    class Worker
    {
        //Propriedades
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } //Enums
        public double BaseSalary { get; set; } //Base salario funcionário
        public Department Department { get; set; } //Associando a classe department, e que é do tipo department
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//Lista de contratos / Já estanciei a lista para que ela não seja nula

        //Construtor padrão
        public Worker()
        {

        }

        //Contrutor com argumentos
        //Sempre que estiver uma associação para muitos, no caso aqui é o Contracts não incluir no construtor.
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //Método add
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract); //Acessando a lista de contratos e add contratos
        }

        //Método Remove
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);  //Acessando a lista de contratos e remove contratos
        }


        //Método
        //Quanto que o funcionário ganhou no mês e ano
        public double Income(int year, int month)
        {
            //Funcionário já ganha um salário base por mês
            double sum = BaseSalary;

            //Percorrer a lista de contratos e acresentar a soma de todos os contratos daquele ano
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month) //Acresentar só aqueles que são daquele ano e mes
                {
                    sum += contract.TotalValue(); //TotalValue é a operação que vai receber o total do contrato
                }
            }
            return sum;

        }


    }
}
