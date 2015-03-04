using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
	void OnGUI(){
		if (GUI.Button (new Rect (10, 10, 100, 30), "Pause")) {
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
			}
			else
			{
				Time.timeScale = 1;
			}
		}
	}
}
