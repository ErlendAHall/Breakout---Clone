using UnityEngine;
using System.Collections;

public class brickSpawn : MonoBehaviour {
    public int bricksInX = 10;
    public int bricksInY = 6;
    public GameObject prefabBrick;

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
                GameObject brick = (Instantiate(prefabBrick, new Vector3(x*0.7f, y*0.5f, 0), Quaternion.identity)) as GameObject;
                brick.GetComponent<SpriteRenderer>().sprite = brickSprites[(int)y];
                brick.GetComponent<brickControl>().score = count*10;
                brick.GetComponent<brickControl>().health = count;
            }
            count++;
        }
	}
}
