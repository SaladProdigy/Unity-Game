using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequence : MonoBehaviour {

    public Sprite[] backgrounds;
    public string[] texts;
    public Button continueB;

    SpriteRenderer backgroundSpriteRenderer;
    public Text introText;
    public GameObject textBox;

    int sequenceNumber = 0;

	void Start () {
        SetSequence(sequenceNumber);
        Button btn = continueB.GetComponent<Button>();
        backgroundSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        btn.onClick.AddListener(TaskOnClick);
    }
    
    public void TaskOnClick ()
    {
        Debug.Log("Clicked");

        sequenceNumber++;
        if (sequenceNumber >= backgrounds.Length)
        {
            Debug.Log("Onto game");
            // load start of game
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        else
        {
            Debug.Log("Next Sequence");
            SetSequence(sequenceNumber);
        }
    }

    void SetSequence (int sequenceNumber)
    {
        Debug.Log("Start sequence");
 
            introText.text = texts[sequenceNumber];
           
      
            Debug.Log(sequenceNumber);

            backgroundSpriteRenderer.sprite = backgrounds[sequenceNumber];
        
            
 
       

    }
}
