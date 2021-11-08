using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceShooter
{
    internal sealed class GameController : MonoBehaviour
    {
        [SerializeField] private float _asterodSpawnDelay;
        [SerializeField] private Transform _playerSpawnPoint;
        [SerializeField] private Transform[] _enemySpawnPoints;//Временно не используется 
        [SerializeField] private Transform _asteroidSpawnPoints;
        [SerializeField] private float _asteroidRate;


        private float _timer;

        private References _references;
        private void Awake()
        {
            _references = new References();           
        }
        void Start()
        {
            _references.player = Instantiate(Resources.Load("Player"),_playerSpawnPoint.position, Quaternion.identity) as GameObject;
            var asteroid = EnemyObjects.CreateAsteroid(new Health(50f, 50f), _asteroidSpawnPoints);

        }
        void Update()
        {
           
            StartCoroutine(spawnAsteroidsField());

            Debug.LogWarning("Upd");

        }
        private IEnumerator spawnAsteroidsField()
        {
            _timer += Time.deltaTime;
            Debug.Log(_timer);
            yield return null;
        }
    }
}