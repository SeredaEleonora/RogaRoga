using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using RogaRoga.Baze;
using RogaRoga.Managers;
using RogaRoga.Objects;

namespace RogaRoga.World
{
    internal class Maze
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Vector2 EndPosition { get; private set; }
        private GameObjectManager gameObjectManager;

        private char[,] MazeData;
        public List<Wall> Walls { get; private set; }

        private readonly Random random = new Random();
        public Maze(GameObjectManager gameObjectManager, int width = 50, int height = 50)
        {
            Width = width;
            Height = height;
            MazeData = new char[width, height];
            this.gameObjectManager = gameObjectManager;
            Walls = new List<Wall>();

            GenerateMaze();
        }
        public void GenerateMaze()
        {
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    // С вероятностью 30% устанавливаем стену, чтобы сделать их более широкими
                    if (random.Next(0, 10) < 3)
                    {
                        CreateWall(new Vector2(row, col)); // Стена
                    }
                }
            }

            PlacePortal();
        }
        private void CreateWall(Vector2 position)
        {
            Wall wall = new Wall(position, gameObjectManager);
            Walls.Add(wall);
            gameObjectManager.RegisterGameObject(wall);
        }

        public Vector2 RandomPositionGenerator()
        {
            while (true)
            {
                Vector2 randomPosition = new Vector2(random.Next(1, Width), random.Next(1, Height));

                if (gameObjectManager.IsPlaceFree(randomPosition) == true)
                {
                    return randomPosition;
                }

            }
        }
        public void PlacePortal()
        {
            Vector2 PortalPosition = RandomPositionGenerator();
            gameObjectManager.DestroyGameObject(gameObjectManager.GetGameObjectAtPosition(PortalPosition));
            Portal portal = new Portal(PortalPosition, gameObjectManager);
            gameObjectManager.RegisterGameObject(portal);
        }

        public char[,] GetMazeData()
        {
            return MazeData;
        }
    }
}

