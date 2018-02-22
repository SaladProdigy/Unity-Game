using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetObject : MonoBehaviour
{


    public bool questStart = false;
    public bool items = false;
    private bool isShowing;

    public GameObject drugs; // Assign in inspector


    // Use this for initialization
    void Start()
    {

        if (questStart == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isShowing = !isShowing;
                drugs.SetActive(isShowing);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                questStart = true;
                Debug.Log("Quest has begun");
                }
            }
        }
    }

