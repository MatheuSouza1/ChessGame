using board;

namespace ConsoleChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);
            Screen.showBoard(board);
        }
    }
}