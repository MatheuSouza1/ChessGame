using board;
using chess;

namespace ConsoleChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Board board = new Board(8,8);

            board.SetPiece(new King(Color.Black, board), new Position(0,0));
            board.SetPiece(new King(Color.White, board), new Position(1,5));
            board.SetPiece(new Queen(Color.White, board), new Position(2,0));

            Screen.showBoard(board);

            ChessPosition position = new ChessPosition(5,'a');
            Console.WriteLine(position.ToPosition());
        }
    }
}