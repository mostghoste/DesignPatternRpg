using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternRPG.CharacterCreation;

namespace DesignPatternRPG.ActionControls
{
    // Are spells Items? Are they Attacks? Should they have a target?
    // Should they have multiple targets? Should it depend on the spell?
    // So many questions.
    // For now, they're just going to be a thing that can be cast by a character.
    internal class Spell
    {
        public string name;
        public Spell(string name)
        {
            this.name = name;
        }
        public void Cast(Character caster)
        {
            Console.WriteLine($"{caster.name} casts {name}!");
        }
    }
}
