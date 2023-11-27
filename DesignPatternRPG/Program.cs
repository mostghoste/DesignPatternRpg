using GameWorldInstance = DesignPatternRPG.GameWorld.GameWorld;

namespace DesignPatternRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begining program.");

            Console.WriteLine(GameWorldInstance.RenderMap());

            Console.WriteLine("Ending program.");
        }
    }
}