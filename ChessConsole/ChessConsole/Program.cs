using System;
using board;
using Chess;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board tab = new Board(8, 8);

                tab.PlacePart(new Tower(Color.Preta, tab), new Position(0, 0));
                tab.PlacePart(new Tower(Color.Preta, tab), new Position(1, 9));
                tab.PlacePart(new King(Color.Preta, tab), new Position(0, 0));

                Screen.ShowBoard(tab);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}