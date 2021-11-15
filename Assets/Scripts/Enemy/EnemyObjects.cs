using UnityEngine;
namespace SpaceShooter
{
    internal abstract class EnemyObjectsFabric : MonoBehaviour
    {
        protected Health health;
        protected float speed;
        protected float damage;
        protected float deathTime;
        protected abstract void Death();
        protected abstract void Damage();
        public static Asteroid CreateAsteroid(Transform position)
        {
            var offset = Random.Range(-5f, 5f);
            position.position += Vector3.right * offset; 

            var enemy = Instantiate(Resources.Load<Asteroid>("Asteroid"), position);
            enemy.health = CharactersStats.Asteroid.Health;
            enemy.damage = CharactersStats.Asteroid.Damage;
            enemy.speed = CharactersStats.Asteroid.Speed;

            enemy.Death();
            return enemy;
        }
        //public static EnemyShip CreateEnemyShip(Health hp, Transform position)
        //{           
        //    var enemy = Instantiate(Resources.Load<EnemyShip>("EnemyShip"), position);
        //    enemy.health = hp;
        //    return enemy;
        //}
    }
}