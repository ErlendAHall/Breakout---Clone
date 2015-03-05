using UnityEngine;
using System.Collections;

public class brickSpawn : MonoBehaviour {
    public int bricksInX = 10;
    public int bricksInY = 6;
    public GameObject prefabBrick;
    public GameObject healthBrick;

    public Sprite[] brickSprites;

    void Awake()
    {
        brickSprites = Resources.LoadAll<Sprite>("brick");
    }

	void Start () 
    {
        GameObject.FindGameObjectWithTag("gm").GetComponent<gameController>().setBricks(bricksInX * bricksInY);
        Transform _t = GetComponent<Transform>();
        float currentY = _t.position.y;
        float currentX = _t.position.x;
        int count = 1;
        for (float y = currentY; y < currentY+bricksInY; y++)
        {
            for (float x = currentX; x < currentX+bricksInX; x++)
            {
                int ran = Random.Range(0, 50);
                GameObject brick = (Instantiate(prefabBrick, new Vector3(x * 0.7f, y * 0.5f, 0), Quaternion.identity)) as GameObject;
                if (ran > 0) { 
                    brick.GetComponent<SpriteRenderer>().sprite = brickSprites[(int)y];
                    brick.GetComponent<brickControl>().score = count*10;
                    brick.GetComponent<brickControl>().health = count;
                }
                else
                {
                    ran = Random.Range(1, 3);
                    brick.GetComponent<brickControl>().mode = ran;
                    brick.GetComponent<brickControl>().score = 100;
                    brick.GetComponent<brickControl>().health = 1;
                    if (ran == 1)
                    {
                        brick.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("healthBrick");
                    }
                    else
                    {
                        brick.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("paddlePower");
                    }
                }
            }
            count++;
        }
	}
}
