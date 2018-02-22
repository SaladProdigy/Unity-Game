using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockPhone : MonoBehaviour
{

    public Button unlock;

    public GameObject options; 
    private bool isShowing;

    void Start()
    {
        Button btn = unlock.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        isShowing = !isShowing;
        options.SetActive(isShowing);
        Debug.Log("You have clicked the button!");
    }
}
