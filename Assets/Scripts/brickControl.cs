using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class brickControl : MonoBehaviour {

    public int score = 10;
    public int health = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Scored " + score + " points");
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void setScore(int score)
    {
        this.score = score;
    }

    void setHealth(int health)
    {
        this.health = health;
    }
}
