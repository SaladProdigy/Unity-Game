using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpText : MonoBehaviour {

    public GameObject popUpText;
    bool isShowing = false;

    NPCDialogueHolder dialogueOfCurrentConversation;

    public Text npcUIText;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            isShowing = !isShowing;
            popUpText.SetActive(isShowing);
        }
    }
}
