using PecasXadrez;
using TabuleiroXadrez;

namespace JogoXadrez.PecasXadrez
    {
    internal class PartidaXadrez
        {
        public Tabuleiro Tab { get; private set;}
        private int Turno;
        private Cor JogadorAtual;
        public bool PartidaFinalizada { get; private set;}


        public PartidaXadrez()
            {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            PartidaFinalizada = false;
            ColocarPeca();
            }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
            {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQtdeMovimentos();
            Peca PecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
            }

        private void ColocarPeca()
            {
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('A', 1).ParaPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('H', 1).ParaPosicao());
            Tab.ColocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('B', 1).ParaPosicao());
            Tab.ColocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('G', 1).ParaPosicao());
            Tab.ColocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('C', 1).ParaPosicao());
            Tab.ColocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('F', 1).ParaPosicao());
            Tab.ColocarPeca(new Rainha(Tab, Cor.Branca), new PosicaoXadrez('D', 1).ParaPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('E', 1).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('A', 2).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('B', 2).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('C', 2).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('D', 2).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('E', 2).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('F', 2).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('G', 2).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('H', 2).ParaPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('A', 8).ParaPosicao());
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('H', 8).ParaPosicao());
            Tab.ColocarPeca(new Cavalo(Tab, Cor.Preta), new PosicaoXadrez('B', 8).ParaPosicao());
            Tab.ColocarPeca(new Cavalo(Tab, Cor.Preta), new PosicaoXadrez('G', 8).ParaPosicao());
            Tab.ColocarPeca(new Bispo(Tab, Cor.Preta), new PosicaoXadrez('C', 8).ParaPosicao());
            Tab.ColocarPeca(new Bispo(Tab, Cor.Preta), new PosicaoXadrez('F', 8).ParaPosicao());
            Tab.ColocarPeca(new Rainha(Tab, Cor.Preta), new PosicaoXadrez('D', 8).ParaPosicao());
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('E', 8).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('A', 7).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('B', 7).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('C', 7).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('D', 7).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('E', 7).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('F', 7).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('G', 7).ParaPosicao());
            Tab.ColocarPeca(new Peao(Tab, Cor.Preta), new PosicaoXadrez('H', 7).ParaPosicao());

            }
        }
    }
