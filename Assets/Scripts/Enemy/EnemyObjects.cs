using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceShooter
{
    internal abstract class EnemyObjects : MonoBehaviour
    {
        public Health Health;
        public static Asteroid CreateAsteroid(Health hp, Transform position)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Asteroid"), position);
            enemy.Health = hp;
            return enemy;
        }  
    }
}