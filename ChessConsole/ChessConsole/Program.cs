using System;
using board;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board tab = new Board(8, 8);
            Screen.ShowBoard(tab);
            Console.WriteLine();
        }
    }
}