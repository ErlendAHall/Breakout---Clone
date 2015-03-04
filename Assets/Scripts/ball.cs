using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour
{

    public float ballInitSpeed = 600f;

    private Rigidbody2D playBall;
    private bool inPlay = false;
    public float currentSpeed = 0;
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
        if (currentSpeed > 10f)
        {
            rigidbody2D.velocity /= currentSpeed / 10f;
        }
        if (currentSpeed < 5f && currentSpeed != 0)
        {
            rigidbody2D.velocity /= currentSpeed / 5f;
        }
        if (playBall.position.y < -4.25f)
        {
            GameObject.FindGameObjectWithTag("gm").GetComponent<gameController>().decreaseLife();
            playBall.position = new Vector2(0, -1);
        }
    }
}
