using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _healthDisplayText;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }
    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }
    private void OnHealthChanged(int health)
    {
        _healthDisplayText.text = health.ToString() + "%";
    }

}
