using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            //hit can be implicitely coverted to a bool to check if the raycast hit anything

            if (hit)
            {
                if (hit.collider.gameObject.tag == "clickable object")
                {
                    Debug.Log("you have clicked something, cunt");
                }
            }

        }

   // void OnMouseOver()
   // {
       

     //       print("Click");
      // }

    }
}
