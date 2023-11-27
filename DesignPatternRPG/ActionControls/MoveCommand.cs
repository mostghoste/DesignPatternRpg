using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternRPG.CharacterCreation;

namespace DesignPatternRPG.ActionControls
{
    internal class MoveCommand : ICommand
    {
        private Character character;
        private int deltax;
        private int deltay;

        public MoveCommand(Character character, int deltax, int deltay)
        {
            this.character = character;
            this.deltax = deltax;
            this.deltay = deltay;
        }

        public void Execute()
        {
            character.Move(deltax, deltay);
        }
    }
}
