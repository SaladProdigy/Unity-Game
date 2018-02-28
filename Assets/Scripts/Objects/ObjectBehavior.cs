using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour {

    public GameObject boxcollider;

    // Use this for initialization
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("pressing e on the drugs");
                if (gameObject.activeSelf == true)
                {
                    Debug.Log("You Collected The Item");
                    gameObject.SetActive(false);
                    GameObject.Destroy(boxcollider);

                    //turn on in inventory
                }
            }
        }
    }

}
