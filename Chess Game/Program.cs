using System;
using Tabuleiro;

namespace chess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);
            Console.WriteLine("Posição: " + P);

            Console.ReadLine();

        }
    }
}
