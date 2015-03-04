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
        Transform _t = GetComponent<Transform>();
        int currentY = (int)_t.position.y;
        int currentX = (int)_t.position.x;
        for (int y = currentY; y < currentY+bricksInY; y++)
        {
            for (int x = currentX; x < currentX+bricksInX; x++)
            {
                GameObject brick = (Instantiate(prefabBrick, new Vector3(x*0.7f, y*0.5f, 0), Quaternion.identity)) as GameObject;
                brick.GetComponent<SpriteRenderer>().sprite = brickSprites[y];
            }
        }
	}
}
