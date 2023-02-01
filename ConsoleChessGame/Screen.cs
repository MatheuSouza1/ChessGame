using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;
using chess;

namespace ConsoleChessGame
{
    internal class Screen
    {
        public static void showBoard(Board board)
        {
            for (int i = 0; i < board.Lines; i++) //for to run through the lines
            {
                Console.Write($"{8-i} ");
                for(int n = 0; n < board.Columns; n++) //for to run through the columns
                {
                    if (board.GetPiece(i, n) == null) 
                    {
                        Console.Write("- "); //print a "-" to represent a empty space
                    }
                    else
                    {
                        if (board.GetPiece(i,n).Color == Color.White)
                        {
                            Console.Write(board.GetPiece(i, n) + " "); //if the space is not empty print the piece
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(board.GetPiece(i,n) + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                Console.WriteLine(); //next line
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static ChessPosition ReadChessPosition()
        {
            string position = Console.ReadLine();
            char column = position[0];
            int line = int.Parse(position[1] + "");
            return new ChessPosition(line, column);
        }
    }
}
