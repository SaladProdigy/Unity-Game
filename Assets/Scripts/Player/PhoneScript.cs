using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneScript : MonoBehaviour
{

    public Button phone;


    public GameObject menu; // Assign in inspector
    private bool isShowing;
    private bool isOn = true;

    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject option4;
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;

    void Start()
    {
        Button btn = phone.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    void TaskOnClick()
    {
        isShowing = !isShowing;
        menu.SetActive(isShowing);
        Debug.Log("You have clicked the button!");

        if (isOn)
        {
            option1.SetActive(false);
            option2.SetActive(false);
            option3.SetActive(false);
            option4.SetActive(false);
            slot1.SetActive(false);
            slot2.SetActive(false);
            slot3.SetActive(false);
            slot4.SetActive(false);
        }

     if (Time.timeScale == 1)
          {
               Time.timeScale = 0;
          }
            else
            {
                Time.timeScale = 1;
            }
     }  
    }

