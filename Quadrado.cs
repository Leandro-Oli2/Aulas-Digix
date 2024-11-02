using System;

namespace Exemplo6
{
    class Quadrado
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Informe o valor de altura: ");
            double alt = double.Parse(System.Console.ReadLine());
            Console.WriteLine("Informe o valor do Base: ");
            double bas = double.Parse(System.Console.ReadLine());
            double hip = 0;
            hip = bas*alt;
            Console.WriteLine($"A area do Quadrado eh: {hip:F2}");
        }
    }
}