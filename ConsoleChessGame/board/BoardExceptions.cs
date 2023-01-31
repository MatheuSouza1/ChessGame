using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    internal class BoardExceptions : Exception
    {
        public BoardExceptions(string message) : base(message) { }
    }
}
