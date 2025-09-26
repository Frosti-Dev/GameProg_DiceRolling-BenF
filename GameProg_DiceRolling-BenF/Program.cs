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
        static int bet = 0;

        static int UserInput()
        {
            while (true)
            {
                string BettingAmount = Console.ReadLine();
                int BetasInt = int.Parse(BettingAmount);

                if (BetasInt > money)
                {
                    Console.WriteLine("You don't have that much to bet!");
                    continue;
                }

                else if (BetasInt < 0)
                {
                    Console.WriteLine("You cant bet less than zero!");
                    continue;
                }

                else
                {
                    bet = BetasInt;
                    money -= bet;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Money: ${money}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"You've bet ${bet}");
                    break;
                }


            }

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

        static int RollaDice()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            Console.WriteLine($"We rolled a {randomNumber}");
            return randomNumber;
        }

        static void game(int UserInput)
        {
            int winnings = bet * 2;

            if (UserInput == RollaDice())
            {
                Console.WriteLine($"YOU'VE WON ${winnings}");
                money = money + winnings;
            }

            else
            {
                Console.WriteLine("You've lost...");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a typical betting game!");

            Console.WriteLine("You're goal is to guess what number we rolled with our dice. If you do, you win double of what you bet!");
            Console.ReadKey(true);

            while (money > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Money: ${money}");
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Enter Betting Amount...");
                game(UserInput());
            }

            Console.WriteLine("You're broke. Go home...");
            Console.ReadLine();
        }
    }
}
