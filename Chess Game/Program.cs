using chess_Game;
using System;
using tabuleiro;

namespace chess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}
