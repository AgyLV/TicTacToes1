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
            if ((gameBoard[0] == gameBoard[1] && gameBoard[1] == gameBoard[2]) || (gameBoard[3] == gameBoard[4] && gameBoard[4] == gameBoard[5]) || (gameBoard[6] == gameBoard[7] && gameBoard[7] == gameBoard[8]) || (gameBoard[6] == gameBoard[7] && gameBoard[7] == gameBoard[8]) || (gameBoard[0] == gameBoard[3] && gameBoard[3] == gameBoard[6]) || (gameBoard[1] == gameBoard[4] && gameBoard[4] == gameBoard[7]) || (gameBoard[2] == gameBoard[5] && gameBoard[5] == gameBoard[8]) || (gameBoard[0] == gameBoard[4] && gameBoard[4] == gameBoard[8]) || (gameBoard[2] == gameBoard[4] && gameBoard[4] == gameBoard[6]))
            {
               return 1;
            }
            
                            
            else if (gameBoard[0] != "1" && gameBoard[1] != "2" && gameBoard[2] != "3" && gameBoard[3] != "4" && gameBoard[4] != "5" && gameBoard[5] != "6" && gameBoard[6] != "7" && gameBoard[7] != "8" && gameBoard[8] != "9")
            {
               return 2;
            }
            return 0;

        }
    }
}
