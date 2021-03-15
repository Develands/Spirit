using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
    
    public Dialogue dialogue;
    
    public Animator animator;
    public Animator textAnimator;

    private Queue<string> sentences;

    public Text dialogueText;
    // Start is called before the first frame update
    void Start() {
        sentences = new Queue<string>();
        textAnimator.SetBool("IsStart", true);

        //init dialog after 1 seconds
        Invoke("InitDialog", 1f);
    }

    void InitDialog() {
        StartDialogue(dialogue);
    }
    
    public void StartDialogue(Dialogue dialogue) {

        animator.SetBool("IsOpen", true);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (sentences.Count == 0) {
            NextScene();
            return;
        }

        string sentence = sentences.Dequeue();
        
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence ( string sentence) {
        dialogueText.text = "";

        foreach ( char letter in sentence.ToCharArray()) {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void NextScene() {
        animator.SetBool("IsOpen", false);
        Debug.Log("En of conversation");

        //Call loadlevemanager
        FindObjectOfType<LevelLoader>().LoadNextLevel();
    }
       
}
