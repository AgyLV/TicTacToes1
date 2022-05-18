using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    public class CallingGameBoard
    {
        public static void GameBoard(string[] gameBoard)
        {
            Console.WriteLine(@"


  _______   _            _______                    _______                
 |__   __| (_)          |__   __|                  |__   __|               
    | |     _    ___       | |      __ _    ___       | |      ___     ___ 
    | |    | |  / __|      | |     / _` |  / __|      | |     / _ \   / _ \
    | |    | | | (__       | |    | (_| | | (__       | |    | (_) | |  __/
    |_|    |_|  \___|      |_|     \__,_|  \___|      |_|     \___/   \___|
                                                                           
                                                                           
            

");

            Console.WriteLine("         |         |         ");
            Console.WriteLine($"    {gameBoard[1]}    |    {gameBoard[2]}    |    {gameBoard[3]}    ");
            Console.WriteLine("         |         |         ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("         |         |         ");
            Console.WriteLine($"    {gameBoard[4]}    |    {gameBoard[5]}    |    {gameBoard[6]}    ");
            Console.WriteLine("         |         |         ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("         |         |         ");
            Console.WriteLine($"    {gameBoard[7]}    |    {gameBoard[8]}    |    {gameBoard[9]}    ");
            Console.WriteLine("         |         |         ");
        }
    }
}
