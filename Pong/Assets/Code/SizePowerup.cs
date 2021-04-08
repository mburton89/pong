using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePowerup : Powerup
{
    public override void GetCollected()
    {
        if (FindObjectOfType<Ball>().transform.localScale.x < 201)
        {
            FindObjectOfType<Ball>().transform.localScale *= 2;
        }
    }
}
