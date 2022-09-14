namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Digite um valor e seu fatorial sera exibido");
            n = int.Parse(Console.ReadLine());
            Console.Write("O fatorial de {0} é: {1}", n, Fatorial(n));
        }

        static int Fatorial(int n)
        {
            if(n == 2)
            {
                return 2;
            } else
                return n * Fatorial(n - 1);
        }
    }
}