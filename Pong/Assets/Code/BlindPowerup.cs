using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindPowerup : Powerup
{
    public override void GetCollected()
    {
        Scoreboard.Instance.BlindPlayers();
    }
}
