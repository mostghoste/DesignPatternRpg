using DesignPatternRPG.GameWorld;

namespace DesignPatternRPG
{
    // Each of the tests are implemented as a separate function.
    // To test their functionality, uncomment the function call in the Main function.
    internal class Program
    {
        static void TestGameWorld()
        {
            // Create the game world
            // To showcase that it's a singleton, we create two instances of the game world
            GameWorld.GameWorld gameWorld = GameWorld.GameWorld.Instance;
            GameWorld.GameWorld otherGameWorld = GameWorld.GameWorld.Instance;

            Console.WriteLine("Printing empty map:");
            Console.WriteLine(gameWorld.RenderMap());

            // Create NPCS
            NPC npc1 = new NPC("Bob", 5, 5);
            NPC npc2 = new NPC("Alice", 0, 0);
            Console.WriteLine(npc1.Name + " is at " + npc1.X + ", " + npc1.Y);
            Console.WriteLine(npc2.Name + " is at " + npc2.X + ", " + npc2.Y);

            // Manually set tiles
            gameWorld.Map.SetTile(9, 9, '0');
            Console.WriteLine("Set tile 9, 9 to char '0'");


            Console.WriteLine("Printing tweaked map:");
            Console.WriteLine(gameWorld.RenderMap());

            // Since this is a singleton, otherGameWorld is the same as gameWorld, so it will be affected as well
            Console.WriteLine("Printing tweaked map from otherGameWorld:");
            Console.WriteLine(otherGameWorld.RenderMap());
        }
        static void Main(string[] args)
        {
            TestGameWorld();
        }
    }
}