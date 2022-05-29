 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    
    public class PlayerSimbol
    {
       
        public string Symbol { get; set; }

        public string CheckSymbol()
        {
            bool vertiba = false;
            //string symbol;
            do
            {
                //Console.WriteLine("Izvēlies simbolu X vai O");
                string firstSimbol = Console.ReadLine();

                switch (firstSimbol)
                {
                    case "X":

                    case "x":
                        Console.WriteLine("Izveletais simbols ir X");
                        vertiba = true;
                        Symbol = "X";
                        break;
                    case "o":

                    case "O":

                    case "0":

                        Console.WriteLine("Izveletais simbols ir O");
                        vertiba = true;
                        Symbol = "O";
                        break;

                    default:
                        Console.WriteLine("Ievadi korekti simbola apzīmējumu");
                        vertiba = false;
                        break;


                }
            } while (!vertiba);

            return Symbol;
        }
        
        

    }
}
