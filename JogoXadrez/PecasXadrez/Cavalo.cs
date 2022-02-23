using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabuleiroXadrez;

namespace PecasXadrez
    {
    class Cavalo : Peca
        {
        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
            {
            }

        public override string ToString()
            {
            return " C ";
            }
        }
    }
