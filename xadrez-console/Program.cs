using xadrez_console;
using xadrez_console.tabuleiro;
using xadrez;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            
            while (!partida.terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tab);

                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                Console.Clear();
                Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                Console.Write("Destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                partida.executaMovimento(origem, destino);
            }

            Tela.ImprimirTabuleiro(partida.tab);
        }
        
        catch (TabuleiroException e) 
        {
            Console.WriteLine(e.Message);
        }

        Console.ReadLine();
    }
}