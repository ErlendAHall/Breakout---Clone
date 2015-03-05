using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour
{

    public float ballInitSpeed = 600f;
    private float ballMaxSpeed = 15f;
    private float ballMinSpeed = 5f;
    private int bounces = 0;

    private Rigidbody2D playBall;
    private bool inPlay = false;
    private float currentSpeed = 0;
    void Awake()
    {
        playBall = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            transform.parent = null;
            inPlay = true;
            playBall.AddForce(new Vector2(ballInitSpeed, -ballInitSpeed));
        }
    }

    void FixedUpdate()
    {
        currentSpeed = Vector3.Magnitude(rigidbody2D.velocity);
        if (currentSpeed > ballMaxSpeed)
        {
            rigidbody2D.velocity /= currentSpeed / ballMaxSpeed;
        }
        if (currentSpeed < ballMinSpeed && currentSpeed != 0)
        {
            rigidbody2D.velocity /= currentSpeed / ballMinSpeed;
        }
        if (playBall.position.y < -4.25f)
        {
            GameObject.FindGameObjectWithTag("gm").GetComponent<gameController>().decreaseLife();
            transform.parent = GameObject.FindGameObjectWithTag("paddle").GetComponent<Transform>();
            transform.localPosition = new Vector2(0, 0.5f);
            playBall.velocity = Vector2.zero;
            playBall.angularVelocity = 0f;
            inPlay = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("paddle"))
        {
            bounces++;
            if (bounces == 4 || bounces == 12)
            {
                ballMinSpeed += 2f;
                ballMaxSpeed += 2f;
            }
        }
        else if (collision.collider.tag.Equals("brick") && collision.collider.GetComponent<brickControl>().score >= 50)
        {
            ballMinSpeed += 0.2f;
            ballMaxSpeed += 0.2f;
        }
    }
}
