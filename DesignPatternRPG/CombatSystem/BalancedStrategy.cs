using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.CombatSystem
{
    internal class BalancedStrategy : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing balanced strategy");
        }
    }
}
