using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowTo : MonoBehaviour {

    public Button HTPbutton;

    public GameObject controls; // Assign in inspector
    private bool isShowing;

    // Use this for initialization
    void Start () {

        Button btn = HTPbutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
        isShowing = !isShowing;
        controls.SetActive(isShowing);
        Debug.Log("You have clicked the button!");
    }
 }
