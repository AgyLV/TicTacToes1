using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    public class ConsoleShowWinner_1 : IShowWinner
    {
        public void Show(string playerName, string playerSimbol)
        {
            Console.WriteLine(@"
____      ____  _                                   
|_  _|    |_  _|(_)                                  
  \ \  /\  / /  __   _ .--.   _ .--.  .---.  _ .--.  
   \ \/  \/ /  [  | [ `.-. | [ `.-. |/ /__\\[ `/'`\] 
    \  /\  /    | |  | | | |  | | | || \__., | |     
     \/  \/    [___][___||__][___||__]'.__.'[___]    
                                                     ");
            Console.WriteLine($"{playerName} with symbol {playerSimbol}!!!");
        }
    }
}
