using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float verticalMovementSpeed;
    public float maxYPosition;
    public KeyCode _upKey;
    public KeyCode _downKey;
    public int ballhitXDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(_upKey) && transform.position.y < maxYPosition)
        {
            MoveUp();
        }
        else if (Input.GetKey(_downKey) && transform.position.y > -maxYPosition)
        {
            MoveDown();
        }
    }

    public void MoveUp()
    {
        transform.position += Vector3.up * verticalMovementSpeed * Time.deltaTime;
    }

    public void MoveDown()
    {
        transform.position += Vector3.down * verticalMovementSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            float yHitDirection = (collision.transform.position.y - transform.position.y) * 4;
            print(yHitDirection);
            Vector3 hitDirection = new Vector3(ballhitXDirection, yHitDirection, 0);
            collision.gameObject.GetComponent<Ball>().GetHit(hitDirection);
        }
    }
}
