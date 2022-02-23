using TabuleiroXadrez;

namespace JogoXadrez.PecasXadrez
    {
    internal class PosicaoXadrez
        {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
            {
            Coluna = coluna;
            Linha = linha;
            }

        public Posicao ParaPosicao()
            {
            return new Posicao(8 - Linha, Coluna - 'A');
            }
        public override string ToString()
            {
            return ""
                + Coluna
                + Linha;
            }
        }
    }
