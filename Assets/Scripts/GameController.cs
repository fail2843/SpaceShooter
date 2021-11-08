using UnityEngine;
namespace SpaceShooter
{
    internal sealed class GameController : MonoBehaviour
    {        
        [SerializeField] private Transform _playerSpawnPoint;
        //[SerializeField] private Transform[] _enemySpawnPoints;//Временно не используется 
        [SerializeField] private Transform[] _asteroidSpawnPoints;

        [SerializeField] private float _asteroidSpeed;
        [SerializeField] private float _asteroidSpawnDelay;


        private float _timer = 0;

        private void Start()
        {
           Instantiate(Resources.Load("Player"),_playerSpawnPoint.position, Quaternion.identity);
        }
        private void Update()
        {    
            spawnAsteroidsField();//Реализовано через таймер временно. Пока что просто чтобы работало
        }
        private void spawnAsteroidsField()
        {
            _timer += Time.deltaTime;
            if (_timer >= _asteroidSpawnDelay)
            {
                var index = Random.Range(0, _asteroidSpawnPoints.Length);
                var asteroid = EnemyObjects.CreateAsteroid(new Health(50f, 50f), _asteroidSpawnPoints[index]);
                asteroid.GetComponent<Rigidbody2D>().AddForce(Vector2.down * _asteroidSpeed);
                _timer = 0;
            }
        }
    }
}