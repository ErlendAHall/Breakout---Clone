using UnityEngine;
using System.Collections;

public class paddleControl : MonoBehaviour
{

    public float paddleSpeed = 0.5f;
    private Vector2 paddlePosition = new Vector2(0f, -4.25f);
    private float clampLenght = 6.8f;

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

    public void decreaseScale()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y, transform.localScale.z);
        clampLenght += 0.6f;
    }

    public void increaseScale()
    {
        transform.localScale = new Vector3(transform.localScale.x + 0.25f, transform.localScale.y, transform.localScale.z);
        clampLenght -= 0.2f;
    }
}
