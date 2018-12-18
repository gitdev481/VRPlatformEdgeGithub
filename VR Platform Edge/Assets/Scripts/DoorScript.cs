using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {


    #region variables
    public GameObject rightSideLeftDoor;
    public GameObject rightSideRightDoor;
    public GameObject leftSideLeftDoor;
    public GameObject leftSideRightDoor;
    #endregion

    void Start ()
    {
        rightSideLeftDoor = transform.GetChild(0).gameObject;
        rightSideRightDoor = transform.GetChild(2).gameObject;
        leftSideLeftDoor  = transform.GetChild(1).gameObject;
        leftSideRightDoor = transform.GetChild(3).gameObject;
    }
	
	
	void Update ()
    {
		
	}

  

}
