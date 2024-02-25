using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogaRoga.Managers;
using RogaRoga.World;
using RogaRoga.Objects;
using System;

namespace RogaRoga.Baze
{
    internal class GameEntity : GameObject
    {
        private int hp;
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if (hp <= 0)
                {
                    Destroy();
                }
            }
        }
        public GameEntity(char symbol, Vector2 position, GameObjectManager gameObjectManager, int hp, bool passable = false)
            : base(symbol, position, gameObjectManager, passable)
        {
            Hp = hp;
            actionCounter = 0;
        }

        public int actionCounter;

        public void GetDamage(int damage)
        {
            Hp -= damage;
        }
        public override void Update()
        {
            base.Update();
            if (actionCounter > 0)
            {
                actionCounter--;
            }
        }
        public virtual void Move(Direction direction)
        {
            Vector2 newPosition;

            switch (direction)
            {
                case Direction.Up:
                    newPosition = Position + Vector2.Up;
                    break;
                case Direction.Down:
                    newPosition = Position + Vector2.Down;
                    break;
                case Direction.Left:
                    newPosition = Position + Vector2.Left;
                    break;
                case Direction.Right:
                    newPosition = Position + Vector2.Right;
                    break;
                default:
                    return;
            }
        }
    }
}
