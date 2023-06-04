using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthDisplay;
    [SerializeField] private Player _player;

    private void Start()
    {
        _healthDisplay.GetComponent<Image>();
        _healthDisplay.fillAmount = 1;
    }
    private void OnEnable()
    {
        _player.BarChanged += OnBarChanged;
    }

    private void OnDisable()
    {
        _player.BarChanged -= OnBarChanged;
    }
    private void OnBarChanged(float _barHealth)
    {
        _healthDisplay.fillAmount = _barHealth;
    }
}
