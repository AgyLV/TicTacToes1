using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    public class CallingGameBoard
    {
        public int Field1 { get; private set; }
        public int Field2 { get; private set; }
        public int Field3 { get; private set; }
        public int Field4 { get; private set; }
        public int Field5 { get; private set; }
        public int Field6 { get; private set; }
        public int Field7 { get; private set; }
        public int Field8 { get; private set; }
        public int Field9 { get; private set; }
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

        public void IrAiznemts(string[] gameBoard, string playerSimbol, int value)
        {
            
            {
                switch (value)
                {
                    case 1:
                        if (Field1 != 1) ;
                        {
                            return;
                        }
                        Field1 = value;
                        break;
                    case 2:
                        if (Field2 != 2) ;
                        {
                            return;
                        }
                        Field2 = value;
                        break;
                    case 3:
                        if (Field3 != 3) ;
                        {
                            return;
                        }
                        Field3 = value;
                        break;
                    case 4:
                        if (Field4 != 4) ;
                        {
                            return;
                        }
                        Field4 = value;
                        break;
                    case 5:
                        if (Field5 != 5) ;
                        {
                            return;
                        }
                        Field5 = value;
                        break; ;
                    case 6:
                        if (Field6 != 6) ;
                        {
                            return;
                        }
                        Field6 = value;
                        break;
                    case 7:
                        if (Field7 != 7) ;
                        {
                            return;
                        }
                        Field7 = value; 
                        break;
                    case 8:
                        if (Field8 != 8) ;
                        {
                            return;
                        }
                        Field8 = value;
                        break;
                    case 9:
                        if (Field9 != 9) ;
                        {
                            return;
                        }
                        Field9 = value;
                        break;
                    default:
                        break;


                }
            }
        }
    }
}
