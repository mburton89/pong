﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public static Scoreboard Instance;

    [HideInInspector] public int p1Score;
    [HideInInspector] public int p2Score;
    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;
    public Transform p1Paddle;
    public Transform p2Paddle;
    public GameObject blinder;
    public TextMeshProUGUI winMessage;
    public int maxScore;

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
        p1Paddle.transform.localScale /= 1.25f;
        p2Paddle.transform.localScale *= 1.25f;
        DetermineWinStatus();
        if (BallSpawner.Instance.gameObject.activeInHierarchy)
        {
            BallSpawner.Instance.DelayServe(-1);
        }
    }

    public void GivePointToPlayer2()
    {
        p2Score++;
        UpdateText();
        p1Paddle.transform.localScale *= 1.25f;
        p2Paddle.transform.localScale /= 1.25f;
        DetermineWinStatus();
        if (BallSpawner.Instance.gameObject.activeInHierarchy)
        {
            BallSpawner.Instance.DelayServe(1);
        }
    }

    void UpdateText()
    {
        PowerupSpawner.Instance.ClearPowerups();
        p1ScoreText.SetText(p1Score.ToString());
        p2ScoreText.SetText(p2Score.ToString());
        DetermineWinStatus();
    }

    void DetermineWinStatus()
    {
        if (p1Score >= maxScore)
        {
            winMessage.SetText("P1 WINS");
            HandleWin();
        }
        if (p2Score >= maxScore)
        {
            winMessage.SetText("P2 WINS");
            HandleWin();
        }
    }

    void HandleWin()
    {
        BallSpawner.Instance.gameObject.SetActive(false);
        PowerupSpawner.Instance.gameObject.SetActive(false);
        SoundManager.Instance.win.Play();
        GameOverMenu.Instance.Activate();
    }

    public void BlindPlayers()
    {
        StartCoroutine(BlindPlayersCo());
    }

    private IEnumerator BlindPlayersCo()
    {
        blinder.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        blinder.SetActive(false);
    }
}
