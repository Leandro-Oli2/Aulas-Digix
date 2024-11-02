using System;
using System.Security.Cryptography.X509Certificates;
namespace Aula3
{
    class Program3
    {
        static void Main(String[] args)
        {
            int idade = 10;
            string resultado = idade >= 18 ? "Adulto" : "Crianca";
            System.Console.WriteLine(resultado);
        }
    }
}