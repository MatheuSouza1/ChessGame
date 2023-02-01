using board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    internal class King : Piece
    {
        public King() { }
        public King(Color color, Board board) : base(color, board)
        {
            
        }

        public override string ToString()
        {
            return "K";
        }

        private bool CanMove(Position pos)
        {
            Piece piece = Board.GetPiece(pos);
            return piece == null || piece.Color != Color;
        }

        public override bool[,] PossibleMoves()
        {
            bool[,] mat = new bool[8, 8];
            Position pos = new Position(0,0);

            //up verification
            pos.Values(Position.Line - 1, Position.Column);
            if(Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //northeast
            pos.Values(Position.Line - 1, Position.Column + 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //rightVerification
            pos.Values(Position.Line, Position.Column + 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //southeast verification
            pos.Values(Position.Line + 1, Position.Column + 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //down verification
            pos.Values(Position.Line + 1, Position.Column);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //southwest verification
            pos.Values(Position.Line + 1, Position.Column - 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //left
            pos.Values(Position.Line, Position.Column - 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }

            //northwest
            pos.Values(Position.Line - 1, Position.Column - 1);
            if (Board.IsPositionValid(pos) && CanMove(pos))
            {
                mat[pos.Line, pos.Column] = true;
            }
        }
    }
}
