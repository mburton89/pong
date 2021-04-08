using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static MainMenu Instance;
    [SerializeField] private Button _twoPlayersButton;
    [SerializeField] private Button _onePlayerButton;
    [SerializeField] private Button _zeroPlayerButton;

    private void Awake()
    {
        Instance = this;
    }

    void OnEnable()
    {
        _twoPlayersButton.onClick.AddListener(StartForTwoPlayers);
        _onePlayerButton.onClick.AddListener(StartForOnePlayer);
        _zeroPlayerButton.onClick.AddListener(StartForZeroPlayers);
    }

    void OnDisable()
    {
        _twoPlayersButton.onClick.RemoveListener(StartForTwoPlayers);
        _onePlayerButton.onClick.RemoveListener(StartForOnePlayer);
        _zeroPlayerButton.onClick.RemoveListener(StartForZeroPlayers);
    }

    void StartForTwoPlayers()
    {
        PlayerPrefs.SetInt("p1AI", 0);
        PlayerPrefs.SetInt("p2AI", 0);
        SceneManager.LoadScene(1);
    }

    void StartForOnePlayer()
    {
        PlayerPrefs.SetInt("p1AI", 0);
        PlayerPrefs.SetInt("p2AI", 1);
        SceneManager.LoadScene(1);
    }

    void StartForZeroPlayers()
    {
        PlayerPrefs.SetInt("p1AI", 1);
        PlayerPrefs.SetInt("p2AI", 1);
        SceneManager.LoadScene(1);
    }
}
