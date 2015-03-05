using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameController : MonoBehaviour {


    private int gameScore = 0;
    private int life = 3;
    public int bricksDestroyed = 0;
    public int bricksSpawned = 0;

    private Text scoreText;
    private Text healthText;

	// Use this for initialization
	void Start () {
        GameObject scTemp = GameObject.FindGameObjectWithTag("score");
        GameObject heTemp = GameObject.FindGameObjectWithTag("hp");
        scoreText = scTemp.GetComponent<Text>();
        healthText = heTemp.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + gameScore;
        healthText.text = "Life: " + life;
	}

    public void addScore(int score)
    {
        gameScore += score;
		
    }

    public void decreaseLife()
    {
        life--;
        if (life <= 0) {
			Application.LoadLevel ("gameOver");
		} 
    }

    public void setBricks(int bricks)
    {
        bricksSpawned = bricks;
    }

    public void destroyBrick()
    {
        bricksDestroyed++;
        audio.Play();
        if (bricksSpawned <= bricksDestroyed)
        {
           Application.LoadLevel("youWon");
        }
    }

    public void increaseHealth()
    {
        life++;
    }
}
