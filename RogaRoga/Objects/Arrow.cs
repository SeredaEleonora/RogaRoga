using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogaRoga.Baze;
using RogaRoga.Managers;

namespace RogaRoga.Objects
{
    internal class Arrow : GameObject
    {
        public Arrow(Vector2 startPosition, GameObjectManager gameObjectManager, bool passable, char symbol = '-')
            : base(symbol, startPosition, gameObjectManager, true)
        {
        }
    }
}

