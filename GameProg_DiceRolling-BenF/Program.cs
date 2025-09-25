using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProg_DiceRolling_BenF
{
    class Program
    {
        //variables
        static int money = 100;

        static int UserInput()
        {
            while (true)
            {
                Console.WriteLine("Pick a number from 1 to 6...");
                string MyUserInput = Console.ReadLine();
                int InputasInt = int.Parse(MyUserInput);
                
                if (InputasInt  > 6)
                {
                    Console.WriteLine("Too High");
                    continue;
                }

                else if (InputasInt < 0)
                {
                    Console.WriteLine("Too Low");
                    continue;
                }

                else
                {
                    return InputasInt;
                }
            }
        }

        static void game(int UserInput)
        {

        }

        static void Main(string[] args)
        {
            while (money > 0)
            {
                Console.WriteLine(UserInput());
            }
        }
    }
}
