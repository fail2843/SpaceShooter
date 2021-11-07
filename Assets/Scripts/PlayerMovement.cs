using UnityEngine;
namespace SpaceShooter
{
    internal sealed class PlayerMovement
    {
        private readonly Rigidbody2D _rigidbody;
        private readonly float _speed;
        private Vector3 _move;

        public PlayerMovement(Rigidbody2D rigidbody, float speed)
        {
            _rigidbody = rigidbody;
            _speed = speed;
        }
        public void Move(float horizontal, float vertical, float fixedDeltaTime)
        {
            var speed = fixedDeltaTime * _speed;
            _move.Set(horizontal , vertical, 0.0f);
            _rigidbody.AddForce(_move* speed);
        }
    }
}