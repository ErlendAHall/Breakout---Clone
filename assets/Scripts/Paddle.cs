using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
  
    public float paddleSpeed = (float)1.0;
	private Vector3 playerPos = new Vector3(0, -9.5f, 0);
	
	void Update () {
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed / (float)3.0);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -9.5f, 9.5f), -9.5f, 0f);
		transform.position = playerPos;
       
	}

}
