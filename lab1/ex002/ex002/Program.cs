namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ndigitado = 0;
            Console.WriteLine("Digite um valor qualquer: ");
            Ndigitado = int.Parse(Console.ReadLine());
            if(EhPrimo(Ndigitado) == 1)
            {
                Console.WriteLine("{0} é primo ", Ndigitado);
            } else
            {
                Console.WriteLine("{0} não é primo", Ndigitado);
            }
        }


        static int EhPrimo(int a)
        {
            int cont = 0;
            for(int i = 1; i < a; i++)
            {
                if(a % i == 0)
                {
                    cont++;
                }
            }
            return cont;
        }
    }
}