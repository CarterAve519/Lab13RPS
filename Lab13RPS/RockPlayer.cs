using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13RPS
{
    class RockPlayer : Player
    {
        public RockPlayer()
        {
            PlayerName = "Serena Williams";
        }

        public object Roshambo { get; internal set; }

        public override int generateRoshambo()
        {
            return 0;
        }
    }    
}
