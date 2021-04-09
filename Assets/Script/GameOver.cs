using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

        //Button continue
        //BUtoon ads
        // Invoke("GoHome", 2.0f);
    }

    public void GoHome() {
        //Call loadlevemanager
        FindObjectOfType<LevelLoader>().GoToHome();
    }

    public void WatchVideo() {
Debug.Log("En of conversation");
    }
   
}
