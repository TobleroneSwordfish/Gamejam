using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadDoor : Door {
    public GameObject buttonParent;
    public string passCode;
    private KeypadItem[] buttons;
	// Use this for initialization
	public override void Start () {
        buttons = buttonParent.GetComponentsInChildren<KeypadItem>();
        base.Start();
	}
    public override void OnMouseDown()
    {
        
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
