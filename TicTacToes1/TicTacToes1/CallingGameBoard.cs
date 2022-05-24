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
            Console.WriteLine($"    {gameBoard[0]}    |    {gameBoard[1]}    |    {gameBoard[2]}    ");
            Console.WriteLine("         |         |         ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("         |         |         ");
            Console.WriteLine($"    {gameBoard[3]}    |    {gameBoard[4]}    |    {gameBoard[5]}    ");
            Console.WriteLine("         |         |         ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("         |         |         ");
            Console.WriteLine($"    {gameBoard[6]}    |    {gameBoard[7]}    |    {gameBoard[8]}    ");
            Console.WriteLine("         |         |         ");
        }
    }
}
