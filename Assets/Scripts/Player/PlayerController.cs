using UnityEngine;
namespace SpaceShooter
{
    /// <summary>
    /// ������������ �������������� ������� ���������� ������� 
    /// </summary>
    internal sealed class PlayerController
    { 
        private PlayerModel _playerModel;
        private PlayerMovement _playerMovement;
        private PlayerView _playerView;
        public PlayerController(PlayerView playerView)
        {
            _playerView = playerView;
            _playerModel = new PlayerModel(_playerView.Rigidbody2D, _playerView.Transform);
            _playerMovement = new PlayerMovement(_playerModel.Rigidbody2D, _playerModel.Speed);
        }
        internal void Move()
        {
            _playerMovement.Move(InputManager.Horizontal, InputManager.Vertical, Time.fixedDeltaTime, _playerModel.Speed);
        }
    }
}