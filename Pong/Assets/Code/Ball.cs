using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float movementSpeed;
    public Vector3 direction;

    public float maxXPosition;
    public float maxYPosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBoundaries();
    }

    void Move()
    {
        transform.position += direction * movementSpeed * Time.deltaTime;
    }

    public void GetHit(Vector3 hitDirection)
    {
        direction = hitDirection;
        print(direction);
    }

    void CheckBoundaries()
    {
        if (transform.position.x > maxXPosition)
        {
            Scoreboard.Instance.GivePointToPlayer1();
            HandlePointScored(true);
        }
        else if (transform.position.x < -maxXPosition)
        {
            Scoreboard.Instance.GivePointToPlayer2();
            HandlePointScored(false);
        }

        //if (transform.position.y > maxYPosition || transform.position.y < -maxYPosition)
        //{
        //    direction = new Vector3(direction.x, -direction.y, 0);
        //}
    }

    void HandlePointScored(bool player1Scored)
    {
        Destroy(gameObject);
    }
}
