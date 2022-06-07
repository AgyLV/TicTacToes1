using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToes1
{
    public class Player
    {
        public string Name { get; set; }

        public string Simbols { get; set; }

        public virtual void GetPlayerName()
        {
            Console.WriteLine("Tā ir base metode");
           
        }

        public virtual void GetPlayerSimbol()
        {
            Console.WriteLine("Bāzes simbols ir X ");
            
        }


    }
}
