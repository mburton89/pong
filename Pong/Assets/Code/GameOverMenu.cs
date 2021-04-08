using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public static GameOverMenu Instance;
    [SerializeField] private GameObject _container;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button menuButton;

    private void Awake()
    {
        Instance = this;
    }

    void OnEnable()
    {
        restartButton.onClick.AddListener(RestartGame);
        menuButton.onClick.AddListener(GoToMainMenu);
    }

    void OnDisable()
    {
        restartButton.onClick.RemoveListener(RestartGame);
        menuButton.onClick.RemoveListener(GoToMainMenu);
    }

    public void Activate()
    {
        _container.SetActive(true);
    }

    public void Hide()
    {
        _container.SetActive(false);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
