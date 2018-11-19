using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public Door nextDoor;
    protected virtual void OpenDoor()
    {
        if (nextDoor != null)
        {
            nextDoor.enabled = true;
        }
        gameObject.SetActive(false);
    }
}
