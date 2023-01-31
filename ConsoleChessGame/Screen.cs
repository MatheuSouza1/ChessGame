using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;

namespace ConsoleChessGame
{
    internal class Screen
    {
        public static void showBoard(Board board)
        {
            for (int i = 0; i < board.Lines; i++)
            {
                for(int n = 0; n < board.Columns; n++)
                {
                    if (board.GetPiece(i, n) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.GetPiece(i, n) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
