using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetCollected();
        SoundManager.Instance.collect.Play();
        Destroy(gameObject);
    }

    public abstract void GetCollected();
}
