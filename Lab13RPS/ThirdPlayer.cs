using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class ThirdPlayer:Player
    {


        public ThirdPlayer()
        {
            
        }

        //What is the SW returning (picking) her choices
        public override int generateRoshambo()
        {
            while (true)
            {
                Console.WriteLine("Are you choosing Rock, Paper or Scissors? Enter R for Rock, P for Paper or S for Scissors.");
                string input = Console.ReadLine();
                if (input.ToLower() == "r")
                {
                    return 0;
                }
                else if (input.ToLower() == "p")
                {
                    return 1;
                }
                else if (input.ToLower() == "s")
                {
                    return 2;
                }
                else
                {
                    Console.WriteLine("That is not vaild. Please enter R, P or S");
                    continue;
                    
                }
                

            }
            
        }
    }
}
