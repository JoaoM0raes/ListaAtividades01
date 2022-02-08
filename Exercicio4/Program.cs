using System;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temperatura;

            float TemperaturaOne;

            float TemperaturaKelvin;

            Console.Write("Insira a Temperatura em Celcius:  ");

            temperatura = Console.ReadLine();

            TemperaturaOne = float.Parse(temperatura);

            TemperaturaKelvin = (TemperaturaOne * 9 / 5) + 32;

            Console.WriteLine("A Conversão é: " + TemperaturaKelvin + " Fahrenheit ");
        }
    }
}
