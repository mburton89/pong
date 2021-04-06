using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    public AudioSource collectedSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetCollected();
        Destroy(gameObject);
    }

    public abstract void GetCollected();
}
