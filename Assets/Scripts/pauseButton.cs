using UnityEngine;
using System.Collections;

public class pauseButton : MonoBehaviour {
	void OnGUI(){
		if(GUI.Button (new Rect (Screen.width/2 - 50, Screen.height/2 - 320, 50, 30), "Pause")){
			if(Time.timeScale == 1)
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
