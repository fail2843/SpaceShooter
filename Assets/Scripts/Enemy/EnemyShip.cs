using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceShooter
{

    internal sealed class EnemyShip:EnemyObjects
    {
        protected override void Death() => Destroy(gameObject);
        
    }
}