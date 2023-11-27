using DesignPatternRPG.CharacterCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.ActionControls
{
    internal class AttackCommand : ICommand
    {
        private Character attacker;
        private Character target;

        public AttackCommand(Character attacker, Character target)
        {
            this.attacker = attacker;
            this.target = target;
        }

        public void Execute()
        {
            attacker.Attack(target);
        }
    }
}
