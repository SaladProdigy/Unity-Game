using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public AnimationCurve myCurve;

    // Use this for initialization
    void Start()
    {


    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("pressing e");
                if (gameObject.activeSelf == true)
                {
                    Debug.Log("You Collected The Item");
                    gameObject.SetActive(false);
                    //turn on in inventory
                }
            }
        }
    }

}