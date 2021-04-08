using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerup : Powerup
{
    public override void GetCollected()
    {
        FindObjectOfType<Ball>().movementSpeed *= 1.5f;
    }
}
