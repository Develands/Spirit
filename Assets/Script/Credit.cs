using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credit : MonoBehaviour
{    
    public void GoToHome()
    {
        Debug.Log("En of conversation");
        //Call loadlevemanager
        FindObjectOfType<LevelLoader>().GoToHome();
    }
}
