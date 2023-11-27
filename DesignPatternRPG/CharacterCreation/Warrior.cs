using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.CharacterCreation
{
    internal class Warrior : Character
    {
        // Base warrior stats as constants:
        private static readonly int BaseHealth = 100;
        private static readonly int BaseMana = 0;
        private static readonly int BaseStrength = 10;
        private static readonly int BaseDefense = 10;

        // The warrior class inherits from the character class and uses the base constructor of the character class
        public Warrior(string name) : base(name, BaseHealth, BaseMana, BaseStrength, BaseDefense)
        {
        }

        public override string ToString()
        {
            // Appends the class name to the character's stats
            // Feels like this should be passed down to the base class as well...
            // Maybe I'll change it later if it causes trouble
            return "Class: Warrior\n" + base.ToString();
        }
    }
}
