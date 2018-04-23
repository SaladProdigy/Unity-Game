using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    //Scripts and Extra
    NPCDialogueHolder dialogueOfCurrentConversation;
    int indexInCurrentConversation;

    //Game Objects
    public GameObject dialogue;
    public GameObject currentlyTalkingTo;
    public GameObject popUp;

    //Buttons
    public Button continueButton;

    //Bools
    private bool isShowing;
    private bool isInteractive;

    //Texts
    public Text npcUIText;
    public Text playerUIText;


    void Start()
    {
        currentlyTalkingTo = null;
        dialogueOfCurrentConversation = null;
        indexInCurrentConversation = 0;

        Button btn = continueButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

        
        void TaskOnClick()
        {
            AdvanceConversation();

        if (currentlyTalkingTo == null)
        {
            EndConversation();

        }

    }
    
    
    public void BeginConversation(GameObject npc)
    {
        StartCoroutine(BeginConversationIE(npc));
    }

    IEnumerator BeginConversationIE (GameObject npc)
    {
        yield return null;
        Debug.Log("beginning convo");
        isShowing = !isShowing;
        dialogue.SetActive(isShowing);
        currentlyTalkingTo = npc;
        dialogueOfCurrentConversation = npc.GetComponent<NPCDialogueHolder>();
        indexInCurrentConversation = 0;

        AdvanceConversation();
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
            Debug.Log("index in current convo: " + indexInCurrentConversation + ". dialogue of current convo length: " + dialogueOfCurrentConversation.npcdialogueSequence.Length);
            if (indexInCurrentConversation < dialogueOfCurrentConversation.npcdialogueSequence.Length)
            {
                // in npc dialogue
                Debug.Log("hey");
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
            EndConversation();

            isShowing = false;
            dialogue.SetActive(false);
        }
    }

    public void DisplayText(string line, Text uiText)
    {
        Debug.Log("trying to display text: " + line);
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
                    Debug.Log("begin convo. colliding with: " + collision.gameObject.name);
                    BeginConversation(collision.gameObject);
                //  AdvanceConversation();
                   
                }
            }
        }
        if (collision.gameObject.tag == "NPCwQuest")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (currentlyTalkingTo == null)
                {
                    Debug.Log("begin convo. colliding with: " + collision.gameObject.name);
                    BeginConversation(collision.gameObject);
                //  AdvanceConversation();
                

                }
            }
        }
        if (collision.gameObject.tag == "ObjwDesc")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (currentlyTalkingTo == null)
                {
                    Debug.Log("begin convo. colliding with: " + collision.gameObject.name);
                    BeginConversation(collision.gameObject);
              //    AdvanceConversation();
                    

                }
            }
        }

        if (collision.gameObject.tag == "Itemwdesc")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (currentlyTalkingTo == null)
                {
                    Debug.Log("begin convo. colliding with: " + collision.gameObject.name);
                    BeginConversation(collision.gameObject);
               //   AdvanceConversation();
                   

                }
            }
        }
    }
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
            Debug.Log("Is On");
            isInteractive = !isInteractive;
            popUp.SetActive(true);
        }

        if (collision.gameObject.tag == "NPCwQuest")
        {
            Debug.Log("Is On");
            isInteractive = !isInteractive;
            popUp.SetActive(true);
        }
        if (collision.gameObject.tag == "ObjwDesc")
        {
            Debug.Log("Is On");
            isInteractive = !isInteractive;
            popUp.SetActive(true);
        }
        if (collision.gameObject.tag == "ItemwDesc")
        {
            Debug.Log("Is On" + collision.gameObject.name);
            isInteractive = !isInteractive;
            popUp.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NPC")
        {
  
                popUp.SetActive(false);
            
        }

        if (collision.gameObject.tag == "NPCwQuest")
        {

                popUp.SetActive(false);
  
        }
        if (collision.gameObject.tag == "ObjwDesc")
        {
            
                popUp.SetActive(false);
            
        }
        if (collision.gameObject.tag == "ItemwDesc")
        {
         
                popUp.SetActive(false);
         
        }
    }


}


