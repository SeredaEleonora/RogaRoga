using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using RogaRoga.Baze;

namespace RogaRoga.World
{
    internal class Map
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        private char[,] mapData;

        private readonly Random random = new Random();

        public Map(int width = 50, int height = 25)
        {
            Width = width;
            Height = height;
            mapData = new char[width, height];

            GenerateMap();
        }
        public void GenerateMap()
        {

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    mapData[i, j] = '#';
                }
            }

            int numRooms = random.Next(6, 12);
            Room[] rooms = new Room[numRooms];

            for (int i = 0; i < numRooms; i++)
            {
                int roomWidth = random.Next(4, 11);
                int roomHeight = random.Next(4, 11);


                int roomX = random.Next(1, Width - roomWidth - 1);
                int roomY = random.Next(1, Height - roomHeight - 1);

                Room newRoom = new Room { X = roomX, Y = roomY, Width = roomWidth, Height = roomHeight };

                bool intersects = false;

                for (int j = 0; j < i; j++)
                {
                    Room otherRoom = rooms[j];

                    if (otherRoom != null &&
                        newRoom.X < otherRoom.X + otherRoom.Width &&
                        newRoom.X + newRoom.Width > otherRoom.X &&
                        newRoom.Y < otherRoom.Y + otherRoom.Height &&
                        newRoom.Y + newRoom.Height > otherRoom.Y)
                    {
                        intersects = true;
                        break;
                    }
                }

                if (intersects)
                {
                    i--;
                    continue;
                }

                DrawRoom(newRoom);
                rooms[i] = newRoom;

            }

            for (int i = 0; i < rooms.Length - 1; i++)
            {
                if (rooms[i] != null && rooms[i + 1] != null)
                {
                    Room startRoom = rooms[i];
                    Room endRoom = rooms[i + 1];

                    int startX = random.Next(startRoom.X, startRoom.X + startRoom.Width);
                    int startY = random.Next(startRoom.Y, startRoom.Y + startRoom.Height);

                    int endX = random.Next(endRoom.X, endRoom.X + endRoom.Width);
                    int endY = random.Next(endRoom.Y, endRoom.Y + endRoom.Height);

                    DrawCorridor(startX, startY, endX, endY);
                }
            }

            int portalRoomIndex = random.Next(0, numRooms);
            Room portalRoom = rooms[portalRoomIndex];
            int portalX = random.Next(portalRoom.X + 1, portalRoom.X + portalRoom.Width - 1);
            int portalY = random.Next(portalRoom.Y + 1, portalRoom.Y + portalRoom.Height - 1);

        }

        public void DrawRoom(Room room)

        {

            for (int i = room.X; i < room.X + room.Width; i++)
            {
                for (int j = room.Y; j < room.Y + room.Height; j++)
                {
                    mapData[j, i] = ' ';
                }
            }
        }

        public void DrawCorridor(int startX, int startY, int endX, int endY)
        {

            for (int x = Math.Min(startX, endX); x <= Math.Max(startX, endX); x++)
            {
                mapData[startY, x] = ' ';
            }


            for (int y = Math.Min(startY, endY); y <= Math.Max(startY, endY); y++)
            {
                mapData[y, endX] = ' ';
            }
        }
        public char[,] GetMapData()
        {
            return mapData;
        }
    }
}

