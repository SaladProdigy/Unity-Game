using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitBehavior : MonoBehaviour {

    Button exitButton;

    // Use this for initialization
    void Start () {

        exitButton = GetComponent<Button>();
        exitButton.onClick.AddListener(TaskOnClick);

    }
	
	// Update is called once per frame
	void Update () {

        

    }
    void TaskOnClick()
    {
        Application.Quit();
    }
}
