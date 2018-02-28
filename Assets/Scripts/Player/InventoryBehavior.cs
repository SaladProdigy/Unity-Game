using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryBehavior : MonoBehaviour {

    public Button inventory;

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    private bool isShowing;

    // Use this for initialization
    void Start () {

        Button btn = inventory.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
        isShowing = !isShowing;
        slot1.SetActive(isShowing);
        slot2.SetActive(isShowing);
        slot3.SetActive(isShowing);
        slot4.SetActive(isShowing);
        Debug.Log("You have clicked the button!");
    }

}
