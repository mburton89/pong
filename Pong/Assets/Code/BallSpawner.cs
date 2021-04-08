using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public static BallSpawner Instance;

    public Ball ballPrefab;
    public int serveXDirection;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        int rand = Random.Range(0, 10);
        if (rand < 5)
        {
            serveXDirection = -1;
        }
        else
        {
            serveXDirection = 1;
        }
        DelayServe(serveXDirection);
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    ServeBall();
        //}
    }

    public void ServeBall()
    {
        Ball newBall = Instantiate(ballPrefab);
        newBall.direction = new Vector3(serveXDirection, Random.Range(-0.2f, 0.2f), 0);
        SoundManager.Instance.serve.Play();
    }

    public void DelayServe(int newServeXDirection)
    {
        StartCoroutine(DelayServeCo(newServeXDirection));
    }

    private IEnumerator DelayServeCo(int newServeXDirection)
    {
        yield return new WaitForSeconds(2);
        serveXDirection = newServeXDirection;
        ServeBall();
    }
}
