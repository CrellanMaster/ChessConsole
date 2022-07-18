using System;
using board;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Board tab = new Board(8, 8);

            tab.PlacePart(new Tower(Color.Preta, tab), new Position(0, 0));
            tab.PlacePart(new Tower(Color.Preta, tab), new Position(1, 3));
            tab.PlacePart(new King(Color.Preta, tab), new Position(2, 4));

            Screen.ShowBoard(tab);
            Console.WriteLine();
        }
    }
}