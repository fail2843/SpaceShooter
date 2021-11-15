namespace SpaceShooter
{
    internal sealed class Asteroid : EnemyObjectsFabric
    {
        protected override void Damage()
        {
            
        }
        protected override void Death()
        {
            Destroy(gameObject, deathTime);
        }
    }
}