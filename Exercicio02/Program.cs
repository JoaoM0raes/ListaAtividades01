using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pao;
            string broa;

            float paoOne;
            float BroaOne;

            float totalPao;
            float totalBroa;

            float Poupança;

            Console.Write("Insira a Quantidade de Pães: ");

            pao = Console.ReadLine();

            Console.Write("Insira a Quantidade de Broas: ");

            broa = Console.ReadLine();

            paoOne = float.Parse(pao);

            BroaOne = float.Parse(broa);

            totalPao = paoOne * 0.12f;

            totalBroa = BroaOne * 1.50f;

            float total = totalBroa + totalPao;

            Console.WriteLine("Arrecadado por meio da venda de Broa e Pão: " + total);

            Poupança = (totalBroa + totalPao) * 0.10f;

            Console.WriteLine("A popança do Mês é : " + Poupança.ToString("F"));
        }
    }
}
