using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    public class PlayerHuman : Player
    {
        public override void GetPlayerName()
        {
            Console.WriteLine("Ievadi savu vārdu!");
            Name = Console.ReadLine();

            while (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Vārds nevar būt tukšs. Ievadi savu vārdu vēlreiz.");
                Name = Console.ReadLine();
            }
        }

        public virtual void GetPlayerSimbol()
        {
            Console.WriteLine($"{Name} izvēlies savu simbolu X vai O ");
            //string player1Simbol = Console.ReadLine().ToUpper();

            PlayerSimbol simbol = new PlayerSimbol();

            Simbols = simbol.CheckSymbol();
            //string player2Simbol = simbol.CheckSymbol();

            
            
        }

        
    }
}
