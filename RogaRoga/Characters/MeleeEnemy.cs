using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogaRoga.Baze;
using RogaRoga.Managers;

namespace RogaRoga.Characters
{
    internal class MeleeEnemy : GameEntity
    {
        public MeleeEnemy(Vector2 startPosition, GameObjectManager gameObjectManager, string symbol = "A ", int Health = 10)
            : base(symbol, startPosition, gameObjectManager, Health, false)
        {

        }
    }
}
