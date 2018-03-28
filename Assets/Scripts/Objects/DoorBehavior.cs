using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBehavior : MonoBehaviour {

    public GameObject goTo;

    public AudioClip doorSound;

    // Use this for initialization
    void Start () {

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
                SoundBehavior.me.PlaySound(doorSound);
                Debug.Log("pressing E in the doorway");
                Debug.Log("collision object name: " + collision.gameObject.name);
                collision.transform.position = goTo.transform.position;
            }
        }
    }
}
