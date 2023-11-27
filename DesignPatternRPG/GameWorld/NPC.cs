using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.GameWorld
{
    public class NPC
    {
        // The NPC class stores the name and position of the NPC
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        // The constructor takes the name and position of the NPC
        public NPC(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;

            // Add the NPC to the list of NPCs in the game world
            GameWorld.Instance.NPCs.Add(this);
        }

        // The Move method moves the NPC to a new position
        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
