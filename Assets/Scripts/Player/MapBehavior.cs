using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapBehavior : MonoBehaviour {

    public Button warp;
    public Button phone;

    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;

    public bool isShowing;

    

    void Start()
    {
        Button btn = warp.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick()
    {
        isShowing = !isShowing;
        option1.SetActive(isShowing);
        option2.SetActive(isShowing);
        option3.SetActive(isShowing);
        option4.SetActive(isShowing);
        Debug.Log("You have clicked the button!");

        if(isShowing == true)
        {
            isShowing = false;
        }

        //try adding feedback loop
        
    }
}
