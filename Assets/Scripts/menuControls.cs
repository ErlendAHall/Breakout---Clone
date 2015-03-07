using UnityEngine;
using System.Collections;

public class menuControls : MonoBehaviour {

	// Use this for initialization
	public void start_game () {
        Application.LoadLevel("mainScene");
	}
	
	// Update is called once per frame
	public void exit_game () {
        Application.Quit();
	}
}
