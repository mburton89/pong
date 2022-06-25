using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Paddle paddle;
    [HideInInspector] public Ball curentBall;
    public float distanceBuffer;
    private bool _ballIsGettingCloser;

    void Update()
    {
        if (curentBall == null)
        {
            LookForNewBall();
        }
        else
        {
            DetermineIfBallIsGettingCloser();
            if (_ballIsGettingCloser)
            {
                FollowBall();
            }
        }
    }

    public void LookForNewBall()
    {
        curentBall = FindObjectOfType<Ball>();
    }

    public void DetermineIfBallIsGettingCloser()
    {
        float previousDistanceBetweenBallAndPaddle = Mathf.Abs(curentBall.previousXPosition - paddle.transform.position.x);
        float currentDistanceBetweenBallAndPaddle = Mathf.Abs(curentBall.currentXPosition - paddle.transform.position.x);

        if (currentDistanceBetweenBallAndPaddle < previousDistanceBetweenBallAndPaddle)
        {
            _ballIsGettingCloser = true;
        }
        else
        {
            _ballIsGettingCloser = false;
        }
    }

    public void FollowBall()
    {
        if (curentBall.transform.position.y > paddle.transform.position.y + distanceBuffer)
        {
            //paddle.MoveUp();
        }
        else if (curentBall.transform.position.y < paddle.transform.position.y - distanceBuffer)
        {
            //paddle.MoveDown();
        }
    }
}
