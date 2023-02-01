using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    internal class Position
    {
        public int Line { get; set; }
        public int Column { get; set; }

        public Position() { }
        public Position(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public void Values(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public override string ToString()
        {
            return $"{Line},{Column}";
        }
    }
}
