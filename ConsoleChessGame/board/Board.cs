using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;

namespace board
{
    internal class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] pieces; //a matriz of pieces

        public Board() { }
        public Board(int lines,int columns)
        {
            Lines = lines;
            Columns = columns;
            pieces = new Piece[lines, columns]; //build the board
        }

        //return the piece
        public Piece GetPiece(int line, int column)
        {
            return pieces[line, column];
        }

        public Piece GetPiece(Position position)
        {
            return pieces[position.Line, position.Column];
        }

        public void SetPiece(Piece piece, Position position)
        {
            if (HavePiece(position))
            {
                throw new BoardExceptions("There's already a piece in this position");
            }
            pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }

        public bool HavePiece(Position pos)
        {
            IsPositionValid(pos);
            return GetPiece(pos) != null;
        }

        public bool IsPositionValid(Position position)
        {
            if (position.Line < 0 || position.Line >= Lines || position.Column <0 || position.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (IsPositionValid(position) != true) 
            {
                throw new BoardExceptions("Invalid Position");
            }
        }
    }
}
