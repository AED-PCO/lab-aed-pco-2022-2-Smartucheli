using System.ComponentModel;

namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] SomaL = new int[5];
            int[] SomaC = new int[3];
            int[,] a = new int[5, 3];
            LeMatriz(a);
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    SomaL[i] += a[i, j];
                }
                Console.WriteLine("A soma das linhas é: {0}", SomaL[i]);
            }
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    SomaC[j] += a[i, j];
                }
                Console.WriteLine("A soma das colunas é: {0}", SomaC[j]);
            }

        }

        static void LeMatriz(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("Coluna{0} \tLinha{1}", i, j);
                    a[i, j] = int.Parse(Console.ReadLine()); 
                }
            }
        }
    }
}