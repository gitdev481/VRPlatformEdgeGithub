using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// This class is to control the behaviour of the train.
/// </summary>
public class Train : MonoBehaviour {

    public List<Animator> doors = new List<Animator>();

    public void Start()
    {
        doors = (transform.GetChild(0).transform.GetComponentsInChildren<Animator>().ToList());
    }

    /// <summary>
    /// Opens all the train doors at the same time
    /// </summary>
    public void OpenTrainDoors()
    {
        Debug.Log("A");
        for(int i = 0; i < doors.Count; i++)
        {
            doors[i].SetTrigger("TriggerOpenDoors");
        }
    }
}
