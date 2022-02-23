using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabuleiroXadrez;

namespace JogoXadrez.PecasXadrez
    {
    class Rainha : Peca
        {
        public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor)
            {
            }

        public override string ToString()
            {
            return " Q ";
            }
        }
    }
