using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sálario;

            float SálarioOne;

            float SálarioAumento;

            float SálarioDesconto;

            Console.WriteLine("Insira seu Salário: ");

            sálario = Console.ReadLine();

            SálarioOne = float.Parse(sálario);

            SálarioAumento = (SálarioOne * 0.15f + SálarioOne);

            Console.WriteLine("O Salário aumentado é: " + SálarioAumento.ToString("F") + "$");

            SálarioDesconto = SálarioAumento - (SálarioAumento * 0.08f);

            Console.WriteLine("O Salario total é:  " + SálarioDesconto.ToString("F") + "$");
        }
    }
}
