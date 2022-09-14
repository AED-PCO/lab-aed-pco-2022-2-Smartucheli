namespace ex002._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 1, quantidade = 1000, soma = 0, i;
            while(valor <= quantidade)
            {
                for(i = 1; i < valor; i++)
                {
                    if (valor % i == 0)
                        soma = soma + i;
                }
                i = 0;
                if(soma == valor)
                {
                    Console.WriteLine("OS numeros perfeitos são: {0}", valor);
                }
                soma = 0;
                valor++;
            }
        }
    }
}