using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.CharacterCreation
{
    internal class Archer : Character
    {
        // Base Archer stats as constants:
        private static readonly int BaseHealth = 75;
        private static readonly int BaseMana = 30;
        private static readonly int BaseStrength = 7;
        private static readonly int BaseDefense = 12;

        // The Archer class inherits from the character class and uses the base constructor of the character class
        public Archer(string name) : base(name, BaseHealth, BaseMana, BaseStrength, BaseDefense)
        {
        }

        public override string ToString()
        {
            // Appends the class name to the character's stats
            // Feels like this should be passed down to the base class as well...
            // Maybe I'll change it later if it causes trouble
            return "Class: Archer\n" + base.ToString();
        }
    }
}
