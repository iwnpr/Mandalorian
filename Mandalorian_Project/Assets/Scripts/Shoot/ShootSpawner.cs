using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _shootPrefab;
    [SerializeField] private Transform _position;
    [SerializeField] private Player _playerPosition;
    [SerializeField] private AudioSource _shootSound;

    private void Start()
    {
        _playerPosition.GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_shootPrefab, new Vector2(_position.position.x, _playerPosition.transform.position.y), Quaternion.identity);

            _shootSound.Play();
        }
    }

}
