using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogaRoga.Baze;
using RogaRoga.Managers;

namespace RogaRoga.Characters
{
    internal class Protagonist : GameEntity
    {
        public int count = 0;
        public int map_level = 1;
        
        public Protagonist(Vector2 startPosition, GameObjectManager gameObjectManager, char symbol = 'P', int Health = 20)
            : base(symbol, startPosition, gameObjectManager, Health, false)
        {

        }
    }
}
