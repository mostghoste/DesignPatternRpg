using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

//5.Strategy Pattern - Combat System

//    Task: Use the Strategy pattern for implementing different combat strategies.
//    Elements to Include:
//        Different combat strategies (e.g., aggressive, defensive, balanced)
//        Mechanism to switch strategies during combat

namespace DesignPatternRPG.CombatSystem
{
    internal interface IStrategy
    {
        public void Execute();
    }
}
