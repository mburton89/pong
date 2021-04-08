using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePowerup : Powerup
{
    public float sizeMultiplier;

    public override void GetCollected()
    {
        IncreaseSizeOfBall();
    }

    void IncreaseSizeOfBall()
    {
        if (FindObjectOfType<Ball>().transform.localScale.x < 201)
        {
            FindObjectOfType<Ball>().transform.localScale *= sizeMultiplier;
        }
    }
}
