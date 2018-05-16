using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class RandomPlayer:Player
    {

        public RandomPlayer()
        {
            PlayerName = "David Beckham";
        }

        public object Roshambo { get; internal set; }

        //Method is overriding GR from the blueprint (Player.cs)
        public override int generateRoshambo()
        {
            Random rnd = new Random();
            int choice = rnd.Next(0, 2);

            return choice;
        }
       


    }
}
