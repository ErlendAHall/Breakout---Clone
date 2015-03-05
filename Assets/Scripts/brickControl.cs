using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class brickControl : MonoBehaviour {

    public int score = 10;
    public int health = 1;
	public GameObject brickParticles;

    void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        if (health <= 0)
        {
            var controller = GameObject.FindGameObjectWithTag("gm").GetComponent<gameController>();
            controller.addScore(score);
            controller.destroyBrick();
            //GameObject.FindGameObjectWithTag("gm").GetComponent<gameController>().addScore(score);
            //Debug.Log("Scored " + score + " points");
            Destroy(gameObject);
            Instantiate(brickParticles, gameObject.transform.position, Quaternion.identity);
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
