namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("Digite sua frase: ");
            frase =  Console.ReadLine();
            Console.WriteLine("a frase sem vogal é: {0}", TiraVogal(frase));
        }

        static string TiraVogal(string frase)
        {
            if(frase == "")
            {
                return "";
            }
            char cont = char.ToLower(frase[frase.Length - 1]);
            if (cont == 'a' || cont == 'e' || cont == 'i' || cont == 'o' || cont == 'u')
            {
                return TiraVogal(frase.Substring(0, frase.Length - 1));
            }
            else
            {
                return TiraVogal(frase.Substring(0, frase.Length - 1)) + frase[frase.Length - 1];
            }

            
            
        }
    }
}