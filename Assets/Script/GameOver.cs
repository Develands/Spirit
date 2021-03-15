using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        
        Invoke("GoHome", 2.0f);
    }

    void GoHome() {
        //Call loadlevemanager
        FindObjectOfType<LevelLoader>().LoadNextLevel();
    }
   
}
