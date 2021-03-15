using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScript : MonoBehaviour {
    // Start is called before the first frame update
    
    public Text maxScoreLabel;

    void Start() {
        int score = PlayerPrefs.GetInt("score");
        
        int maxScore = PlayerPrefs.GetInt("maxScore");

        if (score > maxScore) {
            PlayerPrefs.SetInt("maxScore", score);

            maxScoreLabel.text = score.ToString() + " m";

        } else {
            maxScoreLabel.text = maxScore.ToString() + " m";
        }
    }

}
