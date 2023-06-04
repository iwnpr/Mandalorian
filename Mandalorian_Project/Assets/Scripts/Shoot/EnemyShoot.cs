using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.TakeDamage(_damage);
            Die();
        }
        if (collision.name=="Destroyer")
        {
            Die();
        }


    }

    private void Die()
    {

        Destroy(gameObject);
    }
}
