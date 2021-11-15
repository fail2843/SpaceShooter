namespace SpaceShooter
{

    internal sealed class EnemyShip:EnemyObjectsFabric
    {
        protected override void Death() => Destroy(gameObject);
        protected override void Damage()
        {

        }
        
    }
}