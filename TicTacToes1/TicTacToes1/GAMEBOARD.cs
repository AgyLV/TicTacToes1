using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    internal class GAMEBOARD
    {
        public void gameBoard()
        {


            string[] gameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int[] taken = new int[10];
            //string player2Simbol = "";

            CallingGameBoard.GameBoard(gameBoard);

            PlayerHuman player1 = new PlayerHuman();
            player1.GetPlayerName();
            player1.GetPlayerSimbol();

            PlayerHuman player2 = new PlayerHuman();
            player2.GetPlayerName();

                       

            //Console.WriteLine("What is the name of player 1?");
            //string player1 = Console.ReadLine();

            //while (string.IsNullOrEmpty(player1))
            //{
            //    Console.WriteLine("Name can't be empty! Input your name once more");
            //    player1 = Console.ReadLine();
            //}

            //Console.WriteLine("What is the name of player 2?");
            //string player2 = Console.ReadLine();

            //while (string.IsNullOrEmpty(player2))
            //{
            //    Console.WriteLine("Name can't be empty! Input your name once more");
            //    player2 = Console.ReadLine();
            //}

            ////-----------------------------------------------------------------------
            ////Spēlētāja simbola izvēle 

            //Console.WriteLine($"{player1} choose your simbol X or O ");
            ////string player1Simbol = Console.ReadLine().ToUpper();

            //PlayerSimbol simbol = new PlayerSimbol();

            //string player1Simbol = simbol.CheckSymbol(); //ievadītais simbols pirmajam spēlētājam.


            Enum x = Enum.X;
            Enum o = Enum.O;

            string xSimbol = x.ToString();
            string oSimbol = o.ToString();


            if (player1.Simbols == oSimbol)
            {
                player2.Simbols = xSimbol;

            }
            else if (player1.Simbols == xSimbol)
            {
                player2.Simbols = oSimbol;

            }

            Console.WriteLine($"{player1.Name} simbol: {player1.Simbols }");
            Console.WriteLine($"{player2.Name} simbol: {player2.Simbols }");


            // Spēlētāja izvēlēto simbolu izvade
            //----------------------------------------------------------------------

            Console.WriteLine($"Spied ''Enter'', lai turpinātu spēli.");

            Console.ReadLine();

            Console.Clear();


            CallingGameBoard.GameBoard(gameBoard);


            Array.Clear(taken, 0, taken.Length);


            for (int i = 0; i < gameBoard.Length;)
            {
                int uzvaretajs = CheckWinner.Winner(gameBoard);

                int choise = 0;



                if (i % 2 == 0)
                {

                    choise = 0;

                   while(choise == 0)
                    {
                        try
                        {
                            Console.WriteLine($"{player1.Name} choose your field!");
                            choise = int.Parse(Console.ReadLine());
                            CheckWinner.CheckInput(choise);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Netika korekti ievadīts skaitlis.");
                            
                        }
                        catch (GameBoardFieldOutOfRangeException ex)
                        {

                            Console.WriteLine(ex.Message);
                            choise = 0;
                        }
                    
                    }



                    
                   


                    i++;

                    //int choise1 = int.Parse(choise);
                    //gameBoard[choise -1] = player1Simbol;

                    Console.WriteLine(choise);
                    if (taken[choise - 1] != 0)
                    {
                        Console.WriteLine("Field is already taken! Choose other field! 1");
                         choise = int.Parse(Console.ReadLine());
                        continue;
                    }
                    
                        gameBoard[choise - 1] = player1.Simbols;



                    taken[choise - 1] = 1;
                    uzvaretajs = CheckWinner.Winner(gameBoard); // kombinācijas vērtību pārnesam uz mainīgo, proti, vai ir 3 simboli pēc kārtas
                    Console.Clear();
                    CallingGameBoard.GameBoard(gameBoard);

                    if (uzvaretajs == 1)  //uzreiz pēc spēlētāja gājiena pārbauda vai ir uzvarējis
                    {
                        

                        IShowWinner showWinner_1 = new ConsoleShowWinner_1(); //Definē mainīgo "showWinner_2" ar datu tipu "IShowWinner"

                        showWinner_1.Show(player1.Name, player1.Simbols);

                        break;
                    }

                    if (i == 9)
                    // kad būs veikti 9 gājieni, bet vēl nebūs noteikt uzvarētājs, tad rezultāts būs neizšķirts.
                    // Pirmajam spēlētājam sanāk par vienu gājienu vairāk, tāpēc šī pārbaude notiek pēc 1. spēlētāja veiktā gājiena.
                    {
                        Console.WriteLine($"Neizskirts starp spēlētāju {player1.Name} un {player2.Name}!");
                        break;
                    }

                }
                if (i % 2 != 0)
                {
                    choise = 0;
                    while (choise == 0)
                    {
                        try
                        {
                            Console.WriteLine($"{player2.Name} choose your field!");
                            choise = int.Parse(Console.ReadLine());
                            CheckWinner.CheckInput(choise);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Netika korekti ievadīts skaitlis.");

                        }
                        catch (GameBoardFieldOutOfRangeException ex)
                        {

                            Console.WriteLine(ex.Message);
                            choise = 0;
                        }

                    }





                    i++;


                    while (taken[choise - 1] != 0)
                    {
                        Console.WriteLine("Field is already taken! Choose other field! 2");
                        choise = int.Parse(Console.ReadLine());
                        continue;
                    }
                    
                    
                        gameBoard[choise - 1] = player2.Simbols;






                    taken[choise - 1] = 1;
                    
                    uzvaretajs = CheckWinner.Winner(gameBoard);
                    Console.Clear();
                    CallingGameBoard.GameBoard(gameBoard);

                    if (uzvaretajs == 1)  //uzreiz pēc spēlētāja gājiena pārbauda vai ir uzvarējis
                    {
                        

                        IShowWinner showWinner_2 = new ConsoleShowWinner_2(); //Definē mainīgo "showWinner_2" ar datu tipu "IShowWinner"

                        showWinner_2.Show(player2.Name, player2.Simbols);


                        break;
                    }


                    /*static bool Aiznemts(int choise, int choise1, string PlayerSimbol, string[] gameBoard, string player1Simbol, string player2Simbol)
                    {
                        for (int i = 2; i < gameBoard.Length - 1;)
                        {
                            if (gameBoard[choise] == player2Simbol || gameBoard[choise1] == player1Simbol) // pārbauda vai lukums jau nav aizņemts
                            {
                                Console.WriteLine("Field is already taken!");
                                Console.Write("Choose other field");
                                Console.ReadLine();
                                Console.Clear();
                                return true;
                            }
                        }
                        gameBoard[choise] = PlayerSimbol;
                        gameBoard[choise1] = PlayerSimbol;
                        return false;
                    }
                    */


                }
















            }


        }
    }
}