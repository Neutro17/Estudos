using CA_Banco2.Model;
using System;


namespace CA_Banco2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            cli1.Codigo = "1";
            cli1.Nome = "José";

            Funcionario func1 = new Funcionario();
            func1.Codigo = "1";
            func1.Nome = "Maria";
            func1.Salario = 1000;

            Console.WriteLine("Nome do Cliente: = {0}", cli1.Nome);
            Console.WriteLine("Nome do funcionário(a): = {0}", func1.Nome);
            Console.ReadKey();
        }
    }
}
