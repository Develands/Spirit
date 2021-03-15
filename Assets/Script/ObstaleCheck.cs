using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaleCheck : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Obstacle") {
			Handheld.Vibrate();
        	FindObjectOfType<LevelLoader>().LoadNextLevel();
		}
	}
}
