﻿using JogoXadrez.TabuleiroXadrez;

namespace TabuleiroXadrez
    {
    class Tabuleiro
        {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
            {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
            }

        public Peca peca(int linha, int coluna)
            {
            return Pecas[linha, coluna];
            }

        public Peca peca(Posicao pos)
            {
            return Pecas[pos.Linha, pos.Coluna];
            }

        public bool ExistePeca(Posicao pos)
            {
            ValidarPosicao(pos);
            return peca(pos) != null;
            }

        public void ColocarPeca(Peca p, Posicao pos)
            {
            if(ExistePeca(pos))
                {
                throw new TabuleiroException("Já existe uma peça nessa posição");
                }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
            }

        public Peca RetirarPeca(Posicao pos)
            {
            if(peca(pos) == null)
                {
                return null;
                }
            else
                {
                Peca p = peca(pos);
                p.Posicao = null;
                Pecas[pos.Linha, pos.Coluna] = null;
                return p;
                }
            }

        public bool PosicaoValida(Posicao pos)
            {
            if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
                {
                return false;
                }
            return true;
            }

        public void ValidarPosicao(Posicao pos)
            {
            if(!PosicaoValida(pos))
                {
                throw new TabuleiroException("Posição Inválida!");
                }
            }
        }
    }
