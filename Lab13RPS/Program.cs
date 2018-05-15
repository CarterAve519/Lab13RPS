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
                Console.WriteLine("Which player would you like to play as? Serena(1) or David(2)?");
                input = Convert.ToInt32(Console.ReadLine());

             
                if (input == 1)
                {
                    RockPlayer Serena = new RockPlayer();
                    Console.WriteLine("You are playing as Serena Williams!");
                    Console.WriteLine($"Serena picks {(Roshambo)Serena.generateRoshambo()} Your pick is {(Roshambo)Yourself.generateRoshambo()}");
                    
                }
                else if (input == 2)
                {
                    RandomPlayer David = new RandomPlayer();
                    Console.WriteLine("You are playing as David Beckham!");
                    Console.WriteLine($"Serena picks {(Roshambo)David.generateRoshambo()} Your pick is {(Roshambo)Yourself.generateRoshambo()}");
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
