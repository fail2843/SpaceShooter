using UnityEngine;
namespace SpaceShooter
{
    internal abstract class EnemyObjects : MonoBehaviour
    {
        protected Health Health;
        protected float Speed;

        protected abstract void Death();
        public static Asteroid CreateAsteroid(Health hp, Transform position)
        {
            var offset = Random.Range(-5f, 5f);
            position.position += Vector3.right * offset; 

            var enemy = Instantiate(Resources.Load<Asteroid>("Asteroid"), position);
            enemy.Health = hp;
            enemy.Death();
            return enemy;
        }
        public static EnemyShip CreateEnemyShip(Health hp, Transform position)
        {           
            var enemy = Instantiate(Resources.Load<EnemyShip>("EnemyShip"), position);
            enemy.Health = hp;
            return enemy;
        }
    }
}