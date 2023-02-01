using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MvQuantity { get; set; }
        public Board Board { get; set; }

        public Piece() { }
        public Piece(Color color, Board board)
        {
            Color = color;
            Board = board;
            MvQuantity = 0;
        }

        public void RaiseMvQuantity()
        {
            MvQuantity++;
        }

        abstract public bool[,] PossibleMoves()
        {

        }
    }
}
