using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public Animator transition;

    public float transitionTime = 1f;

    private int numberScene = 3;

    public void LoadNextLevel() {

        int nextLavel = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextLavel == numberScene) {
            nextLavel = 0;
        }

        StartCoroutine(LoadLevel(nextLavel));
    }

    public void GoToHome()
    {     
        StartCoroutine(LoadLevel(0));
    }

    public void GoToGamePlay()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void GoToCredits()
    {
        StartCoroutine(LoadLevel(3));
    }

    public void GoToGameOver()
    {
        StartCoroutine(LoadLevel(2));
    }

    public void GoToHowToPlay() {
        StartCoroutine(LoadLevel(4));
    }

    IEnumerator LoadLevel(int levelIndex) {

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }


}
