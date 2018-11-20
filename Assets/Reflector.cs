using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflector : MonoBehaviour {
    public Door parent;
    private void OnMouseDown()
    {
        print("mouse down on child object");
        if (parent.enabled)
        {
            parent.OnMouseDown();
        }
    }
}
