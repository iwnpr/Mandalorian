using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyTemplates;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _timeBetweenSpawn;

    private float _elepsedTime = 0;

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_elepsedTime >= _timeBetweenSpawn)
        {
            _elepsedTime = 0;

            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            int enemyPrefabNumber = Random.Range(0, _enemyTemplates.Length);

            Instantiate(_enemyTemplates[enemyPrefabNumber], _spawnPoints[spawnPointNumber]);

        }
    }
}
