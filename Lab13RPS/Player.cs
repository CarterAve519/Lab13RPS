using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    abstract class Player
    {
        private string name;
        private Roshambo game;

        public string Name { get; set; }
        public Roshambo Game { get; set; }
        

        //Created abstract class and method and 2 fields using an enum generated data type
        abstract public Roshambo generateRashambo();
    }
}
