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

        public void SetPiece(Piece piece, Position position)
        {
            pieces[position.Line, position.Column] = piece;
            piece.Position = position;
        }
    }
}
