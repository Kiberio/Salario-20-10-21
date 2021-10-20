//Daniel Hiroshi Fugikawa - 200209
namespace Salario
{
    class funcionarios
    {
        //Declaração das variaveis da classe
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int Id { get; set; }

        //Declaração do construtor
        public funcionarios(string nome, double salario, int id)
        {
            Nome = nome;
            Salario = salario;
            Id = id;
        }
        //Forma de mostar os funcionários em lista
        public override string ToString()
        {
            return Id + " , " + Nome + " , " + Salario;
        }
        //Função para aumentar o salario
        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario * porcentagem / 100;
        }
    }
}
