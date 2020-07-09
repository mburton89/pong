using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public static Scoreboard Instance;

    public int p1Score;
    public int p2Score;
    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        p1Score = 0;
        p2Score = 0;
    }

    public void GivePointToPlayer1()
    {
        p1Score++;
        UpdateText();
        BallSpawner.Instance.DelayServe(-1);
    }

    public void GivePointToPlayer2()
    {
        p2Score++;
        UpdateText();
        BallSpawner.Instance.DelayServe(1);
    }

    void UpdateText()
    {
        p1ScoreText.SetText(p1Score.ToString());
        p2ScoreText.SetText(p2Score.ToString());
    }
}
