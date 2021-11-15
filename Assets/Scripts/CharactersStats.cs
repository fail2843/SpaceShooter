namespace SpaceShooter
{
    /// <summary>
    /// Содержит статы всех сущностей в игре
    /// </summary>
    internal static class CharactersStats
    {
        internal struct Player
        {
            internal static Health Health = new Health(100f, 100f);
            internal static float Speed = 100f;
            internal static float Damage = 10f;
        }
        internal struct Asteroid
        {
            internal static Health Health = new Health(100f, 100f);
            internal static float Speed = 100f;
            internal static float Damage = 50f;
            internal static float DeathTime = 2f;
        }
        internal struct EnemyShip
        {
            internal static Health Health = new Health(100f, 100f);
            internal static float Speed = 100f;
            internal static float Damage = 10f;
        }
    }
}