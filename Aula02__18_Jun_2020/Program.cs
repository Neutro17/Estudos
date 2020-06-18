using System;
using CA_Escola.Model;

namespace CA_Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
           
            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno: ");
            aluno1.idade = Console.ReadLine();

            Console.WriteLine("Digite o email do aluno: ");
            aluno1.email = Console.ReadLine();

            Console.WriteLine("Nome: " + aluno1.nome);
            Console.WriteLine("Idade: " + aluno1.idade);
            Console.WriteLine("E-mail: " + aluno1.email);

            Console.ReadKey();
        }
    }
}
