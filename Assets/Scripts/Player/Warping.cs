using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warping : MonoBehaviour {

    public GameObject goTo;
    public GameObject player;
    public Button Place;

    // Use this for initialization
    void Start () {

        Button btn = Place.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
        Debug.Log("Clicked");
        player.transform.position = goTo.transform.position;

    }

    
   
}
