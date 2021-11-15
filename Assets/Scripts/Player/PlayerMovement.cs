using UnityEngine;
namespace SpaceShooter
{
    /// <summary>
    /// Отвечает за перемещение персонажа
    /// </summary>
    internal sealed class PlayerMovement
    {
        private readonly Rigidbody2D _rigidbody;
        private Vector3 _move;

        public PlayerMovement(Rigidbody2D rigidbody, float speed)
        {
            _rigidbody = rigidbody;
        }
        public void Move(float horizontal, float vertical, float fixedDeltaTime, float playerSpeed)
        {
              var speed = fixedDeltaTime * playerSpeed;
            _move.Set(horizontal , vertical, 0.0f);
            _rigidbody.AddForce(_move* speed);
        }
    }
}