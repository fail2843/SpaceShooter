namespace SpaceShooter
{
    internal sealed class Asteroid : EnemyObjects
    {
        private float _deathTime = 2f;
        protected override void Death()
        {
            Destroy(gameObject, _deathTime);
        }
    }
}