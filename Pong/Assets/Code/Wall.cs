using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            HitBall(collision.gameObject.GetComponent<Ball>());
        }
    }

    void HitBall(Ball ball)
    {
        Vector3 hitDirection = new Vector3(ball.direction.x, -ball.direction.y, 0);
        ball.GetHit(hitDirection);
    }
}
