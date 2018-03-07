using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    Vector2 floatY;
    float originalY;

    public float floatStrength;

    // Use this for initialization
    void Start()
    {

        this.originalY = this.transform.position;

    }

    void Update()
    {
        floatY = transform.position;
        floatY.y = originalY + (Mathf.Sin(Time.time) * floatStrength);
        transform.position = floatY;
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