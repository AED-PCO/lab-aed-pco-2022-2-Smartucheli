using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, divnum = 0, resto = 0, soma = 0, quadrado = 0;
            Console.Write("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            divnum = a / 100;
            resto = a % 100;
            soma = divnum + resto;
            quadrado = soma * soma;
            Console.WriteLine("A soma de {0} com {1} é igual a {2}", divnum, resto, soma);
            Console.WriteLine("E o quadrado é {0}", quadrado);
        }
    }
}
