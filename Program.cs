﻿using Making_a_Die_Class;

namespace Part_1_6_Summative_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;

            //dice casino game
            Console.WriteLine("                                                                   \r\n ____  _            _____         _            _____               \r\n|    \\|_|___ ___   |     |___ ___|_|___ ___   |   __|___ _____ ___ \r\n|  |  | |  _| -_|  |   --| .'|_ -| |   | . |  |  |  | .'|     | -_|\r\n|____/|_|___|___|  |_____|__,|___|_|_|_|___|  |_____|__,|_|_|_|___|\r\n                                                                   ");
            Console.WriteLine("You will be rolling two dice, and betting on the ending of the dice. \nIf you pick the correct one you win, else you lose!");
            Console.WriteLine();
            //initial balance
            int balance = 100;
            
            //method for dice rolling
            static void RollDice()
            {
                Die die1, die2;
                die1 = new Die();
                die2 = new Die();
                die1.RollDie();
                die2.RollDie();
                Console.WriteLine("You rolled a " + die1 + " and a " + die2);
            }

            //Game start
            bool gameActive = true;
            while (gameActive)
            {
                Console.WriteLine("Your balance is: " + balance);
                Console.WriteLine("How much would you like to bet?");
                int bet = Convert.ToInt32(Console.ReadLine());
                //amount of money betting and checking if valid
                if (bet > balance)
                {
                    Console.WriteLine("You don't have enough money to bet that much!");
                    //skip and continue
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                else
                {
                    balance -= bet;
                }

                Console.Clear();

                //selecting what to bet on
                bool Betting = true;
                while (Betting)
                {
                    //what would you like to bet on?
                    Console.WriteLine("What would you like to bet on?");
                    //currentcy of bet
                    Console.WriteLine("You are currenly betting " + bet + "$");
                    Console.WriteLine("You have " + balance + "$ Left in your balance.");
                    Console.WriteLine();
                    Console.WriteLine("1. Double (If the dice roll the same number, your bet will be doubled!)");
                    Console.WriteLine("2. Not Double (If the dice does not roll the same number, your will win half of what you bet!)");
                    Console.WriteLine("3. Even Sum (If the sum of the dice is even, you will win your bet!)");
                    Console.WriteLine("4. Odd Sum (If the sum of the dice is odd, you will win your bet!)");
                    
                    string guess = Console.ReadLine();

                    if (guess == "1");
                    {
                        Console.WriteLine("You have selected to bet on a double!");
                        RollDice();
                        //if (die1 == die2)
                        //{
                        //    balance += bet * 2;
                        //    Console.WriteLine("You won " + bet * 2 + "$!");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("You lost " + bet + "$!");
                        //}
                        //Betting = false;
                        
                    }
                }

                



            }

        }
    }
}
