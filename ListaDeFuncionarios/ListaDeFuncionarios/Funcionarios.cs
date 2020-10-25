using System.Globalization;

namespace ListaDeFuncionarios
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementaSalario(double porcentage)
        {
            Salario += Salario * porcentage / 100;
        }

        public override string ToString()
        {
            return
                "Id: "
                + Id
                + " Nome: "
                + Nome
                + " Salario: "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
