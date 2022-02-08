using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;

            string Idade;

            float IdadeOne;

            float IdadeTotal;

            Console.Write("Insira Seu Nome :");

            Nome = Console.ReadLine();

            Console.Write("Insira Sua Idade :");

            Idade = Console.ReadLine();

            IdadeOne = float.Parse(Idade);

            IdadeTotal = IdadeOne * 365;

            Console.WriteLine("Caro/a " + Nome + " Tem " + IdadeTotal + " Dias");
        }
    }
}
