using board;
using chess;

namespace ConsoleChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessMatch match= new ChessMatch();

            while (!match.IsMatchOver)
            {
                Console.Clear();
                Screen.showBoard(match.board);

                Console.Write("Origin");
                Position origin = Screen.ReadChessPosition().ToPosition();
                Console.Write("Destiny");
                Position destiny = Screen.ReadChessPosition().ToPosition();

                match.MovePiece(origin, destiny);
            }
        }
    }
}