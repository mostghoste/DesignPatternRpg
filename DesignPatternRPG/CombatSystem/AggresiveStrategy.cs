using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.CombatSystem
{
    internal class AggresiveStrategy : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing aggresive strategy");
        }
    }
}
