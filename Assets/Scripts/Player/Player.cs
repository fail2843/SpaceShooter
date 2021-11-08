using UnityEngine;
namespace SpaceShooter
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Collider2D))]
    internal sealed class Player : MonoBehaviour
    {       
        [SerializeField] private float _hp;
        [SerializeField] private float _attackDamage;
        [SerializeField] private float _speed;

        
        private PlayerMovement _playerMovement;
        private InputManager _inputManager;
        private PlayerAttack _playerAttack;
        private PlayerDamage _playerDamage;

        private void Start()
        {
            _playerMovement = new PlayerMovement(GetComponent<Rigidbody2D>(), _speed);
            _inputManager = new InputManager();
            _playerAttack = new PlayerAttack(_attackDamage);
            _playerDamage = new PlayerDamage(_hp);
        }
        private void Update()
        {
            _inputManager.GetAllInput();

            if (_inputManager.fireButtonDown)            
                _playerAttack.Fire();
            
        }
        private void FixedUpdate()
        {
            _playerMovement.Move(_inputManager.horizontal, _inputManager.vertical, Time.fixedDeltaTime);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _hp = _playerDamage.GetDamage();
        }
    }
}