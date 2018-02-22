using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed; //Player Speed


    Rigidbody2D rb;
    float hormovement = 0;

    float facing = 0;

    // Use this for initialization
    void Start () {
       rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        //Escape key to quit the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        hormovement = Input.GetAxis("Horizontal") * speed; //Allows left + right movement
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            facing = hormovement;
        }
        if (facing > 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
        else
        {
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x);
            transform.localScale = scale;
        }


        //buildindex for changing through rooms??

    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(hormovement, 0));
    }


}
