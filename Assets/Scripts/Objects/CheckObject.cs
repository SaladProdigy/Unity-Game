using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObject : MonoBehaviour {

    //Scripts
    PlayerInventory inventory;
    NPCDialogueHolder npcDialogueHolder;

    //Game Objects
    public GameObject desiredObject;
    public GameObject boxcollider;

    //Bools
    public bool questStart = false;
    public bool hasDesiredObject = false;
    public bool isOn;

    //Strings
    public string[] hasDesiredObjectDialogueNPC;
    public string[] doesNotHaveDesiredObjectDialogueNPC;

    public string[] hasDesiredObjectDialoguePLAYER;
    public string[] doesNotHaveDesiredObjectDialoguePLAYER;


    void Start () {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
        npcDialogueHolder = GetComponent<NPCDialogueHolder>();

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                questStart = true;
                Debug.Log("Quest has started");

                if (desiredObject.activeSelf == true)
                {
                    Debug.Log("HAS OBJECT");

                    desiredObject.SetActive(false);

                    npcDialogueHolder.npcdialogueSequence = hasDesiredObjectDialogueNPC;
                    npcDialogueHolder.playerdialogueSequence = hasDesiredObjectDialoguePLAYER;

                    GameObject.Destroy(boxcollider);
                }
                else
                {
                    Debug.Log("DOESN'T HAVE OBJECT");
                    npcDialogueHolder.npcdialogueSequence = doesNotHaveDesiredObjectDialogueNPC;
                    Debug.Log("npc talked");
                    npcDialogueHolder.playerdialogueSequence = doesNotHaveDesiredObjectDialoguePLAYER;
                    Debug.Log("player talked");

                }
            }
        }
    }
    
}