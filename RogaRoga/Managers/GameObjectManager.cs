using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RogaRoga.Baze;
using RogaRoga.World;

namespace RogaRoga.Managers
{
    internal class GameObjectManager
    {
        public event Action OnProtagonistDestroyed;
        public List<GameObject> GameObjects { get; private set; }

        public GameEntity Protagonist { get; private set; }

        public GameEntity[] MeleeEnemies { get; private set; }

        public GameEntity[] ArcherEnemies { get; private set; }

        public Game game { get; private set; }

        public Map map { get; private set; }

        public GameObjectManager(int meleeEnemyNumber, int archerEnemyNumber)
        {
            MeleeEnemies = new GameEntity[meleeEnemyNumber];
            ArcherEnemies = new GameEntity[archerEnemyNumber];
            GameObjects = new List<GameObject>();
        }

        public void Update()
        {
            for (int i = GameObjects.Count - 1; i >= 0; i--)
            {
                GameObject gameObject = GameObjects[i];
                gameObject.Update();
            }

            if (!GameObjects.Contains(Protagonist))
            {
                OnProtagonistDestroyed?.Invoke();
            }
        }

        public bool IsPlaceFree(Vector2 position, Map map)
        {

        }

        public void RegisterGameObject(GameObject gameObject)
        {
            GameObjects.Add(gameObject);
        }

        public void DestroyGameObject(GameObject gameObject)
        {
            GameObjects.Remove(gameObject);
        }
    }
}
