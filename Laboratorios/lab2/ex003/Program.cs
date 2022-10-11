using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.Write("Digite um valor A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite um valor B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("A potencia de {0} na base {1} é: {2}", A, B, potencia(A, B));
        }

        static int potencia(int val1, int val2){
            if(val2 == 0){
                return 1;
            } else {
                return val1 * potencia(val1, val2-1);
            }
            
        }
    }
}
