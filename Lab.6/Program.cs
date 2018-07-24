using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._6
{
    class Program
    {
        static void Main(string[] args)

        {
            string input2 = "";
            do
            {
                Console.WriteLine("Welcome to DeMarko Dice game!!!!!");
                Console.Write("Enter the name of Player 1: ");
                string Player = Console.ReadLine();
                Console.Write("Enter the name of Player 2: ");
                string Player2 = Console.ReadLine();

                Random DiceRandom = new Random();
                int DiceThrow1 = 0;
                int DiceThrow2 = 0;

                //DiceThrow1 = DiceRandom.Next(1, 7);
                //DiceThrow2 = DiceRandom.Next(1, 7);

                bool input1 = true;
                while (input1)
                {
                    if (DiceThrow2 >= 20)
                    {
                        input1 = false;
                        Console.WriteLine($"{Player2} Congrats you have beat {Player}. Better luck next time.");

                    }
                    else if ((DiceThrow1 >= 20))
                    {
                        input1 = false;
                        Console.WriteLine($"{Player} Congrats you have beat {Player2}. Better luck next time.");

                    }
                    else
                    {
                        int throw1 = DiceRandom.Next(1, 7);
                        int throw2 = DiceRandom.Next(1, 7);

                        DiceThrow1 += throw1;
                        DiceThrow2 += throw2;
                        Console.WriteLine($"{Player} rolled a {DiceThrow1} \n{Player2} rolled a {DiceThrow2}");


                    }
                    Console.ReadLine();
                }
                Console.WriteLine("Would you like to play agian? Yes or No.");
                input2 = Console.ReadLine();
            } while (input2 == "Yes");



        }
    }
}
