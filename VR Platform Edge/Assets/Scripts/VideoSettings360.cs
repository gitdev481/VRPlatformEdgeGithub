using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSettings360 : MonoBehaviour {

	// Use this for initialization
	void Start () {


        GetComponent<Camera>().stereoSeparation = 0.064f; // Eye separation (IPD) of 64mm.

       
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
