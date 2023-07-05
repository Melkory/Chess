using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(1, 3));
            
            
            Tela.ImprimirTabuleiro(tab);
        }
        
        catch (TabuleiroException e) 
        {
            Console.WriteLine(e.Message);
        }


    }
}