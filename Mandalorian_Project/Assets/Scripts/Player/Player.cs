using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    private float _barHealth = 1;

    public event UnityAction<int> HealthChanged;
    public event UnityAction<float> BarChanged;
    public event UnityAction Died;

    private void Start()
    {
        HealthChanged?.Invoke(_health);
        BarChanged?.Invoke(_barHealth);
    }

    public void TakeDamage(int damage)
    {
        _health = _health - damage;
        _barHealth = _barHealth - 0.1f;

        HealthChanged?.Invoke(_health);
        BarChanged?.Invoke(_barHealth);

        if (_health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Died?.Invoke();
    }



}
