using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePowerup : Powerup
{
    public override void GetCollected()
    {
        FindObjectOfType<Ball>().transform.localScale *= 4;

    }
}
