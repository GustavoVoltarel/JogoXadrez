﻿using JogoXadrez.PecasXadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabuleiroXadrez;

namespace JogoXadrez
    {
    internal class Tela
        {
        public static void ImprimirTabuleiro(Tabuleiro tab)
            {

            for(int i = 0; i < tab.Linhas; i++)
                {
                Console.Write(8 - i + " ");
                for(int j = 0; j < tab.Colunas; j++)
                    {
                    if(tab.peca(i, j) == null)
                        {
                        Console.Write(" - ");
                        }
                    else
                        {
                        ImprimirPeca(tab.peca(i, j));
                        }
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            Console.WriteLine("   a  b  c  d  e  f  g  h");
            }

        public static PosicaoXadrez LerPosicaoXadrez()
            {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
           
            }
        public static void ImprimirPeca(Peca peca)
            {
            if(peca.Cor == Cor.Branca)
                {
                Console.Write(peca);
                }
            else
                {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
                }
            }
        }
    }
