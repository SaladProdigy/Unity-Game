using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed; //Player Speed
    public float rb;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Escape key to quit the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        float hormovement = Input.GetAxis("Horizontal") * speed; //Allows left + right movement

        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(hormovement, 0), ForceMode2D.Impulse); 

    }
}
