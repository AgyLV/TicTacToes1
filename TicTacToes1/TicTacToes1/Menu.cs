using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TicTacToes1
{
    internal class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;// parada kas tiks parādīts kā atzīme, lai mēs zinātu kurš no Options ir izvēlēts

        public Menu(string promt, string[] options)
        {
            Prompt = promt;
            Options = options;
            SelectedIndex = 0;
        }

        private void DisplayOptions() // katru reizi kad mēs notīrīsim ekrānu mēs pasauksim šo metadi
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if (i == SelectedIndex)
                {
                    prefix = ">>";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "  ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }


                Console.WriteLine($"{prefix}<< {currentOption} >>");
            }
            ResetColor();
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear(); // notīra ekrānu 
                DisplayOptions();


                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                // paziņojam kāds skaitlis liekas SlectedIndex vietā pamatojoties uz bultiņu taiustiņiem

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;

                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }

                }
            } while (keyPressed != ConsoleKey.Enter);


            return SelectedIndex;
        }




    }
}
