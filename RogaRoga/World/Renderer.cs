using RogaRoga.Managers;

namespace RogaRoga.World
{
    internal class Renderer
    {
        private GameObjectManager gameObjectManager;

        private char[,] mapRender;
        private int width;
        private int height;

        public Renderer(GameObjectManager gameObjectManager)
        {
            this.gameObjectManager = gameObjectManager;
            width = gameObjectManager.Maze.Width;
            height = gameObjectManager.Maze.Height;
            mapRender = new char[width, height];

        }

        public void Render()
        {
            Console.Clear();
            
        }
    }
}

