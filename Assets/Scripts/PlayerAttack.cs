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
           //�������� ���� � �������� ����� ����������
           Debug.Log("fire");
        }       
    }
}