using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    abstract class Player
    {
        //Defult constructor this is going to be who the computer is.
        public Player() { }

        public string PlayerName; 
        
        

        //Created abstract class and method and 2 fields using an enum generated data type
        abstract public int generateRoshambo();


    }
}
