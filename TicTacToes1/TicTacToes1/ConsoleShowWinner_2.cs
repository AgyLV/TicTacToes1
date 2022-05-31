using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    public class ConsoleShowWinner_2 : IShowWinner
    {
        public void Show(string playerName, string playerSimbol)
        {
            Console.WriteLine($"Winner {playerName} with symbol {playerSimbol} !!!");
        }
    }
}
