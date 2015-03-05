using UnityEngine;
using System.Collections;

public class roofScript : MonoBehaviour {

    GameObject paddle;
    bool paddleHalfed = false;

	void Start () {
        paddle = GameObject.FindGameObjectWithTag("paddle");
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!paddleHalfed)
        {
            paddleHalfed = true;
            paddle.GetComponent<paddleControl>().decreaseScale();
        }
    }
}
