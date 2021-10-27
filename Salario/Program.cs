//Daniel Hiroshi Fugikawa - 200209
using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração do vetor
            funcionarios[] vect = new funcionarios[100];
            //Solicitando o numero de Funcionarios
            Console.WriteLine("Digite o numero de Funcionarios a ser registrado: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(" ");
                //Informações dos funcionarios
                Console.WriteLine($"Funcionario#{i}");
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario:");
                double salario = double.Parse(Console.ReadLine());

                vect[id] = new funcionarios(nome, salario, id);
            }
            Console.WriteLine("");
            //Informar o funcionário que ira receber o aumento
            Console.WriteLine("Id do funcionário receberá aumento: ");
            int id2 = int.Parse(Console.ReadLine());

            if (vect[id2] != null)
            {
                //Conta para realizar o aumento
                Console.WriteLine("Porcentagem de aumento de salario: ");
                double porcentagem = double.Parse(Console.ReadLine());
                porcentagem = porcentagem + 100;
                vect[id2].AumentarSalario(porcentagem);
            }
            else
            {
                //Caso seja digitado um id inexistente
                Console.WriteLine("Este funcionario não existe!");
            }
            //Atualização a lista dos funcinários com o aumento realizado
            Console.WriteLine("Lista atualizada dos funcionarios da Bravo: ");
            for (int i = 0; i < 100; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
