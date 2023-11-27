using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.GameWorld
{
    internal class WorldMap
    {
        // The world map is a 2D array of tiles
        public char[,] _tiles;

        public WorldMap(int width, int height)
        {
            _tiles = new char[width, height];

            // Fill the map with empty tiles
            for (int y = 0; y < _tiles.GetLength(1); y++)
            {
                for (int x = 0; x < _tiles.GetLength(0); x++)
                {
                    _tiles[x, y] = '.';
                }
            }
        }

        public override string ToString()
        {
            string output = "";
            for (int y = 0; y < _tiles.GetLength(1); y++)
            {
                for (int x = 0; x < _tiles.GetLength(0); x++)
                {
                    output += _tiles[x, y];
                }
                output += "\n";
            }
            return output;
        }

        public void SetTile(int x, int y, char tile)
        {
            _tiles[x, y] = tile;
        }

        public char GetTile(int x, int y)
        {
            return _tiles[x, y];
        }
    }
}
