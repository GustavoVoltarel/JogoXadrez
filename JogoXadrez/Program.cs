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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 3));

                Tela.imprimirTabuleiro(tab);


                }
            catch(TabuleiroException ex)
                {
                Console.WriteLine(ex.Message);
                }
            }
        }
    }