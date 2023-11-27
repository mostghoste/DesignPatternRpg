using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.CharacterCreation
{
    internal interface ICharacterFactory
    {
        Character CreateCharacter(string name);
    }
}
