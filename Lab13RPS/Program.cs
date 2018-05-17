using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            Console.WriteLine("Enter your name:");
            ThirdPlayer Yourself = new ThirdPlayer();
            Yourself.PlayerName = Console.ReadLine();

            int input = 0;
           
            
            
            while (true)
            {
                Console.WriteLine("Which player would you like to play against? Serena(1) or David(2)?");
                input = Convert.ToInt32(Console.ReadLine());


                if (input == 1)
                {
                    RockPlayer Serena = new RockPlayer();
                    Console.WriteLine("You are playing against Serena Williams!");
                    int RockHand = Serena.generateRoshambo();
                    int User = Yourself.generateRoshambo();
                    Console.WriteLine($"Serena picks {(Roshambo)RockHand} & Your pick is {(Roshambo)User}");
                

                    if ((Roshambo)RockHand == (Roshambo)User)
                    {
                        Console.WriteLine("***Draw!***");
                    }
                    else if (RockHand == 0 && User == 1)
                    {
                        Console.WriteLine("***Yay! You Win***");
                    }
                    else if (RockHand == 0 && User == 2)
                    {
                        Console.WriteLine("Sorry! You lose!");
                    }
                }
                else if (input == 2)
                {
                    RandomPlayer David = new RandomPlayer();
                    Console.WriteLine("You are playing against David Beckham!");
                    int ComputerHand = David.generateRoshambo();
                    int User = Yourself.generateRoshambo();

                    Console.WriteLine($"David picks {(Roshambo)ComputerHand} & Your pick is {(Roshambo)User}");


                    if ((Roshambo)ComputerHand == (Roshambo)User)
                    {
                        Console.WriteLine("***Draw!***");
                    }
                    else if (ComputerHand == 0 && User == 1)
                    {
                        Console.WriteLine("***Yay! You win.***");
                    }
                    else if (ComputerHand == 0 && User == 2)
                    {
                        Console.WriteLine("Sorry! You lose!");
                    }
                    else if (ComputerHand == 1 && User == 2)
                    {
                        Console.WriteLine("***Yay! You win.***");
                    }
                    else if (ComputerHand == 1 && User == 0)
                    {
                        Console.WriteLine("Sorry! You lose!");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry. That was not invalid input. Please enster 1, 2 or 3.");
                    continue;
                }

                
                
            }

            
            
            

            



        

        }


    }
}
