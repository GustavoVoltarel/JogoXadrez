using JogoXadrez.PecasXadrez;
using JogoXadrez.TabuleiroXadrez;
using PecasXadrez;
using TabuleiroXadrez;

namespace JogoXadrez
    {
    class Program
        {
        static void Main(string[] args)
            {
            try
                {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.PartidaFinalizada)
                    {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ParaPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ParaPosicao();

                    partida.ExecutaMovimento(origem, destino);
                    }
                }
            catch(TabuleiroException ex)
                {
                Console.WriteLine(ex.Message);
                }
            }
        }
    }