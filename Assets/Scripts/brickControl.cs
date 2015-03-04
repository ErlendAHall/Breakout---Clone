using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class brickControl : MonoBehaviour {

    public int score = 10;
    public int health = 1;

    private Text scoreText;

    void Awake()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
