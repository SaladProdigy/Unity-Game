using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour {

    public GameObject item;
    private bool isShowing;

    // Use this for initialization
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isShowing = !isShowing;
            item.SetActive(isShowing);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}
