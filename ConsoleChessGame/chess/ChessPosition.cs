using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board;

namespace chess
{
    internal class ChessPosition
    {
        public int Line { get; set; }
        public char Colunm { get; set; }

        public ChessPosition() { }
        public ChessPosition(int line, char colunm)
        {
            Line = line;
            Colunm = colunm;
        }

        public Position ToPosition()
        {
            return new Position(8 - Line, Colunm - 'a');
        }

        public override string ToString()
        {
            return $"{Line}{Colunm}";
        }
    }
}
