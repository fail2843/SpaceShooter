using UnityEngine;
namespace SpaceShooter
{
    /// <summary>
    /// Хранит данные модели игрока
    /// </summary>
    internal sealed class PlayerModel
    {
        internal float Speed { get; private set; } 
        internal float Damage { get; private set; } 
        internal Health Health { get; private set; } 
        internal Rigidbody2D Rigidbody2D { get; private set; }
        internal Transform Transform { get; private set; }

        public PlayerModel(Rigidbody2D rigidbody, Transform transform)
        {
            Speed = CharactersStats.Player.Speed;
            Damage = CharactersStats.Player.Damage;
            Health = CharactersStats.Player.Health;
            Rigidbody2D = rigidbody;
            Transform = transform;
        }
    }
}