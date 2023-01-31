using board;
using chess;

namespace ConsoleChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);

            board.SetPiece(new King(Color.Black, board), new Position(0,5));

            Screen.showBoard(board);
        }
    }
}