using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TicTacToes1
{
    internal class Game
    {
        public void Start()
        {
            //Console.WriteLine("The Game is starting!");
            //ConsoleKeyInfo nospiestsTaustins = ReadKey();
            //if (nospiestsTaustins.Key == ConsoleKey.Enter)
            //{
            //    Console.WriteLine("Tu nospiedi ENTER");
            //}
            //else if (nospiestsTaustins.Key == ConsoleKey.UpArrow) // te ir iespējami arī NUm pada taustiņi
            //{
            //    Console.WriteLine("Tu nospiedi taustiņu augšā");
            //}
            //else
            //{
            //    Console.WriteLine("Tu nospiedi citu taustiņu");
            //}
            //Console.WriteLine("Press any kay to exit....");
            //Console.ReadKey(true); // nolasa taustiņu nospiešanu.


            Title = "Tic Tac Toe";

            RunMainMenu();


        }

        private void RunMainMenu()
        {

            string promt = @"


  _______   _            _______                    _______                
 |__   __| (_)          |__   __|                  |__   __|               
    | |     _    ___       | |      __ _    ___       | |      ___     ___ 
    | |    | |  / __|      | |     / _` |  / __|      | |     / _ \   / _ \
    | |    | | | (__       | |    | (_| | | (__       | |    | (_) | |  __/
    |_|    |_|  \___|      |_|     \__,_|  \___|      |_|     \___/   \___|
                                                                           
                                                                           

Sveicināti spēlē Tic Tac Toe! Kā vēlies spēlēt?
(Lietojiet bultiņas, lai izvēlētos un apstipriniet ar taustiņu Enter!)



            ";

            string[] options = { "  Spēlēt pret otru spēlētāju  ", "  Spēlēt pret datoru  ", "  Par spēles radītājiem  ", "  Iziet no spēles  " };
            Menu galvenaIzvele = new Menu(promt, options);
            int SelectedIndex = galvenaIzvele.Run(); // šis atgriezīs skaitli kad spēlētājs izvēlēsies kaut ko no izvēles

            switch (SelectedIndex)
            {
                case 0:
                    SpeletArOtruSpeletaju();
                    break;
                case 1:
                    SpeletPretDatoru();
                    break;
                case 2:
                    ParSpelesRaditajiem();
                    break;
                case 4:
                    IzietNoSpeles();
                    break;
                    //default:
                    //    break;


            }


        }

        private void IzietNoSpeles()
        {
            Clear();
            Console.WriteLine("\nNospied jebkuru taustiņu lai izietu no spēles"); // ko nozīmē \n Nesprotu!
            ReadKey(true);
            //Environment.Exit(0);
        }
        private void SpeletArOtruSpeletaju()
        {
            Clear();
            GAMEBOARD spelesLaukums = new GAMEBOARD();
            spelesLaukums.gameBoard();






            Console.WriteLine("Vieta kur ievietot spēli!");
            Console.ReadLine();

        }
        private void SpeletPretDatoru()
        {
            Console.WriteLine("Vieta kur spēlet pret datoru");
        }
        private void ParSpelesRaditajiem()
        {

            Clear();
            Console.WriteLine(@"


  _______   _            _______                    _______                
 |__   __| (_)          |__   __|                  |__   __|               
    | |     _    ___       | |      __ _    ___       | |      ___     ___ 
    | |    | |  / __|      | |     / _` |  / __|      | |     / _ \   / _ \
    | |    | | | (__       | |    | (_| | | (__       | |    | (_) | |  __/
    |_|    |_|  \___|      |_|     \__,_|  \___|      |_|     \___/   \___|
                                                                           
                                                                           
            
           




Info par spēles veidotājiem!");
            Console.WriteLine("Izmantoti materiāli: https://www.youtube.com/watch?v=qAWhGEPMlS8&list=PLFH_Z9a3ZgxD3poSv3DcXWq0yxrqc3L3_&index=3&t=2s ");
            Console.WriteLine("https://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20");
            ReadKey(true);
            RunMainMenu();
        }
    }



}
