using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBehavior : MonoBehaviour {

    public GameObject goTo;
    
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("pressing E in the doorway");
                collision.transform.position = goTo.transform.position;
            }
        }
    }
}
