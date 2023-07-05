using xadrez_console.Tabuleiro;

internal class Program
{
    private static void Main(string[] args)
    {
        Posicao p = new Posicao (3, 4);

        Console.WriteLine("Posicao: " + p);
        Console.ReadLine();
    }
}