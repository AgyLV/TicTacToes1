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

  _    _                          _        _     
 | |  | |                        | |      (_)    
 | |  | |______   ____ _ _ __ ___| |_ __ _ _ ___ 
 | |  | |_  /\ \ / / _` | '__/ _ \ __/ _` | / __|
 | |__| |/ /  \ V / (_| | | |  __/ || (_| | \__ \
  \____//___|  \_/ \__,_|_|  \___|\__\__,_| |___/
                                         _/ |    
                                        |__/     
");
            Console.WriteLine($"{playerName} ar simbolu {playerSimbol}!!!");
        }
    }
}
