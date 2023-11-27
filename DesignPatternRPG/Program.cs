namespace DesignPatternRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begining program.");
            // Create a new world map
            WorldMap map = new WorldMap(10, 10);
            map.SetTile(0, 0, 'X');

            // Print the map
            Console.WriteLine(map);

            Console.WriteLine("Ending program.");
        }
    }
}