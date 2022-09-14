namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, divNum = 0, soma = 0, resto = 0, quadrado = 0;
            Console.Write("Digite um numero: ");
            a = int.Parse(Console.ReadLine());
            divNum = a / 100;
            resto = a % 100;
            soma = divNum + resto;
            quadrado = soma * soma;
            Console.WriteLine("A soma de {0} e {1} é a idual a {2}", divNum, resto, soma);
            Console.WriteLine("E o quadrado é: {0} ", quadrado);
        }
    }
}