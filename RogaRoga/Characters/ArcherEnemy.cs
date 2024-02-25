using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogaRoga.Baze;
using RogaRoga.Managers;

namespace RogaRoga.Characters
{
    internal class ArcherEnemy : GameEntity
    {
        public ArcherEnemy(Vector2 startPosition, GameObjectManager gameObjectManager, char symbol = 'A', int Health = 20)
            : base(symbol, startPosition, gameObjectManager, Health, false)
        {

        }
    }
}


