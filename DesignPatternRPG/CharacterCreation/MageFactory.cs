using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.CharacterCreation
{
    internal class MageFactory : ICharacterFactory
    {
        public Character CreateCharacter(string name)
        {
            return new Mage(name);
        }
    }
}
