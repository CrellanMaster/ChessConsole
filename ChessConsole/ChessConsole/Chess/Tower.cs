﻿using System;
using board;

namespace Chess
{
    internal class Tower : Piece
    {
        public Tower(Color color, Board board) : base(color, board)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
