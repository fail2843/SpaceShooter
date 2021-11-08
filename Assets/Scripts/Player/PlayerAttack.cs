using UnityEngine;
namespace SpaceShooter
{
    internal sealed class PlayerAttack
    {
        private float _playerDamage;
        public PlayerAttack(float damage)
        {
            _playerDamage = damage;
        }
        public void Fire()
        { 
           //Создание пули и передача урона противнику
           Debug.Log("fire");
        }       
    }
}