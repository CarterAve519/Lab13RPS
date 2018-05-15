using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class RoshamboApp
    {
       Player MyPlayer = new RockPlayer();
    
       public Player Choose()
       {
            int number = 0;
            

            Console.WriteLine("Which player would you like to play as? Enter 1 to play as yourself, 2 to play as Serena Williams or 3 to play as David Beckham?");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out number) || number < 1 || number > 3)
            {
                Console.WriteLine("This is not valid input. Please enter 1, 2 or 3.");
                input = Console.ReadLine();
            }
           
            if (number == 1)
            {
                Player MyThirdPlayer = new ThirdPlayer();
                return MyThirdPlayer;
            }
            else if(number == 2)
            {
                Player MyRockPlayer = new RockPlayer();
                return MyRockPlayer;
            }
            else
            {
                Player MyRandomPlayer = new RandomPlayer();
                return MyRandomPlayer;
            }


       }
    }
}
