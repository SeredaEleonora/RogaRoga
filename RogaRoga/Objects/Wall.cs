using RogaRoga.Baze;
using RogaRoga.Managers;

namespace RogaRoga.Objects
{
    internal class Wall : GameObject
    {
        public Wall(Vector2 startPosition, GameObjectManager gameObjectManager, bool passable = false, char symbol = '#')
            : base(symbol, startPosition, gameObjectManager, false)
        {
        }
    }
}
