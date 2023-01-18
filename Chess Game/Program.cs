using chess_Game;
using System;
using tabuleiro;
using xadrez;

namespace chess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
            //try
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
            //    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));

            //    Tela.ImprimirTabuleiro(tab);
            //}
            //catch (TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.ReadLine();
        }
    }
}
