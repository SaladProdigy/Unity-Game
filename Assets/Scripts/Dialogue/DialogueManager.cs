using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    GameObject currentlyTalkingTo;
    NPCDialogueHolder dialogueOfCurrentConversation;
    int indexInCurrentConversation;

    public GameObject dialogue; 
    private bool isShowing;

    public Text playerName;
    public Text npcName;

    public Text npcUIText;
    public Text playerUIText;

    

    void Start()
    {
        currentlyTalkingTo = null;
        dialogueOfCurrentConversation = null;
        indexInCurrentConversation = 0;
        
      
    }

    void Update()
    {
        /*
			you'll need your own code for when you want to begin a conversation and when you want to advance a conversations.
			always call BeginConversation and pass the GameObject of the npc you're talking to when you start a convo.

			then you need to call AdvanceConversation to go through each line

			when you're done, call EndConversation
		*/


        // temporary code
        if (Input.GetKeyDown(KeyCode.R))
        {
            AdvanceConversation();
        }
    }
    
    public void BeginConversation(GameObject npc)
    {
            isShowing = !isShowing;
            dialogue.SetActive(isShowing);
            currentlyTalkingTo = npc;
            dialogueOfCurrentConversation = npc.GetComponent<NPCDialogueHolder>();
            indexInCurrentConversation = 0;
           


    }

    public void EndConversation()
    {
        currentlyTalkingTo = null;
        dialogueOfCurrentConversation = null;
        indexInCurrentConversation = 0;
    }

    public void AdvanceConversation()
    {

    
        // cheching to make sure we have started a conversation with someone
        if (currentlyTalkingTo != null)
        {

            /*
				this assumes we read all of the npc dialogue then move to player dialogue
				the if statement checks if we've finished reading all of the strings from the npc dialogue
			*/
            if (indexInCurrentConversation < dialogueOfCurrentConversation.npcdialogueSequence.Length)
            {
                // in npc dialogue
                DisplayText(dialogueOfCurrentConversation.npcdialogueSequence[indexInCurrentConversation], npcUIText);
                indexInCurrentConversation++;
            }
            else
            {
                // in player dialogue
                if (dialogueOfCurrentConversation.playerdialogueSequence.Length > 0)
                {
                    DisplayText(dialogueOfCurrentConversation.playerdialogueSequence[indexInCurrentConversation - dialogueOfCurrentConversation.npcdialogueSequence.Length], playerUIText);
                    indexInCurrentConversation++;
                }


                // this check will auto end the conversation when you've reached the end of the strings you have for it.
                if (indexInCurrentConversation >= (dialogueOfCurrentConversation.npcdialogueSequence.Length + dialogueOfCurrentConversation.playerdialogueSequence.Length))
                {
                    EndConversation();
                }
            }
        }
        else
        {
            Debug.Log("We're not currently talking to anyone!");
        }
    }

    public void DisplayText(string line, Text uiText)
    {
        uiText.text = line;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (currentlyTalkingTo == null)
                {
                    Debug.Log("begin convo");
                    BeginConversation(collision.gameObject);
                    AdvanceConversation();
                   
                }
            }
        }
        if (collision.gameObject.tag == "NPCwQuest")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (currentlyTalkingTo == null)
                {
                    Debug.Log("begin convo");
                    BeginConversation(collision.gameObject);
                    AdvanceConversation();
                   
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            if (currentlyTalkingTo != null)
            {
                
                EndConversation();
                
            }
        }

         if (collision.gameObject.tag == "NPCwQuest")
         {
             if (currentlyTalkingTo != null)
            { 
                EndConversation();
                
            }
         }
    }
}
