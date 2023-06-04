using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            Die();
        }
        if (collision.name == "DestroyerShoots")
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
