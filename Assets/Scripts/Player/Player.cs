﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    Vector2 movement;

    Rigidbody2D rb;
    Animator anim;

    private bool isIdle = true;
    bool isMoving = false;

    const int STATE_IDLE = 0;
    const int STATE_WALK = 1;

    int _currentAnimationState = STATE_IDLE;

    void Start()
    {
        // assigning components to our global variables
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        MovePlayer();
        HandleSpriteDirection();
        //SetAnimationValue();
        //anim.SetBool(STATE_IDLE, isMoving);
    }

    void FixedUpdate()
    {
        // using the movement vector that gets assigned in update here in fixedupdate to apply force to the rigidbody
        rb.AddForce(movement * speed);
    }

    void MovePlayer()
    {
        // assigning our desired movement vector based on player input in the update loop
        movement = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector2.left;

        }

        else if (Input.GetKey(KeyCode.D))
        {
            movement += Vector2.right;

        }

     
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("CB_Animation"))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
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
    
   /* void SetAnimationValue()
    {
        // setting parameters for the animator which controls whether we should be running or be in idle
        // isRunning is true if our movement vector is anything but zero        
        bool isWalking = (movement != Vector2.zero);
        //anim.SetBool("walking", isWalking);


        // using the x component of the rigidbody velocity to affect the speed of the animation so moving slower plays the run animation slower
        if (isWalking)
        {
            float xVelocityMagnitude = Mathf.Abs(rb.velocity.x);

            if (xVelocityMagnitude > 0.1)
            {
                // here i'm dividing the velocity by 4 to give me a percent 0 - 1 value for velocities between 0 - 4. i clamp it between 0 and 1 for velocities over 4
                float animSpeed = Mathf.Clamp01(xVelocityMagnitude / 4);
                // creating a minimum speed for the animation. if you don't it might play so slow that transitions don't happen or are delayed significantly.
                if (animSpeed < 0.2f)
                {
                    animSpeed = 0.2f;
                }

                anim.speed = animSpeed;
            }
        }
        else
        {
            // we only want to change the animation speed for running, so we set the speed back to 1 if we're doing anything else.
            anim.speed = 1;
        }
    }*/
        void changeState(int state)
        {

            if (_currentAnimationState == state)
                return;

            switch (state)
            {

                case STATE_WALK:
                    anim.SetInteger("state", STATE_WALK);
                    break;

                case STATE_IDLE:
                    anim.SetInteger("state", STATE_IDLE);
                    break;

            }
        }
    }


