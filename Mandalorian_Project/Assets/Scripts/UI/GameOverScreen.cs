using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

[RequireComponent(typeof(CanvasGroup))]
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private Player _player;

    private CanvasGroup _gameOverGroup;

    private void Start()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
        _gameOverGroup.alpha = 0;
    }
    private void OnEnable()
    {
        _player.Died += OnDied;
        _restartButton.onClick.AddListener(OnRestartBottomClick);
        _quitButton.onClick.AddListener(OnQuitBottomClick);
        _mainMenuButton.onClick.AddListener(OnMainMenuBottomClick);
    }
    private void OnDisable()
    {
        _player.Died -= OnDied;
        _restartButton.onClick.RemoveListener(OnRestartBottomClick);
        _quitButton.onClick.RemoveListener(OnQuitBottomClick);
        _mainMenuButton.onClick.AddListener(OnMainMenuBottomClick);
    }
    private void OnDied()
    {
        _gameOverGroup.alpha = 1;
        Time.timeScale = 0;

    }
    private void OnRestartBottomClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    private void OnQuitBottomClick()
    {
        Application.Quit();
    }
    private void OnMainMenuBottomClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }



}
