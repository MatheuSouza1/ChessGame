using board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    internal class ChessMatch
    {
        public Board board { get; set; }
        public int Turn { get; set; }
        public Color PlayerTurn { get; set; }
        public bool IsMatchOver { get; set; }

        public ChessMatch() 
        {
            board = new Board(8,8);
            Turn = 0;
            PlayerTurn = Color.White;
            SetPieces();
            IsMatchOver = false;
        }

        public void MovePiece(Position origin, Position destiny)
        {
            Piece piece = board.RemovePiece(origin);
            piece.RaiseMvQuantity();
            Piece catchedPiece = board.RemovePiece(destiny);
            board.SetPiece(piece, destiny);
        }

        private void SetPieces()
        {
            board.SetPiece(new King(Color.White, board), new ChessPosition(6, 'a').ToPosition());
        }
    }
}
