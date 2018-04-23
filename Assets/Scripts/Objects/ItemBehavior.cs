using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    //Animation
    public AnimationCurve myCurve;

    //Game Objects
    public GameObject turnOn;
    public GameObject turnOff;

    //Bools
    private bool isOn;
    private bool isShowing;

    //Audio
    public AudioClip itemSound;


    void Update()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("pressing e");
                if (gameObject.activeSelf == true)
                {
                    SoundBehavior.me.PlaySound(itemSound);
                    Debug.Log("You Collected The Item");
                    gameObject.SetActive(false);
                    //turn on in inventory

                    isOn = !isOn;
                    turnOn.SetActive(isOn);

                    isShowing = false;
                    turnOff.SetActive(false);

                }
            }
        }
    }

}