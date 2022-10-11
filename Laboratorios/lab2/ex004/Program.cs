using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.Write("Digite uma frase: ");
            frase = string.parse(Console.ReadLine);
            Console.WriteLine("o numero de letras {0} é: {1}", b, palavra(frase, b));
        }

        static string palavra(string a, char b){
            if(a == "b"){
                return 0;
            } else {
                if(a[0] == b){
                    return palavra(a.Substring(1), b) + 1;
                } else {
                    return palavra(a.Substring(1), b);
                }
            }

        }
    }

}

