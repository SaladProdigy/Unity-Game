using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartBehavior : MonoBehaviour {

    Button startButton;

    public bool playTitleMusic = true;

    public AudioSource sMusic;
    public AudioSource gMusic;


    // Use this for initialization
    void Start () {

        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(TaskOnClick);

       // sMusic = GetComponent<AudioSource>();
        //gMusic = GetComponent<AudioSource>();


    }
	
	// Update is called once per frame
	void Update () {

        if (playTitleMusic == true)
        {
            sMusic.Play();
            //gMusic.mute = true;
        }
       

    }

    void TaskOnClick()
    {

        playTitleMusic = false;
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
