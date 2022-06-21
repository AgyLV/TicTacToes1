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
            

            CallingGameBoard.GameBoard(gameBoard);

            PlayerHuman player1 = new PlayerHuman();
            player1.GetPlayerName();
            player1.GetPlayerSimbol();

            PlayerHuman player2 = new PlayerHuman();
            player2.GetPlayerName();

                       

            

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

            Console.WriteLine($"{player1.Name} simbols: {player1.Simbols }");
            Console.WriteLine($"{player2.Name} simbols: {player2.Simbols }");


            

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
                            Console.WriteLine($"{player1.Name} izvēlies spēles lauku!");
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

                    

                    Console.WriteLine(choise);
                    if (taken[choise - 1] != 0)
                    {
                        Console.WriteLine("Spēles lauks ir aizņemts. Izvēlies citu lauku.");
                         choise = int.Parse(Console.ReadLine());
                        continue;
                    }
                    
                        gameBoard[choise - 1] = player1.Simbols;



                    taken[choise - 1] = 1;
                    uzvaretajs = CheckWinner.Winner(gameBoard); 
                    Console.Clear();
                    CallingGameBoard.GameBoard(gameBoard);

                    if (uzvaretajs == 1)  //uzreiz pēc spēlētāja gājiena pārbauda vai ir uzvarējis
                    {
                        

                        IShowWinner showWinner_1 = new ConsoleShowWinner_1(); //Definē mainīgo "showWinner_1" ar datu tipu "IShowWinner"
                        Console.Clear();
                        showWinner_1.Show(player1.Name, player1.Simbols);

                        break;
                    }

                    if (i == 9)
                    // kad būs veikti 9 gājieni, bet vēl nebūs noteikt uzvarētājs, tad rezultāts būs neizšķirts.
                    // Pirmajam spēlētājam sanāk par vienu gājienu vairāk, tāpēc šī pārbaude notiek pēc 1. spēlētāja veiktā gājiena.
                    {
                        Console.WriteLine($"Neizšķirts starp spēlētāju {player1.Name} un {player2.Name}!");
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
                            Console.WriteLine($"{player2.Name} izvēlies spēles lauku!");
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
                        Console.WriteLine("Spēles lauks ir aizņemts. Izvēlies citu lauku.");
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
                        Console.Clear();
                        showWinner_2.Show(player2.Name, player2.Simbols);


                        break;
                    }


                    


                }
















            }


        }
    }
}