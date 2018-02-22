using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject objectToFollow;
    Vector3 cameraOffSet;


    // Use this for initialization
    void Start () {
        cameraOffSet = new Vector3(1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y, 50f);
        position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x, 50f);

        this.transform.position = position + cameraOffSet;
    }

}

