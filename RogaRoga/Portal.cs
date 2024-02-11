using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using RogaRoga.Baze;
using RogaRoga.Managers;

namespace RogaRoga.Objects
{
    internal class Portal : GameObject // Портальчик на следующий кровень
    {
        public Portal(Vector2 position, GameObjectManager gameObjectManager) : base('O', position, gameObjectManager, true)
        {

        }
    }
}
