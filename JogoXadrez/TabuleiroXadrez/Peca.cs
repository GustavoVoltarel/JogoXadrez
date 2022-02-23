using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroXadrez
    {
    abstract class Peca
        {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
            {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QtdeMovimentos = 0;
            }

        public void IncrementarQtdeMovimentos()
            {
            QtdeMovimentos++;
            }
        }
    }
