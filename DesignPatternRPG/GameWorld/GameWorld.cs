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
    }

}