using System;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            int []vet = new int [5];
            int n;
            LeVetor(vet);
            Console.Write("Digite uma posição: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("a soma dos pares é: {0}", SmPar(vet, n));

        }

        static int SmPar(int []vetor, int pos){
                if(pos == 1){
                    return 0;
                } else if(vetor[pos] % 2 == 0){
                    return vetor[pos] + SmPar(vetor, pos - 1);
                } else {
                    return SmPar(vetor, pos - 1);
                }
            }

         static void LeVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(i + 1 + "-");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
