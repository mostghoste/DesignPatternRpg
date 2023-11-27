using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.CharacterCreation
{
    internal class ArcherFactory : ICharacterFactory
    {
        public Character CreateCharacter(string name)
        {
            return new Archer(name);
        }
    }
}
