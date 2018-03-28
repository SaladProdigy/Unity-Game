using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObject : MonoBehaviour {

    public GameObject desiredObject;
    public GameObject boxcollider;

    PlayerInventory inventory;
    NPCDialogueHolder npcDialogueHolder;

    public bool questStart = false;

    public string[] hasDesiredObjectDialogueNPC;
    public string[] doesNotHaveDesiredObjectDialogueNPC;

    public string[] hasDesiredObjectDialoguePLAYER;
    public string[] doesNotHaveDesiredObjectDialoguePLAYER;

    // Use this for initialization
    void Start () {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
        npcDialogueHolder = GetComponent<NPCDialogueHolder>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                bool hasDesiredObject = false;
                questStart = true;
                Debug.Log("Quest has started");

                if (hasDesiredObject == true)
                {
                    Debug.Log("HAS OBJECT");

                    Debug.Log("before set");

                    npcDialogueHolder.npcdialogueSequence = hasDesiredObjectDialogueNPC;
                    npcDialogueHolder.playerdialogueSequence = hasDesiredObjectDialoguePLAYER;

                    GameObject.Destroy(boxcollider);
                }
                else
                {
                    Debug.Log("DOESN'T HAVE OBJECT");
                    npcDialogueHolder.npcdialogueSequence = doesNotHaveDesiredObjectDialogueNPC;
                    npcDialogueHolder.playerdialogueSequence = hasDesiredObjectDialoguePLAYER;

                }
            }
        }
    }
    
}
