using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _shootPrefab;
    [SerializeField] private Transform _position;
    [SerializeField] private float _timeBetweenSpawn;
    [SerializeField] private AudioSource _shootSound;

    private float _elepsedTime = 0;

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_elepsedTime >= _timeBetweenSpawn)
        {
            _elepsedTime = 0;

            Instantiate(_shootPrefab, new Vector2(_position.position.x, _position.position.y), Quaternion.identity);
            _shootSound.Play();

        }
    }

}
