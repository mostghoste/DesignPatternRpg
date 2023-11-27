using DesignPatternRPG.CharacterCreation;
using DesignPatternRPG.GameWorld;

namespace DesignPatternRPG
{
    // Each of the tests are implemented as a separate function.
    // To test their functionality, uncomment the function call in the Main function.
    internal class Program
    {
        static void TestGameWorld()
        {
            Console.WriteLine("Testing GameWorld");
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

        static void TestCharacterCreation()
        {
            Console.WriteLine("Testing CharacterCreation");
            int choiceInt = 0;
            while (choiceInt == 0)
            {
                // Ask the user what kind of character they want to create
                Console.WriteLine("\nWhat kind of character do you want to create?");
                Console.WriteLine("1. Warrior");
                Console.WriteLine("2. Mage");
                Console.WriteLine("3. Archer");
                string? choice = Console.ReadLine();

                // Parse the input
                if (choice != null)
                {
                    // Try to parse the input with error handling
                    try
                    {
                        int tempChoiceInt = int.Parse(choice);
                        if (tempChoiceInt > 0 && tempChoiceInt <= 3)
                        {
                            choiceInt = tempChoiceInt;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Try again.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }
            }

            // Prompt for name
            Console.WriteLine("What is your character's name?");
            string? name = Console.ReadLine();
            if (name == null || name == "")
            {
                name = "Nameless";
            }

            // Select the factory based on the user's choice
            // - IDK, maybe I'm not getting the point of the factory pattern.
            // - Instead of selecting the factory here, I could just create the character itself with a
            // - character = new Warrior(name). Feels like that would be simpler.
            ICharacterFactory factory;
            switch (choiceInt)
            {
                case 1:
                    factory = new WarriorFactory();
                    break;
                case 2:
                    factory = new MageFactory();
                    break;
                case 3:
                    factory = new ArcherFactory();
                    break;
                default:
                    Console.WriteLine("Something went wrong. Defaulting to Warrior.");
                    factory = new WarriorFactory();
                    break;
            }

            // Create the character
            Character character = factory.CreateCharacter(name);

            // Print the character's stats
            Console.WriteLine("\nHere are your character's stats:");
            Console.WriteLine(character.ToString());
        }
        static void Main(string[] args)
        {
            //TestGameWorld();
            TestCharacterCreation();
        }
    }
}