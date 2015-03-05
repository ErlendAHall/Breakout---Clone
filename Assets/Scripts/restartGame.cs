using UnityEngine;
using System.Collections;

public class restartGame : MonoBehaviour {

    public void restart()
    {
        Application.LoadLevel("mainScene");
    }
}
