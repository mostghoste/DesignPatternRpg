using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.CharacterCreation
{
    internal class WarriorFactory : ICharacterFactory
    {
        public Character CreateCharacter(string name)
        {
            return new Warrior(name);
        }
    }
}
