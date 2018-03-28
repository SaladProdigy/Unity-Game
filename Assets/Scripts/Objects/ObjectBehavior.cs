using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour {

    
    public AnimationCurve myCurve;

    public GameObject invObject; 
    private bool isShowing;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
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

                    isShowing = !isShowing;
                    invObject.SetActive(isShowing);

                    //turn on in inventory
                }
            }
        }
    }

}
