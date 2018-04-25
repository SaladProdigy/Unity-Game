using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    Vector2 movement;

    Rigidbody2D rb;
    Animator anim;

    const int STATE_IDLE = 0;
    const int STATE_WALK = 1;

    void Start()
    {
        // assigning components to our global variables
        rb = GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        HandleSpriteDirection();
    }

    void FixedUpdate()
    {
        // using the movement vector that gets assigned in update here in fixedupdate to apply force to the rigidbody
        rb.AddForce(movement * speed);

        movement = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector2.left;

            ChangeState(STATE_WALK);
            Debug.Log("is moving left");

        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement += Vector2.right;
            ChangeState(STATE_WALK);


            Debug.Log("is moving right");
        }
        else
        {
            ChangeState(STATE_IDLE);
            Debug.Log("is Idle");
        }
    }


    void HandleSpriteDirection()
    {
        // this code will flip the sprite direction by assigning the x component of the transform scale to be either positive or negative
        if (rb.velocity.x < 0)
        {
            // moving right
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Abs(scale.x);
            transform.localScale = scale;
           
        }
        else if (rb.velocity.x > 0)
        {
            // moving left
            Vector3 scale = transform.localScale;
            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;
           
        }
       
    }

       void ChangeState(int state)
        {

        
        Debug.Log("setting state: " + state);
        anim.SetInteger("state", state);
/*
        switch (state)
            {

                case STATE_WALK:
                    anim.SetInteger("state", STATE_WALK);
                    break;

                case STATE_IDLE:
                    anim.SetInteger("state", STATE_IDLE);
                    break;

            }*/
        }
    }


