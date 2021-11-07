using UnityEngine;
namespace SpaceShooter
{
    public class PlayerDamage
    {
        private float _hp;
        public PlayerDamage(float hp)
        {
            _hp = hp;
        }
        public float GetDamage()
        {
            _hp -= 10;
            if (_hp <= 0)
                Death();
            return _hp;
        }
        private void Death()
        {
            Debug.LogWarning("I am dead");
        }
    }
}