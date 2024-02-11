﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RogaRoga.Characters
{
    internal class ArcherEnemy : GameEntity
    {
        public ArcherEnemy(Vector2 startPosition, GameObjectManager gameObjectManager, char symbol = '>', int Health = 20)
            : base(symbol, startPosition, gameObjectManager, Health, false)
        {

        }
    }
}


