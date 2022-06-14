using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    public class GameBoardFieldOutOfRangeException : Exception
    {

        public GameBoardFieldOutOfRangeException()
        {

        }

        public GameBoardFieldOutOfRangeException(string message) : base(message)
        {

        }

        public GameBoardFieldOutOfRangeException(string message, Exception exception) : base(message, exception)
        {

        }

    }
}
