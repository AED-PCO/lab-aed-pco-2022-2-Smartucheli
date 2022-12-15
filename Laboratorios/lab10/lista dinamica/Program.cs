namespace lista_dinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new lista();
           insere(lista.proximo, 10);
            tira(lista);
        }
    }
}