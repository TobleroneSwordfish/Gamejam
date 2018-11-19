using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadItem : MonoBehaviour
{
    public TextMesh text;
    public int Value { get { return text.text[0] - '0'; } }
    private void OnMouseDown()
    {
        print("number clicked");
        if (Input.GetMouseButton(0))
        {
            int digit = text.text[0] - '0';
            if (digit < 9)
            {
                text.text = (digit + 1).ToString();
            }
            else
            {
                text.text = "0";
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
