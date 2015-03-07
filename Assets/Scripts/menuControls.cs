using UnityEngine;
using System.Collections;

public class menuControls : MonoBehaviour {

	public void start_game () {
        Application.LoadLevel("mainScene");
	}
	
	public void exit_game () {
        Application.Quit();
	}
}
