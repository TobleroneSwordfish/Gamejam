using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadDoor : Door {
    public GameObject buttonParent;
    public string passCode;
    private KeypadItem[] buttons;
	// Use this for initialization
	void Start () {
        buttons = buttonParent.GetComponentsInChildren<KeypadItem>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        string value = "";
		foreach (KeypadItem button in buttons)
        {
            value += button.Value.ToString();
        }
        if (value == passCode)
        {
            OpenDoor();
        }
	}
}
