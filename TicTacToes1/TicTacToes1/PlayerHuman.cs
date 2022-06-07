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
            Console.WriteLine("What is the name of player?");
            Name = Console.ReadLine();

            while (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                Name = Console.ReadLine();
            }
        }

        public virtual void GetPlayerSimbol()
        {
            Console.WriteLine($"{Name} choose your simbol X or O ");
            //string player1Simbol = Console.ReadLine().ToUpper();

            PlayerSimbol simbol = new PlayerSimbol();

            Simbols = simbol.CheckSymbol();
            //string player2Simbol = simbol.CheckSymbol();

            
            
        }

        
    }
}
