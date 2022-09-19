namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, contC = 0, contD = 0;
            int[]a = new int[5];
            int[]b = new int[5];
            int[]c = new int[5];
            int[]d = new int[5];
            Console.WriteLine("Digite os valores do vetor a");
            for(int i = 0; i< a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Agora digite os valores de b");
            for( int i = 0; i< b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0;i < b.Length ; i++)
            {
                for(int j = 0; j < a.Length; i++)
                {
                    if (a[j] == b[i])
                        c[contC] = a[j];
                    contC++;                   
                    if (a[i] == b[j])                   
                        d[contD] = a[i];
                    contD++;                   

                }
                cont++;
            }

            Console.WriteLine("OS valores em comum de a e b são: ");
                for(int i = 0; i < c.Length; i++)
                {
                    Console.WriteLine(c[i]);
                }

            Console.WriteLine("os valores q existem em a e não em b são: ");
            for(int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i]);
            }
            }
        }
    }
