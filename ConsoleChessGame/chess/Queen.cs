using board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    internal class Queen : Piece
    {
        public Queen(Color color, Board board) : base(color, board) 
        {
            
        }
        public override string ToString()
        {
            return "Q";
        }
    }
}
