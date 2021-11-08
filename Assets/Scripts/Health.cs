namespace SpaceShooter
{
    internal sealed class Health
    {
        public float Max;
        public float Current;

        public Health(float max, float current)
        {
            Max = max;
            Current = current;
        }
        public void ChangeCurrentHealth(float hp)
        {
            Current += hp;
        }
    }
}