using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogaRoga.Managers;

namespace RogaRoga.Baze
{
    internal class GameObject
    {
        public Vector2 Position
        {
            get
            {
                return _position;
            }
            set
            {
                PrePosition = _position;
                _position = value;
            }
        }
        public GameObject(string symbol, Vector2 position, GameObjectManager _gameObjectManager, bool passable)
        {
            Symbol = symbol;
            Position = position;
            Passable = passable;
            PrePosition = new Vector2(_position.X, _position.Y);
            gameObjectManager = _gameObjectManager;

        }
        public Vector2 _position;
        public Vector2 PrePosition { get; set; }
        public GameObjectManager gameObjectManager { get; set; }
        public bool Passable { get; set; }
        public string Symbol { get; set; }
        public event Action<GameObject> OnDestroy;
        public event Action<GameObject, Vector2> OnMove;
        public virtual void Update()
        {
        }
        protected virtual void Destroy()
        {

        }

    }
}
