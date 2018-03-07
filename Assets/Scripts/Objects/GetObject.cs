using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetObject : MonoBehaviour
{

    bool hasNeededObject = false;

    public GameObject neededObject;
    public GameObject inventoryObject;

    NPCDialogueHolder npcDialogueHolder;
    PlayerInventory inventory;
    CheckObject checkObject;


    public string[] hasNeededObjectDialogueNPC;
    public string[] doesNotHaveNeededObjectDialogueNPC;

    public string[] hasNeededObjectDialoguePLAYER;
    public string[] doesNotHaveNeededObjectDialoguePLAYER;


    // Use this for initialization
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
        npcDialogueHolder = GetComponent<NPCDialogueHolder>();
        checkObject = GetComponent<CheckObject>();
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
                Debug.Log("E is pressed");

                if (GameObject.Find("Random_1").GetComponent <CheckObject> ().questStart)
                {
                    Debug.Log("Stuff is happening");

                    if (inventoryObject.activeSelf == false)
                    {
                        for (int i = 0; i < inventory.inventoryObjects.Count; i++)
                        {
                            if (inventory.inventoryObjects[i] == neededObject)
                            {
                                hasNeededObject = true;
                                inventory.inventoryObjects.RemoveAt(i);
                            }
                        }
                        Debug.Log("Has Object");
                        inventoryObject.SetActive(true);
                        inventory.inventoryObjects.Add(inventoryObject);
                    }

                    if (hasNeededObject)
                    {
                        Debug.Log("HAS OBJECT");

                        npcDialogueHolder.npcdialogueSequence = hasNeededObjectDialogueNPC;
                        npcDialogueHolder.playerdialogueSequence = hasNeededObjectDialoguePLAYER;

                    }
                    else
                    {
                        Debug.Log("DOESN'T HAVE OBJECT");
                        npcDialogueHolder.npcdialogueSequence = doesNotHaveNeededObjectDialogueNPC;
                        npcDialogueHolder.playerdialogueSequence = doesNotHaveNeededObjectDialoguePLAYER;
                    }
                }
              
            }
        }
    }

    /*Put CheckObject on Jeffery and this code onto Wolfman. Quest needs to start with Jeffery, wolfman needs to give you the object and then after getting the object,
        the collider on JEffery (make that a child) needs to be destroyed*/
}

