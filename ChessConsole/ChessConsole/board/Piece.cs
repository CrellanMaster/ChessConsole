﻿namespace board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color color { get; protected set; }
        public int QuantityMoviments { get; protected set; }
        public Board Tab { get; protected set; }

        public Piece(Position position, Color color, Board tab)
        {
            Position = position;
            this.color = color;
            Tab = tab;
            QuantityMoviments = 0;
        }
    }
}
