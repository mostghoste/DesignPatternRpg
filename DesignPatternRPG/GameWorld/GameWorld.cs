using DesignPatternRPG.GameWorld;
using System;
//Task: Implement the game world as a Singleton. This ensures that there is only one instance of the game world in the application.
//Elements to Include:

//    A world map
//    A list of NPCs (Non-Player Characters)
//    Global game state variables (e.g., time of day)
namespace DesignPatternRPG.GameWorld
{
    public class GameWorld
    {
        // The GameWorld singleton stored the world map, a list of NPCs, and global game state variables (e.g., time of day)
        public WorldMap Map { get; private set; }
        public List<NPC> NPCs { get; private set; }
        public int TimeOfDay { get; private set; }

        // Singleton implementation
        private static GameWorld _instance;
        public static GameWorld Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameWorld();
                }
                return _instance;
            }
        }

        // The constructor is private so that it can only be called from within the class
        private GameWorld()
        {
            Map = new WorldMap(20, 10);
            NPCs = new List<NPC>();
            TimeOfDay = 0;
        }

        // Maybe this function should be in the WorldMap class?
        // I'm putting it here because it uses both the WorldMap and NPCs list
        public static string RenderMap()
        {
            // We add NPC's on top of the map
            string output = "";
            for (int y = 0; y < Instance.Map._tiles.GetLength(1); y++)
            {
                for (int x = 0; x < Instance.Map._tiles.GetLength(0); x++)
                {
                    // Check if there is an NPC at this position
                    // Since i'm not very familiar with LINQ, here's how this works:
                    // - FirstOrDefault returns the first element in the list that returns true for the lambda expression
                    // - The argument we pass it is a lambda expression. It's an anonymous function.
                    // - n is an element of the 'NPCs' list. We define each element as n, and then we check if n's X and Y coordinates match the current X and Y coordinates.
                    // - If the condition is true, the first element matching this condition in the NPC's array is returned.
                    // - If all elements in the array return false, the default value for the type is returned. In this case, the default value for NPC is null.
                    NPC? npc = Instance.NPCs.FirstOrDefault(n => n.X == x && n.Y == y);
                    
                    if (npc != null)
                    {
                        // We render the first letter of the NPC's name
                        output += npc.Name[0];
                    }
                    else
                    {
                        output += Instance.Map._tiles[x, y];
                    }
                }
                output += "\n";
            }
            return output;
        }
    }
}