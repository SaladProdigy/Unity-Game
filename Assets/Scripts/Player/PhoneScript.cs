using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneScript : MonoBehaviour
{

    public Button phone;


    public GameObject menu; // Assign in inspector
    private bool isShowing;

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

