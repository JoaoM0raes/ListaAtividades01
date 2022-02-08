using System;

namespace ListaAtividades01.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Altura;
            string Base;
            float alturaOne;
            float BaseOne;
            float Resultado;

            Console.Write("Insira a Altura do terreno: ");

            Altura = Console.ReadLine();

            Console.Write("Insira a Base do terreno: ");

            Base = Console.ReadLine();

            alturaOne = float.Parse(Altura);

            BaseOne = float.Parse(Base);

            Resultado = BaseOne * alturaOne;

            Console.WriteLine("A área do terreno é " + Resultado);
        }
    }
}
