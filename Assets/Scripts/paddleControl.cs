using UnityEngine;
using System.Collections;

public class paddleControl : MonoBehaviour
{

    public float paddleSpeed = 0.5f;
    private Vector2 paddlePosition = new Vector2(0f, -4.25f);
    private float clampLenght = 7.3f;

    void Start()
    {
        transform.position = new Vector2(0, -4.25f);
    }

    void Update()
    {
        float newPosition = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        paddlePosition = new Vector2(Mathf.Clamp(newPosition, clampLenght - (clampLenght * 2), clampLenght), -4.25f);
        transform.position = paddlePosition;
    }
}
