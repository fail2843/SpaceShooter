using UnityEngine;
namespace SpaceShooter
{
   
    internal sealed class GameController : MonoBehaviour
    {
        [SerializeField] private Transform _playerSpawnPoint;
        //[SerializeField] private Transform[] _asteroidSpawnPoints;
        //[SerializeField] private Transform _enemySpawnPoint;

        private PlayerController _playerController;

        private void Start()
        {
            Instantiate(Resources.Load("Player"), _playerSpawnPoint.position, Quaternion.identity);
            _playerController = new PlayerController(FindObjectOfType<PlayerView>());          
        }
        private void Update()
        {
            InputManager.GetAllInput();
            //spawnAsteroidsField();//Реализовано через таймер временно. Пока что просто чтобы работало
        }
        private void FixedUpdate()
        {
            _playerController.Move();
        }
        //private void spawnAsteroidsField()
        //{
        //    _timer += Time.deltaTime;
        //    if (_timer >= _asteroidSpawnDelay)
        //    {
        //        var index = Random.Range(0, _asteroidSpawnPoints.Length);
        //        var asteroid = EnemyObjects.CreateAsteroid(HealthList.Asteroid, _asteroidSpawnPoints[index]);
        //        asteroid.GetComponent<Rigidbody2D>().AddForce(Vector2.down * _asteroidSpeed * Time.fixedDeltaTime);
        //        _timer = 0;
        //    }
        //}
        //private void spawnEnemyShips()
        //{
        //    //Было написано для проверки. Механизм создания противника будет переписан
        //    if (_amountActiveEnemyShips < _maxEnemyShips)
        //    {
        //        var enemy = EnemyObjects.CreateEnemyShip(HealthList.EnemyShip, _enemySpawnPoint);
        //        enemy.GetComponent<Rigidbody2D>().AddForce(Vector2.down * _enemyShipSpeed * Time.fixedDeltaTime);
        //        _amountActiveEnemyShips++;
        //    }
        //}
    }
}