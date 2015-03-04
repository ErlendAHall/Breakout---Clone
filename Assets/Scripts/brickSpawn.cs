using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {
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
        for (int y = 0; y < bricksInY; y++)
        {
            for (int x = 0; x < bricksInX; x++)
            {
                GameObject brick = (Instantiate(prefabBrick, new Vector3(x*0.7f, y*0.5f, 0), Quaternion.identity)) as GameObject;
                brick.GetComponent<SpriteRenderer>().sprite = brickSprites[y];
            }
        }
	}
}
