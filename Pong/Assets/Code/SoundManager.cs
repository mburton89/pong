using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource serve;
    public AudioSource win;
    public AudioSource ballDestroy;
    public AudioSource hit;
    public AudioSource collect;

    void Awake()
    {
        Instance = this;
    }
}
