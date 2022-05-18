using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    public class CheckWinner
    {
        public static int Winner(string[] gameBoard)
        {
            if (gameBoard[1] == gameBoard[2] && gameBoard[2] == gameBoard[3])
            {
                return 1;
            }
            else if (gameBoard[4] == gameBoard[5] && gameBoard[5] == gameBoard[6])
            {
                return 1;
            }
            else if (gameBoard[7] == gameBoard[8] && gameBoard[8] == gameBoard[9])
            {
                return 1;
            }
            else if (gameBoard[1] == gameBoard[4] && gameBoard[4] == gameBoard[7])
            {
                return 1;
            }
            else if (gameBoard[2] == gameBoard[5] && gameBoard[5] == gameBoard[8])
            {
                return 1;
            }
            else if (gameBoard[3] == gameBoard[6] && gameBoard[6] == gameBoard[9])
            {
                return 1;
            }
            else if (gameBoard[1] == gameBoard[5] && gameBoard[5] == gameBoard[9])
            {
                return 1;
            }
            else if (gameBoard[3] == gameBoard[5] && gameBoard[5] == gameBoard[7])
            {
                return 1;
            }
            else if (gameBoard[1] != "1" && gameBoard[2] != "2" && gameBoard[3] != "3" && gameBoard[4] != "4" && gameBoard[5] != "5" && gameBoard[6] != "6" && gameBoard[7] != "7" && gameBoard[8] != "8" && gameBoard[9] != "9")
            {
                return 2;
            }
            return 0;

        }
    }
}
