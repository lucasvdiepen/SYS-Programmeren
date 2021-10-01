using System;

namespace RoomClass
{
    class Program
    {
        private class Tile
        {
            
        }

        private class Room
        {
            private Tile[][] tiles;

            public Room(int width, int height)
            {
                this.tiles = new Tile[height][];

                for (int i = 0; i < height; i++)
                {
                    this.tiles[i] = new Tile[width];

                    for(int j = 0; j < width; j++)
                    {
                        this.tiles[i][j] = new Tile();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Room room = new Room(10, 10);
        }
    }
}
