using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternRPG.CharacterCreation;

namespace DesignPatternRPG.ActionControls
{
    internal class CastSpellCommand : ICommand
    {
        private Character caster;
        private Spell spell;

        public CastSpellCommand(Character caster, Spell spell)
        {
            this.caster = caster;
            this.spell = spell;
        }

        public void Execute()
        {
            spell.Cast(caster);
        }
    }
}
