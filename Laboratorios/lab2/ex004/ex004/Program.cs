namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            string frase;
            Console.WriteLine("Digite sua frase: ");
            frase = Console.ReadLine();
            Console.Write("Digite uma palavra dessa frase: ");
            letra = Console.ReadKey().KeyChar;
            frase.ToLower();

            Console.WriteLine("\nO numero de vezes que a letra {0} repetiu é de: {1}", letra, texto(frase, letra));
        }

        static int texto(string f, char l)
        {
            int n = 0;
            if (f.Length < 1)
            {
                return 0;
            } else
            {
                if (f[0] == l)
                {
                    return texto(f.Substring(1), l) + n + 1;
                } else
                {
                    return texto(f.Substring(1), l);
                }

            } 

        } 
    }
}