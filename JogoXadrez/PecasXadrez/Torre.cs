﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabuleiroXadrez;

namespace PecasXadrez
    {
    class Torre :Peca
        {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
            {
            }

        public override string ToString()
            {
            return " T ";
            }
        }
    }
