using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManager : MonoBehaviour
{
    public PaddleAI p1AI;
    public PaddleAI p2AI;

    void Start()
    {
        if (PlayerPrefs.GetInt("p1AI") == 1)
        {
            p1AI.enabled = true;
        }
        else
        {
            p1AI.enabled = false;
        }

        if (PlayerPrefs.GetInt("p2AI") == 1)
        {
            p2AI.enabled = true;
        }
        else
        {
            p2AI.enabled = false;
        }
    }
}
