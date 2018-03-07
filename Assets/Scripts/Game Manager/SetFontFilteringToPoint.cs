using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class SetFontFilteringToPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<Text>().font.material.mainTexture.filterMode = FilterMode.Point;

    }
}
