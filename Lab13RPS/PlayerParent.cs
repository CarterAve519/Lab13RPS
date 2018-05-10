using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    abstract class PlayerParent
    {
        private string name;
        private Roshambo game;

        public string Name { get => name; set => name = value; }
        internal Roshambo Game { get => game; set => game = value; }

        //Created abstract class and method and 2 fields using an enum generated data type
        abstract public Roshambo generateRashambo();
    }
}
