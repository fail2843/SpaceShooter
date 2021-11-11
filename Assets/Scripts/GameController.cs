using UnityEngine;
namespace SpaceShooter
{
    internal sealed class GameController : MonoBehaviour
    {
        [SerializeField] private Transform _playerSpawnPoint;
        
        [SerializeField] private Transform[] _asteroidSpawnPoints;
        [SerializeField] private float _asteroidSpeed;
        [SerializeField] private float _asteroidSpawnDelay;

        [SerializeField] private Transform _enemySpawnPoint;
        [SerializeField] private float _enemyShipSpeed;
        [SerializeField] private int _maxEnemyShips;

        //private HealthList _healthList;
        private float _timer = 0;
        private int _amountActiveEnemyShips = 0;
        private void Start()
        {        
            Instantiate(Resources.Load("Player"),_playerSpawnPoint.position, Quaternion.identity);
        }
        private void Update()
        {    
            spawnAsteroidsField();//Реализовано через таймер временно. Пока что просто чтобы работало
            //spawnEnemyShips();
        }
        private void spawnAsteroidsField()
        {
            _timer += Time.deltaTime;
            if (_timer >= _asteroidSpawnDelay)
            {
                var index = Random.Range(0, _asteroidSpawnPoints.Length);
                var asteroid = EnemyObjects.CreateAsteroid(HealthList.Asteroid, _asteroidSpawnPoints[index]);
                asteroid.GetComponent<Rigidbody2D>().AddForce(Vector2.down * _asteroidSpeed * Time.fixedDeltaTime);
                _timer = 0;
            }
        }
        private void spawnEnemyShips()
        {
            //Было написано для проверки. Механизм создания противника будет переписан
            if (_amountActiveEnemyShips < _maxEnemyShips)
            {
                var enemy = EnemyObjects.CreateEnemyShip(HealthList.EnemyShip, _enemySpawnPoint);
                enemy.GetComponent<Rigidbody2D>().AddForce(Vector2.down * _enemyShipSpeed * Time.fixedDeltaTime);
                _amountActiveEnemyShips++;
            }
        }
    }
}