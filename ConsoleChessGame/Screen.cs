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
            for (int i = 0; i < board.Lines; i++) //for to run through the lines
            {
                for(int n = 0; n < board.Columns; n++) //for to run through the columns
                {
                    if (board.GetPiece(i, n) == null) 
                    {
                        Console.Write("- "); //print a "-" to represent a empty space
                    }
                    else
                    {
                        Console.Write(board.GetPiece(i, n) + " "); //if the space is not empty print the piece
                    }
                }
                Console.WriteLine(); //next line
            }
        }
    }
}
